using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly IWebHostEnvironment _env;

        public VehiculosController(VehiculoRepositorio repoVehiculos, IWebHostEnvironment env)
        {
            _repoVehiculos = repoVehiculos;
            _env = env;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var vehiculos = _repoVehiculos.ObtenerTodos();

            var response = vehiculos.Select(v => new VehiculoResponse
            {
                Patente = v.Patente,
                Anio = v.Anio,
                Kilometraje = v.Kilometraje,

                MarcaId = v.MarcaId,
                MarcaNombre = v.Marca?.Nombre,

                ModeloId = v.ModeloId,
                ModeloNombre = v.Modelo?.Nombre,

                ColorId = v.ColorId,
                ColorNombre = v.Color?.Nombre,

                CombustibleId = v.CombustibleId,
                CombustibleNombre = v.Combustible?.Nombre,

                EstadoId = v.EstadoId,
                EstadoNombre = v.Estado?.Nombre,

                TipoId = v.TipoId,
                TipoNombre = v.Tipo?.Nombre,

                ImagenUrl = v.ImagenUrl
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{patente}")]
        public IActionResult ObtenerPorPatente(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
                return BadRequest("Patente inválida");

            var v = _repoVehiculos.ObtenerPorPatente(patente);

            if (v == null)
                return NotFound("Vehículo no encontrado");

            var response = new VehiculoResponse
            {
                Patente = v.Patente,
                Anio = v.Anio,
                Kilometraje = v.Kilometraje,

                MarcaId = v.MarcaId,
                MarcaNombre = v.Marca?.Nombre,

                ModeloId = v.ModeloId,
                ModeloNombre = v.Modelo?.Nombre,

                ColorId = v.ColorId,
                ColorNombre = v.Color?.Nombre,

                CombustibleId = v.CombustibleId,
                CombustibleNombre = v.Combustible?.Nombre,

                EstadoId = v.EstadoId,
                EstadoNombre = v.Estado?.Nombre,

                TipoId = v.TipoId,
                TipoNombre = v.Tipo?.Nombre,

                ImagenUrl = v.ImagenUrl
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] VehiculoCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            if (_repoVehiculos.ExistePatente(request.Patente))
                return BadRequest("La patente ya existe");

            var vehiculo = new Vehiculo
            {
                Patente = request.Patente,
                Anio = request.Anio,
                Kilometraje = request.Kilometraje,
                MarcaId = request.MarcaId,
                ModeloId = request.ModeloId,
                ColorId = request.ColorId,
                CombustibleId = request.CombustibleId,
                EstadoId = request.EstadoId,
                TipoId = request.TipoId
            };

            _repoVehiculos.Agregar(vehiculo);

            return Ok("Vehículo creado correctamente");
        }

        [HttpPut("{patente}")]
        public IActionResult Actualizar(string patente, [FromBody] VehiculoUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoVehiculos.ObtenerPorPatente(patente);

            if (existente == null)
                return NotFound("Vehículo no encontrado");

            existente.Anio = request.Anio;
            existente.Kilometraje = request.Kilometraje;
            existente.MarcaId = request.MarcaId;
            existente.ModeloId = request.ModeloId;
            existente.ColorId = request.ColorId;
            existente.CombustibleId = request.CombustibleId;
            existente.EstadoId = request.EstadoId;
            existente.TipoId = request.TipoId;

            _repoVehiculos.Actualizar(existente);

            return Ok("Vehículo actualizado correctamente");
        }

        [HttpDelete("{patente}")]
        public IActionResult Eliminar(string patente)
        {
            var existente = _repoVehiculos.ObtenerPorPatente(patente);

            if (existente == null)
                return NotFound("Vehículo no encontrado");

            _repoVehiculos.Eliminar(patente);

            return Ok("Vehículo eliminado correctamente");
        }

        [HttpGet("disponibles")]
        public IActionResult ObtenerDisponibles(DateOnly fechaInicio, DateOnly fechaFin)
        {
            var vehiculos = _repoVehiculos.ObtenerDisponibles(fechaInicio, fechaFin);

            var response = vehiculos.Select(v => new VehiculoResponse
            {
                Patente = v.Patente,
                Anio = v.Anio,
                Kilometraje = v.Kilometraje,

                MarcaId = v.MarcaId,
                MarcaNombre = v.Marca?.Nombre,

                ModeloId = v.ModeloId,
                ModeloNombre = v.Modelo?.Nombre,

                ColorId = v.ColorId,
                ColorNombre = v.Color?.Nombre,

                CombustibleId = v.CombustibleId,
                CombustibleNombre = v.Combustible?.Nombre,

                EstadoId = v.EstadoId,
                EstadoNombre = v.Estado?.Nombre,

                TipoId = v.TipoId,
                TipoNombre = v.Tipo?.Nombre,

                ImagenUrl = v.ImagenUrl
            }).ToList();

            return Ok(response);
        }

        [HttpPost("{patente}/imagen")]
        public async Task<IActionResult> SubirImagen(
      string patente,
      IFormFile archivo)
        {
            var vehiculo =
                _repoVehiculos.ObtenerPorPatente(patente);

            if (vehiculo == null)
                return NotFound();

            var nombreArchivo =
                $"{Guid.NewGuid()}{Path.GetExtension(archivo.FileName)}";

            var carpetaImagenes = Path.Combine(
                _env.ContentRootPath,
                "wwwroot",
                "images",
                "autos");

            Directory.CreateDirectory(carpetaImagenes);

            var rutaFisica = Path.Combine(
                carpetaImagenes,
                nombreArchivo);

            await using var stream =
                new FileStream(rutaFisica, FileMode.Create);

            await archivo.CopyToAsync(stream);

            vehiculo.ImagenUrl =
                $"/images/autos/{nombreArchivo}";

            _repoVehiculos.Actualizar(vehiculo);

            return Ok(vehiculo.ImagenUrl);
        }
    }
}