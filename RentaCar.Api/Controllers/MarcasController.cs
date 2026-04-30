using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MarcasController : ControllerBase
    {
        private readonly MarcaRepositorio _repoMarcas;

        public MarcasController(MarcaRepositorio repoMarcas)
        {
            _repoMarcas = repoMarcas;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var marcas = _repoMarcas.ObtenerTodos();
            return Ok(marcas);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var marca = _repoMarcas.ObtenerPorId(id);

            if (marca == null)
                return NotFound("Marca no encontrada");

            return Ok(marca);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] Marca marca)
        {
            if (marca == null)
                return BadRequest("Datos inválidos");

            _repoMarcas.Agregar(marca);

            return Ok("Marca creada correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] Marca marca)
        {
            if (marca == null || id != marca.Id)
                return BadRequest("Datos inválidos");

            var existente = _repoMarcas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Marca no encontrada");

            _repoMarcas.Actualizar(marca);

            return Ok("Marca actualizada correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoMarcas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Marca no encontrada");

            _repoMarcas.Eliminar(id);

            return Ok("Marca eliminada correctamente");
        }
    }
}