using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Roles;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        private readonly RolRepositorio _repo;

        public RolesController(RolRepositorio repo)
        {
            _repo = repo;
        }

        // GET: /roles
        [HttpGet]
        public ActionResult<List<RolResponse>> ObtenerTodos()
        {
            var roles = _repo.ObtenerTodos();

            var response = roles.Select(r => new RolResponse
            {
                Id = r.Id,
                Nombre = r.Nombre
            }).ToList();

            return Ok(response);
        }

        // GET: /roles/{id}
        [HttpGet("{id}")]
        public ActionResult<RolResponse> ObtenerPorId(int id)
        {
            var rol = _repo.ObtenerPorId(id);

            if (rol == null)
                return NotFound();

            var response = new RolResponse
            {
                Id = rol.Id,
                Nombre = rol.Nombre
            };

            return Ok(response);
        }

        // POST: /roles
        [HttpPost]
        public ActionResult Crear(RolCreateRequest request)
        {
            var rol = new Rol
            {
                Nombre = request.Nombre
            };

            _repo.Agregar(rol);

            return Ok();
        }

        // PUT: /roles/{id}
        [HttpPut("{id}")]
        public ActionResult Actualizar(int id, RolUpdateRequest request)
        {
            var rol = _repo.ObtenerPorId(id);

            if (rol == null)
                return NotFound();

            rol.Nombre = request.Nombre;

            _repo.Actualizar(rol);

            return Ok();
        }

        // DELETE: /roles/{id}
        [HttpDelete("{id}")]
        public ActionResult Eliminar(int id)
        {
            var rol = _repo.ObtenerPorId(id);

            if (rol == null)
                return NotFound();

            _repo.Eliminar(id);

            return Ok();
        }
    }
}