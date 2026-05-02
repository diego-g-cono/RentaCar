using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Marcas;
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

            var response = marcas.Select(m => new MarcaResponse
            {
                Id = m.Id,
                Nombre = m.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var marca = _repoMarcas.ObtenerPorId(id);

            if (marca == null)
                return NotFound("Marca no encontrada");

            var response = new MarcaResponse
            {
                Id = marca.Id,
                Nombre = marca.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] MarcaCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var marca = new Dominio.Marca
            {
                Nombre = request.Nombre
            };

            _repoMarcas.Agregar(marca);

            return Ok("Marca creada correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] MarcaUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoMarcas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Marca no encontrada");

            existente.Nombre = request.Nombre;

            _repoMarcas.Actualizar(existente);

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