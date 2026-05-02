using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Color;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ColoresController : ControllerBase
    {
        private readonly ColorRepositorio _repoColores;

        public ColoresController(ColorRepositorio repoColores)
        {
            _repoColores = repoColores;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var colores = _repoColores.ObtenerTodos();

            var response = colores.Select(c => new ColorResponse
            {
                Id = c.Id,
                Nombre = c.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var color = _repoColores.ObtenerPorId(id);

            if (color == null)
                return NotFound("Color no encontrado");

            var response = new ColorResponse
            {
                Id = color.Id,
                Nombre = color.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ColorCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var color = new Dominio.Color
            {
                Nombre = request.Nombre
            };

            _repoColores.Agregar(color);

            return Ok("Color creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] ColorUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoColores.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Color no encontrado");

            existente.Nombre = request.Nombre;

            _repoColores.Actualizar(existente);

            return Ok("Color actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoColores.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Color no encontrado");

            _repoColores.Eliminar(id);

            return Ok("Color eliminado correctamente");
        }
    }
}