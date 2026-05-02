using Microsoft.AspNetCore.Mvc;
using RentaCar.Dtos.Tipo;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiposVehiculoController : ControllerBase
    {
        private readonly TipoVehiculoRepositorio _repo;

        public TiposVehiculoController(TipoVehiculoRepositorio repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var tipos = _repo.ObtenerTodos();

            var response = tipos.Select(t => new TipoResponse
            {
                Id = t.Id,
                Nombre = t.Nombre
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var tipo = _repo.ObtenerPorId(id);

            if (tipo == null)
                return NotFound("Tipo de vehículo no encontrado");

            var response = new TipoResponse
            {
                Id = tipo.Id,
                Nombre = tipo.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] TipoCreateRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Nombre))
                return BadRequest("Datos inválidos");

            var tipo = new Dominio.TipoVehiculo
            {
                Nombre = request.Nombre
            };

            _repo.Agregar(tipo);

            return Ok("Tipo de vehículo creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] TipoUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Tipo de vehículo no encontrado");

            existente.Nombre = request.Nombre;

            _repo.Actualizar(existente);

            return Ok("Tipo de vehículo actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Tipo de vehículo no encontrado");

            _repo.Eliminar(id);

            return Ok("Tipo de vehículo eliminado correctamente");
        }
    }
}