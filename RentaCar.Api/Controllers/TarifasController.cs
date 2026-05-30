using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Tarifas;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarifasController : ControllerBase
    {
        private readonly TarifaRepositorio _repoTarifas;

        public TarifasController(TarifaRepositorio repoTarifas)
        {
            _repoTarifas = repoTarifas;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var tarifas = _repoTarifas.ObtenerTodos();

            var response = tarifas.Select(t => new TarifaResponse
            {
                Id = t.Id,
                PrecioDia = t.PrecioDia,
                PrecioSemana = t.PrecioSemana,
                Activo = t.Activo,

                TipoVehiculoId = t.TipoVehiculoId,
                TipoVehiculoNombre = t.TipoVehiculo?.Nombre
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var t = _repoTarifas.ObtenerPorId(id);

            if (t == null)
                return NotFound("Tarifa no encontrada");

            var response = new TarifaResponse
            {
                Id = t.Id,
                PrecioDia = t.PrecioDia,
                PrecioSemana = t.PrecioSemana,
                Activo = t.Activo,

                TipoVehiculoId = t.TipoVehiculoId,
                TipoVehiculoNombre = t.TipoVehiculo?.Nombre
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] TarifaCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var tarifa = new Tarifa
            {
                PrecioDia = request.PrecioDia,
                PrecioSemana = request.PrecioSemana,
                Activo = request.Activo,
                TipoVehiculoId = request.TipoVehiculoId
            };

            _repoTarifas.Agregar(tarifa);

            return Ok("Tarifa creada correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] TarifaUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoTarifas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Tarifa no encontrada");

            existente.PrecioDia = request.PrecioDia;
            existente.PrecioSemana = request.PrecioSemana;
            existente.Activo = request.Activo;
            existente.TipoVehiculoId = request.TipoVehiculoId;

            _repoTarifas.Actualizar(existente);

            return Ok("Tarifa actualizada correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoTarifas.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Tarifa no encontrada");

            _repoTarifas.Eliminar(id);

            return Ok("Tarifa eliminada correctamente");
        }
    }
}