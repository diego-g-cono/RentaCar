using Microsoft.AspNetCore.Mvc;
using RentaCar.Dominio;
using RentaCar.Dtos.Usuarios;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepositorio _repoUsuarios;

        public UsuariosController(UsuarioRepositorio repoUsuarios)
        {
            _repoUsuarios = repoUsuarios;
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var usuarios = _repoUsuarios.ObtenerTodos();

            var response = usuarios.Select(u => new UsuarioResponse
            {
                Id = u.Id,
                NombreUsuario = u.NombreUsuario,
                RolId = u.RolId,
                Activo = u.Activo
            }).ToList();

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPorId(int id)
        {
            var u = _repoUsuarios.ObtenerPorId(id);

            if (u == null)
                return NotFound("Usuario no encontrado");

            var response = new UsuarioResponse
            {
                Id = u.Id,
                NombreUsuario = u.NombreUsuario,
                RolId = u.RolId,
                Activo = u.Activo
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult Crear([FromBody] UsuarioCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            if (_repoUsuarios.ExisteNombreUsuario(request.NombreUsuario))
                return BadRequest("El nombre de usuario ya existe");

            var usuario = new Usuario
            {
                NombreUsuario = request.NombreUsuario,
                Contrasenia = request.Contrasenia,
                RolId = request.RolId,
                Activo = request.Activo
            };

            _repoUsuarios.Agregar(usuario);

            return Ok("Usuario creado correctamente");
        }

        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] UsuarioUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var existente = _repoUsuarios.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Usuario no encontrado");

            existente.NombreUsuario = request.NombreUsuario;

            if (!string.IsNullOrWhiteSpace(request.Contrasenia))
                existente.Contrasenia = request.Contrasenia;

            existente.RolId = request.RolId;
            existente.Activo = request.Activo;

            _repoUsuarios.Actualizar(existente);

            return Ok("Usuario actualizado correctamente");
        }

        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var existente = _repoUsuarios.ObtenerPorId(id);

            if (existente == null)
                return NotFound("Usuario no encontrado");

            _repoUsuarios.Eliminar(id);

            return Ok("Usuario eliminado correctamente");
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var usuario = _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            if (usuario == null)
                return Unauthorized("Usuario o contraseña incorrectos");

            bool passwordValida = PasswordHelper.VerifyPassword(
                request.Contrasenia,
                usuario.Contrasenia
            );

            if (!passwordValida)
                return Unauthorized("Usuario o contraseña incorrectos");

            if (!usuario.Activo)
                return Unauthorized("Usuario inactivo");

            var response = new LoginResponse
            {
                Id = usuario.Id,
                NombreUsuario = usuario.NombreUsuario,
                RolId = usuario.RolId,
                Activo = usuario.Activo
            };

            return Ok(response);
        }
    }
}