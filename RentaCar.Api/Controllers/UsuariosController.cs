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
            Console.WriteLine(usuario.NombreUsuario);

            if (usuario == null)
                return Unauthorized("Usuario inválido");

            bool passwordOk = BCrypt.Net.BCrypt.Verify(
                request.Contrasenia,
                usuario.Contrasenia);

            if (!passwordOk)
                return Unauthorized("Contraseña inválida");
            Console.WriteLine(usuario.Id);

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
    }
}