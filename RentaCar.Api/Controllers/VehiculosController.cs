using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculosController : ControllerBase
    {
        private readonly VehiculoRepositorio _repoVehiculos;

        public VehiculosController(VehiculoRepositorio repoVehiculos)
        {
            _repoVehiculos = repoVehiculos;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var vehiculos = _repoVehiculos.ObtenerTodos();
            return Ok(vehiculos);
        }

        [HttpGet("{patente}")]
        public IActionResult ObtenerPorPatente(string patente)
        {
            var vehiculo = _repoVehiculos.ObtenerPorPatente(patente);

            if (vehiculo == null)
                return NotFound("Vehículo no encontrado");

            return Ok(vehiculo);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] Vehiculo vehiculo)
        {
            if (vehiculo == null)
                return BadRequest("Datos inválidos");

            if (_repoVehiculos.ExistePatente(vehiculo.Patente))
                return BadRequest("La patente ya existe");

            _repoVehiculos.Agregar(vehiculo);

            return Ok("Vehículo creado correctamente");
        }

        [HttpPut("{patente}")]
        public IActionResult Actualizar(string patente, [FromBody] Vehiculo vehiculo)
        {
            if (vehiculo == null || patente != vehiculo.Patente)
                return BadRequest("Datos inválidos");

            var existente = _repoVehiculos.ObtenerPorPatente(patente);

            if (existente == null)
                return NotFound("Vehículo no encontrado");

            _repoVehiculos.Actualizar(vehiculo);

            return Ok("Vehículo actualizado correctamente");
        }

        [HttpDelete("{patente}")]
        public IActionResult Eliminar(string patente)
        {
            var existente = _repoVehiculos.ObtenerPorPatente(patente);

            if (existente == null)
                return NotFound("Vehículo no encontrado");

            _repoVehiculos.Eliminar(patente);

            return Ok("Vehículo eliminado correctamente");
        }
    }
}