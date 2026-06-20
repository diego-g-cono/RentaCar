using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Repositorios;
using RentaCar.Dtos.Seguros;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SegurosController : ControllerBase
    {
        private readonly SeguroRepositorio _repoSeguros;

        public SegurosController(SeguroRepositorio repoSeguros)
        {
            _repoSeguros = repoSeguros;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var seguros = _repoSeguros.ObtenerTodos();

            var response = seguros.Select(s => new SeguroResponse
            {
                Id = s.Id,
                Nombre = s.Nombre,
                Tasa = s.Tasa,
                Activo = s.Activo
            });

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var seguro = _repoSeguros.ObtenerPorId(id);

            if (seguro == null)
                return NotFound("Seguro no encontrado");

            var response = new SeguroResponse
            {
                Id = seguro.Id,
                Nombre = seguro.Nombre,
                Tasa = seguro.Tasa,
                Activo = seguro.Activo
            };

            return Ok(response);
        }
    }
}