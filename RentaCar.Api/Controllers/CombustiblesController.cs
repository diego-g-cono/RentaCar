using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Combustible;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CombustiblesController : ControllerBase
    {
        private readonly CombustibleRepositorio _repo;

        public CombustiblesController(CombustibleRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var combustibles = _repo.ObtenerTodos();

            var response = combustibles.Select(c => new CombustibleResponse
            {
                Id = c.Id,
                Nombre = c.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var combustible = _repo.ObtenerPorId(id);

            if (combustible == null)
                return NotFound("Combustible no encontrado");

            var response = new CombustibleResponse
            {
                Id = combustible.Id,
                Nombre = combustible.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] CombustibleCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var combustible = new Dominio.Combustible
            {
                Nombre = request.Nombre
            };

            _repo.Agregar(combustible);

            return Ok("Combustible creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] CombustibleUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Combustible no encontrado");

            existente.Nombre = request.Nombre;

            _repo.Actualizar(existente);

            return Ok("Combustible actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Combustible no encontrado");

            _repo.Eliminar(id);

            return Ok("Combustible eliminado correctamente");
        }
    }
}