using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.EstadoVehiculo;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadosVehiculoController : ControllerBase
    {
        private readonly EstadoVehiculoRepositorio _repo;

        public EstadosVehiculoController(EstadoVehiculoRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var estados = _repo.ObtenerTodos();

            var response = estados.Select(e => new EstadoVehiculoResponse
            {
                Id = e.Id,
                Nombre = e.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var estado = _repo.ObtenerPorId(id);

            if (estado == null)
                return NotFound("Estado de vehículo no encontrado");

            var response = new EstadoVehiculoResponse
            {
                Id = estado.Id,
                Nombre = estado.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] EstadoVehiculoCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var estado = new Dominio.EstadoVehiculo
            {
                Nombre = request.Nombre
            };

            _repo.Agregar(estado);

            return Ok("Estado de vehículo creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] EstadoVehiculoUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Estado de vehículo no encontrado");

            existente.Nombre = request.Nombre;

            _repo.Actualizar(existente);

            return Ok("Estado de vehículo actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Estado de vehículo no encontrado");

            _repo.Eliminar(id);

            return Ok("Estado de vehículo eliminado correctamente");
        }
    }
}