using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.EstadoReserva;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EstadosReservaController : ControllerBase
    {
        private readonly EstadoReservaRepositorio _repo;

        public EstadosReservaController(EstadoReservaRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var estados = _repo.ObtenerTodos();

            var response = estados.Select(e => new EstadoReservaResponse
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
                return NotFound("Estado no encontrado");

            var response = new EstadoReservaResponse
            {
                Id = estado.Id,
                Nombre = estado.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] EstadoReservaCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var estado = new Dominio.EstadoReserva
            {
                Nombre = request.Nombre
            };

            _repo.Agregar(estado);

            return Ok("Estado creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] EstadoReservaUpdateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Estado no encontrado");

            existente.Nombre = request.Nombre;

            _repo.Actualizar(existente);

            return Ok("Estado actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Estado no encontrado");

            _repo.Eliminar(id);

            return Ok("Estado eliminado correctamente");
        }
    }
}