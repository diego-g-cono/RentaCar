using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ModelosController : ControllerBase
    {
        private readonly ModeloRepositorio _repoModelos;

        public ModelosController(ModeloRepositorio repoModelos)
        {
            _repoModelos = repoModelos;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var modelos = _repoModelos.ObtenerTodos();
            return Ok(modelos);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var modelo = _repoModelos.ObtenerPorId(id);

            if (modelo == null)
                return NotFound("Modelo no encontrado");

            return Ok(modelo);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] Modelo modelo)
        {
            if (modelo == null)
                return BadRequest("Datos inválidos");

            _repoModelos.Agregar(modelo);

            return Ok("Modelo creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] Modelo modelo)
        {
            if (modelo == null || id != modelo.Id)
                return BadRequest("Datos inválidos");

            var existente = _repoModelos.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Modelo no encontrado");

            _repoModelos.Actualizar(modelo);

            return Ok("Modelo actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoModelos.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Modelo no encontrado");

            _repoModelos.Eliminar(id);

            return Ok("Modelo eliminado correctamente");
        }

        [HttpGet("marca/{marcaId}")]
        public IActionResult ObtenerPorMarca(int marcaId)
        {
            var modelos = _repoModelos.ObtenerPorMarca(marcaId);
            return Ok(modelos);
        }
    }
}