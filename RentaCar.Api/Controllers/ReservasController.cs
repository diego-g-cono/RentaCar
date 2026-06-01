using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Reservas;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservasController : ControllerBase
    {
        private readonly ReservaRepositorio _repoReservas;
        private readonly ClienteRepositorio _repoClientes;
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly TarifaRepositorio _repoTarifas;
        private readonly SeguroRepositorio _repoSeguros;

        public ReservasController(
            ReservaRepositorio repoReservas,
            ClienteRepositorio repoClientes,
            VehiculoRepositorio repoVehiculos,
            TarifaRepositorio repoTarifas,
            SeguroRepositorio repoSeguros)
        {
            _repoReservas = repoReservas;
            _repoClientes = repoClientes;
            _repoVehiculos = repoVehiculos;
            _repoTarifas = repoTarifas;
            _repoSeguros = repoSeguros;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var reservas = _repoReservas.ObtenerTodos();

            var response = reservas.Select(r => new ReservaResponse
            {
                Id = r.Id,
                ClienteDni = r.ClienteDni,
                ClienteNombre = r.Cliente?.Nombre,
                VehiculoPatente = r.VehiculoPatente,
                FechaInicio = r.FechaInicio,
                FechaFin = r.FechaFin,
                Precio = r.Precio,
                Senia = r.Senia,
                EstadoId = r.EstadoId,
                EstadoNombre = r.Estado?.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var r = _repoReservas.ObtenerPorId(id);

            if (r == null)
                return NotFound("Reserva no encontrada");

            var response = new ReservaResponse
            {
                Id = r.Id,
                ClienteDni = r.ClienteDni,
                ClienteNombre = r.Cliente?.Nombre,
                VehiculoPatente = r.VehiculoPatente,
                FechaInicio = r.FechaInicio,
                FechaFin = r.FechaFin,
                Precio = r.Precio,
                Senia = r.Senia,
                EstadoId = r.EstadoId,
                EstadoNombre = r.Estado?.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ReservaCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            if (request.FechaFin < request.FechaInicio)
                return BadRequest("La fecha fin no puede ser menor a la fecha inicio");

            var cliente = _repoClientes.ObtenerPorDni(request.ClienteDni);
            if (cliente == null)
                return BadRequest("El cliente no existe");

            var vehiculo = _repoVehiculos.ObtenerPorPatente(request.VehiculoPatente);
            if (vehiculo == null)
                return BadRequest("El vehículo no existe");

            var reservasExistentes = _repoReservas.ObtenerPorVehiculo(request.VehiculoPatente);

            bool haySolapamiento = reservasExistentes.Any(r =>
                r.Activo &&
                r.EstadoId != 3 &&
                request.FechaInicio <= r.FechaFin &&
                request.FechaFin >= r.FechaInicio
            );

            if (haySolapamiento)
                return BadRequest("El vehículo ya está reservado en ese período");

            var reserva = new Dominio.Reserva
            {
                ClienteDni = request.ClienteDni,
                VehiculoPatente = request.VehiculoPatente,
                FechaInicio = request.FechaInicio,
                FechaFin = request.FechaFin,
                Precio = request.Precio,
                Senia = request.Senia,
                EstadoId = request.EstadoId
            };

            _repoReservas.Agregar(reserva);

            return Ok("Reserva creada correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] ReservaUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoReservas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Reserva no encontrada");

            if (request.FechaFin < request.FechaInicio)
                return BadRequest("La fecha fin no puede ser menor a la fecha inicio");

            var reservasExistentes = _repoReservas.ObtenerPorVehiculo(request.VehiculoPatente);

            bool haySolapamiento = reservasExistentes.Any(r =>
                r.Id != id &&
                request.FechaInicio <= r.FechaFin &&
                request.FechaFin >= r.FechaInicio
            );

            if (haySolapamiento)
                return BadRequest("El vehículo ya está reservado en ese período");

            existente.ClienteDni = request.ClienteDni;
            existente.VehiculoPatente = request.VehiculoPatente;
            existente.FechaInicio = request.FechaInicio;
            existente.FechaFin = request.FechaFin;
            existente.Precio = request.Precio;
            existente.Senia = request.Senia;
            existente.EstadoId = request.EstadoId;

            _repoReservas.Actualizar(existente);

            return Ok("Reserva actualizada correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoReservas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Reserva no encontrada");

            _repoReservas.Eliminar(id);

            return Ok("Reserva eliminada correctamente");
        }

        [HttpPut("cancelar/{id}")]
        public IActionResult CancelarReserva(int id)
        {
            var reserva = _repoReservas.ObtenerPorId(id);

            if (reserva == null)
                return NotFound("Reserva no encontrada");

            _repoReservas.CancelarReserva(id);

            return Ok("Reserva cancelada correctamente");
        }
        [HttpGet("usuario/{usuarioId}")]
        public IActionResult ObtenerPorUsuario(int usuarioId)
        {
            var cliente = _repoClientes.ObtenerPorUsuarioId(usuarioId);

            if (cliente == null)
                return NotFound("Cliente no encontrado");

            var reservas = _repoReservas.ObtenerTodos()
                .Where(r => r.ClienteDni == cliente.Dni)
                .ToList();

            var response = reservas.Select(r => new ReservaResponse
            {
                Id = r.Id,
                ClienteDni = r.ClienteDni,
                ClienteNombre = r.Cliente?.Nombre,
                VehiculoPatente = r.VehiculoPatente,
                FechaInicio = r.FechaInicio,
                FechaFin = r.FechaFin,
                Precio = r.Precio,
                Senia = r.Senia,
                EstadoId = r.EstadoId,
                EstadoNombre = r.Estado?.Nombre,
                VehiculoMarca = r.Vehiculo?.Marca.Nombre,
                VehiculoModelo = r.Vehiculo?.Modelo.Nombre,
                Activo = r.Activo
            });

            return Ok(response);
        }
        [HttpGet("calcular-precio")]
        public IActionResult CalcularPrecio(
    string patente,
    DateOnly inicio,
    DateOnly fin,
    int seguroId)
        {
            var vehiculo = _repoVehiculos.ObtenerPorPatente(patente);

            if (vehiculo == null)
                return NotFound();

            var tarifa = _repoTarifas.ObtenerPorTipo(
                vehiculo.TipoId
            );

            var seguro = _repoSeguros.ObtenerPorId(seguroId);

            int dias = (fin.ToDateTime(TimeOnly.MinValue)
                        - inicio.ToDateTime(TimeOnly.MinValue))
                        .Days;

            if (dias <= 0)
                dias = 1;

            int semanas = dias / 7;
            int diasRestantes = dias % 7;

            decimal subtotal =
                semanas * tarifa.PrecioSemana +
                diasRestantes * tarifa.PrecioDia;

            decimal total = subtotal * seguro.Tasa;

            return Ok(total);
        }
    }
}