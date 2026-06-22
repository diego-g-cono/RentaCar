using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Conductores;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConductoresController : ControllerBase
    {
        private readonly ConductorRepositorio _repo;

        public ConductoresController(ConductorRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var conductores = _repo.ObtenerTodos();

            var response = conductores.Select(c => new ConductorResponse
            {
                Dni = c.Dni,
                Nombre = c.Nombre,
                Apellido = c.Apellido,
                FechaVencLic = c.FechaVencLic
            });

            return Ok(response);
        }

        [HttpGet("{dni}")]
        public IActionResult ObtenerPorDni(int dni)
        {
            var conductor = _repo.ObtenerPorDni(dni);

            if (conductor == null)
                return NotFound("Conductor no encontrado");

            var response = new ConductorResponse
            {
                Dni = conductor.Dni,
                Nombre = conductor.Nombre,
                Apellido = conductor.Apellido,
                FechaVencLic = conductor.FechaVencLic
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ConductorCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorDni(request.Dni);

            if (existente != null)
            {
                if (existente.Activo)
                    return Conflict("Ya existe un conductor activo con ese DNI.");

                // Está pero inactivo, lo reactivamos y actualizamos sus datos
                existente.Dni = request.Dni;
                existente.Nombre = request.Nombre;
                existente.Apellido = request.Apellido;
                existente.FechaVencLic = request.FechaVencLic;
                existente.Activo = true;


                _repo.Actualizar(existente);
                return Ok();
            }

            var conductor = new Dominio.Conductor
            {
                Dni = request.Dni,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                FechaVencLic = request.FechaVencLic
            };

            _repo.Agregar(conductor);

            return Ok("Conductor creado correctamente");
        }

        [HttpPut("{dni}")]
        public IActionResult Actualizar(int dni, [FromBody] ConductorUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorDni(dni);

            if (existente == null)
                return NotFound("Conductor no encontrado");

            existente.Nombre = request.Nombre;
            existente.Apellido = request.Apellido;
            existente.FechaVencLic = request.FechaVencLic;

            _repo.Actualizar(existente);

            return Ok("Conductor actualizado correctamente");
        }

        [HttpDelete("{dni}")]
        public IActionResult Eliminar(int dni)
        {
            var existente = _repo.ObtenerPorDni(dni);

            if (existente == null)
                return NotFound("Conductor no encontrado");

            _repo.Eliminar(dni);

            return Ok("Conductor eliminado correctamente");
        }
    }
}