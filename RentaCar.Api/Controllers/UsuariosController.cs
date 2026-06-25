using Microsoft.AspNetCore.Mvc;
using RentaCar.API.Services;
using RentaCar.Dominio;
using RentaCar.Dtos.Usuarios;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepositorio _repoUsuarios;
        private readonly ClienteRepositorio _repoClientes;
        private readonly JwtService _jwtService;

        public UsuariosController(
            UsuarioRepositorio repoUsuarios,
            JwtService jwtService,
            ClienteRepositorio repoClientes)
        {
            _repoUsuarios = repoUsuarios;
            _jwtService = jwtService;
            _repoClientes = repoClientes;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var usuario = _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            if (usuario == null)
                return Unauthorized("Usuario inválido");

            if (!usuario.Activo)
                return Unauthorized("Usuario desactivado");

            bool passwordOk = BCrypt.Net.BCrypt.Verify(
                request.Contrasenia,
                usuario.Contrasenia);

            if (!passwordOk)
                return Unauthorized("Contraseña inválida");

            var cliente = _repoClientes.ObtenerPorUsuarioId(usuario.Id);
            

            var token = _jwtService.GenerarToken(usuario);

            var response = new LoginResponse
            {
                Id = usuario.Id,
                NombreUsuario = usuario.NombreUsuario,
                RolId = usuario.RolId,
                Token = token,
                Activo = usuario.Activo,

                ClienteDni = cliente?.Dni ?? 0,
                ClienteNombre = cliente?.Nombre ?? "",
                ClienteApellido = cliente?.Apellido ?? "",
            };

            return Ok(response);
        }
        [HttpPost("registrar")]
        public IActionResult Registrar([FromBody] RegistroClienteRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            if (_repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario) != null)
                return BadRequest("El nombre de usuario ya existe");

            if (_repoClientes.ObtenerPorDni(request.Dni) != null)
                return BadRequest("Ya existe un cliente con ese DNI");

            var usuario = new Usuario
            {
                NombreUsuario = request.NombreUsuario,
                Contrasenia = request.Contrasenia,
                RolId = 3, // Cliente
                Activo = true
            };

            _repoUsuarios.Agregar(usuario);

            usuario = _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            var cliente = new Cliente
            {
                Dni = request.Dni,
                Nombre = request.Nombre,
                Apellido = request.Apellido,
                Email = request.Email,
                Telefono = request.Telefono,
                UsuarioId = usuario!.Id
            };

            _repoClientes.Agregar(cliente);

            return Ok("Cliente registrado correctamente");
        }
        [HttpGet("existe/{nombreUsuario}")]
        public IActionResult ExisteUsuario(string nombreUsuario)
        {
            var usuario = _repoUsuarios.ObtenerPorNombreUsuario(nombreUsuario);

            return Ok(usuario != null);
        }

        [HttpGet]
        public IActionResult ObtenerTodos()
        {
            var usuarios = _repoUsuarios.ObtenerTodos();

            var response = usuarios.Select(u => new UsuarioResponse
            {
                Id = u.Id,
                NombreUsuario = u.NombreUsuario,
                RolId = u.RolId
            }).ToList();

            return Ok(response);
        }
        [HttpDelete("{id}")]
        public IActionResult Eliminar(int id)
        {
            var usuario = _repoUsuarios.ObtenerPorId(id);

            if (usuario == null)
                return NotFound("Usuario no encontrado");

            _repoUsuarios.Eliminar(id);

            return Ok("Usuario desactivado correctamente");
        }
        [HttpPost]
        public IActionResult Crear([FromBody] UsuarioCreateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");
            
            //if (_repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario) != null)
            //    return BadRequest("El nombre de usuario ya existe");

            var usuarioExistente = _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            if(usuarioExistente != null)
            {
                if(usuarioExistente.Activo)
                    return BadRequest("El nombre de usuario ya existe");

                usuarioExistente.NombreUsuario = request.NombreUsuario;
                usuarioExistente.Contrasenia = request.Contrasenia;
                usuarioExistente.RolId = request.RolId == 0 ? 3 : request.RolId;
                usuarioExistente.Activo = request.Activo;

                _repoUsuarios.Actualizar(usuarioExistente);
                return Ok();
            }

            var usuario = new Usuario
            {
                NombreUsuario = request.NombreUsuario,
                Contrasenia = request.Contrasenia, // se hashea automáticamente
                RolId = request.RolId == 0 ? 3 : request.RolId,
                Activo = true
            };

            _repoUsuarios.Agregar(usuario);

            return Ok("Usuario creado correctamente");
        }
        [HttpPut("{id}")]
        public IActionResult Actualizar(int id, [FromBody] UsuarioUpdateRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var usuario = _repoUsuarios.ObtenerPorId(id);

            if (usuario == null)
                return NotFound("Usuario no encontrado");

            // Verificar que no exista otro usuario con el mismo nombre
            var usuarioExistente =
                _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            if (usuarioExistente != null && usuarioExistente.Id != id)
                return BadRequest("El nombre de usuario ya existe");

            usuario.NombreUsuario = request.NombreUsuario;
            usuario.RolId = request.RolId;

            // Solo cambiar la contraseña si se ingresó una nueva
            if (!string.IsNullOrWhiteSpace(request.Contrasenia))
            {
                usuario.Contrasenia = request.Contrasenia;
                // La propiedad Contrasenia se encarga de hashearla automáticamente
            }

            _repoUsuarios.Actualizar(usuario);

            return Ok("Usuario actualizado correctamente");
        }
    }
}