using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Devoluciones;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevolucionesController : ControllerBase
    {
        private readonly DevolucionRepositorio _repo;
        private readonly AlquilerRepositorio _repoAlquileres;

        public DevolucionesController(DevolucionRepositorio repo, AlquilerRepositorio repoAlquileres)
        {
            _repo = repo;
            _repoAlquileres = repoAlquileres;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var devoluciones = _repo.ObtenerTodos();

            var response = devoluciones.Select(d => new DevolucionResponse
            {
                Id = d.Id,
                Fecha = d.Fecha,
                AlquilerId = d.AlquilerId,
                TanqueLleno = d.TanqueLleno,
                Observaciones = d.Observaciones
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var d = _repo.ObtenerPorId(id);

            if (d == null)
                return NotFound("Devolución no encontrada");

            var response = new DevolucionResponse
            {
                Id = d.Id,
                Fecha = d.Fecha,
                AlquilerId = d.AlquilerId,
                TanqueLleno = d.TanqueLleno,
                Observaciones = d.Observaciones
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] DevolucionCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var devolucion = new Devolucion
            {
                Fecha = request.Fecha,
                AlquilerId = request.AlquilerId,
                TanqueLleno = request.TanqueLleno,
                Observaciones = request.Observaciones
            };


            var alquiler = _repoAlquileres.ObtenerPorId(request.AlquilerId);

            if (alquiler != null)
            {
                alquiler.EstadoId = 1; // Finalizado
                _repoAlquileres.Actualizar(alquiler);
            }
            _repo.Agregar(devolucion);

            return Ok("Devolución creada correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] DevolucionUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Devolución no encontrada");

            existente.Fecha = request.Fecha;
            existente.AlquilerId = request.AlquilerId;
            existente.TanqueLleno = request.TanqueLleno;
            existente.Observaciones = request.Observaciones;

            _repo.Actualizar(existente);

            return Ok("Devolución actualizada correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repo.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Devolución no encontrada");

            _repo.Eliminar(id);

            return Ok("Devolución eliminada correctamente");
        }
    }
}