using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Alquileres;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlquileresController : ControllerBase
    {
        private readonly AlquilerRepositorio _repoAlquileres;

        public AlquileresController(AlquilerRepositorio repoAlquileres)
        {
            _repoAlquileres = repoAlquileres;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var alquileres = _repoAlquileres.ObtenerTodos();

            var response = alquileres.Select(a => new AlquilerResponse
            {
                Id = a.Id,
                FechaInicio = a.FechaInicio,
                FechaFin = a.FechaFin,
                Precio = a.Precio,

                VehiculoPatente = a.VehiculoPatente,

                ConductorDni = a.ConductorDni,
                ConductorNombre = a.Conductor != null
                    ? $"{a.Conductor.Nombre} {a.Conductor.Apellido}"
                    : null,

                ClienteDni = a.ClienteDni,
                ClienteNombre = a.Cliente != null
                    ? $"{a.Cliente.Nombre} {a.Cliente.Apellido}"
                    : null,

                EstadoId = a.EstadoId,
                EstadoNombre = a.Estado?.Nombre,

                ReservaId = a.ReservaId
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var a = _repoAlquileres.ObtenerPorId(id);

            if (a == null)
                return NotFound("Alquiler no encontrado");

            var response = new AlquilerResponse
            {
                Id = a.Id,
                FechaInicio = a.FechaInicio,
                FechaFin = a.FechaFin,
                Precio = a.Precio,

                VehiculoPatente = a.VehiculoPatente,

                ConductorDni = a.ConductorDni,
                ConductorNombre = a.Conductor != null
                    ? $"{a.Conductor.Nombre} {a.Conductor.Apellido}"
                    : null,

                ClienteDni = a.ClienteDni,
                ClienteNombre = a.Cliente != null
                    ? $"{a.Cliente.Nombre} {a.Cliente.Apellido}"
                    : null,

                EstadoId = a.EstadoId,
                EstadoNombre = a.Estado?.Nombre,

                ReservaId = a.ReservaId
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] AlquilerCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var alquiler = new Alquiler
            {
                FechaInicio = request.FechaInicio,
                FechaFin = request.FechaFin,
                Precio = request.Precio,
                VehiculoPatente = request.VehiculoPatente,
                ConductorDni = request.ConductorDni,
                ClienteDni = request.ClienteDni,
                EstadoId = request.EstadoId,
                ReservaId = request.ReservaId
            };

            _repoAlquileres.Agregar(alquiler);

            return Ok("Alquiler creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] AlquilerUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoAlquileres.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Alquiler no encontrado");

            existente.FechaInicio = request.FechaInicio;
            existente.FechaFin = request.FechaFin;
            existente.Precio = request.Precio;
            existente.VehiculoPatente = request.VehiculoPatente;
            existente.ConductorDni = request.ConductorDni;
            existente.ClienteDni = request.ClienteDni;
            existente.EstadoId = request.EstadoId;
            existente.ReservaId = request.ReservaId;

            _repoAlquileres.Actualizar(existente);

            return Ok("Alquiler actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoAlquileres.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Alquiler no encontrado");

            _repoAlquileres.Eliminar(id);

            return Ok("Alquiler eliminado correctamente");
        }
    }
}