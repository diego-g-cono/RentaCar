using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Modelos;
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

            var response = modelos.Select(m => new ModeloResponse
            {
                Id = m.Id,
                Nombre = m.Nombre,
                MarcaId = m.MarcaId,
                MarcaNombre = m.Marca?.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var modelo = _repoModelos.ObtenerPorId(id);

            if (modelo == null)
                return NotFound("Modelo no encontrado");

            var response = new ModeloResponse
            {
                Id = modelo.Id,
                Nombre = modelo.Nombre,
                MarcaId = modelo.MarcaId,
                MarcaNombre = modelo.Marca?.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] ModeloCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var modelo = new Dominio.Modelo
            {
                Nombre = request.Nombre,
                MarcaId = request.MarcaId
            };

            _repoModelos.Agregar(modelo);

            return Ok("Modelo creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] ModeloUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoModelos.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Modelo no encontrado");

            existente.Nombre = request.Nombre;
            existente.MarcaId = request.MarcaId;

            _repoModelos.Actualizar(existente);

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

            var response = modelos.Select(m => new ModeloResponse
            {
                Id = m.Id,
                Nombre = m.Nombre,
                MarcaId = m.MarcaId,
                MarcaNombre = m.Marca?.Nombre
            });

            return Ok(response);
        }
    }
}