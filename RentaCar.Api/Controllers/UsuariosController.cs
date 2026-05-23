using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RentaCar.Dominio;
using RentaCar.Dtos.Usuarios;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Repositorios;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RentaCar.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioRepositorio _repoUsuarios;
        private readonly IConfiguration _config;

        public UsuariosController(UsuarioRepositorio repoUsuarios, IConfiguration config)
        {
            _repoUsuarios = repoUsuarios;
            _config = config;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null)
                return BadRequest("Datos inválidos");

            var usuario = _repoUsuarios.ObtenerPorNombreUsuario(request.NombreUsuario);

            if (usuario == null)
                return Unauthorized("Usuario o contraseña incorrectos");

            bool passwordValida = PasswordHelper.VerifyPassword(request.Contrasenia, usuario.Contrasenia);

            if (!passwordValida)
                return Unauthorized("Usuario o contraseña incorrectos");

            if (!usuario.Activo)
                return Unauthorized("Usuario inactivo");

            var claims = new[]
            {
                new Claim(ClaimTypes.Name, usuario.NombreUsuario),
                new Claim("Id", usuario.Id.ToString()),
                new Claim(ClaimTypes.Role, usuario.RolId.ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "RentaCar",
                audience: "RentaCar",
                claims: claims,
                expires: DateTime.Now.AddHours(2),
                signingCredentials: creds
            );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            var response = new LoginResponse
            {
                Id = usuario.Id,
                NombreUsuario = usuario.NombreUsuario,
                RolId = usuario.RolId,
                Token = tokenString,
                Activo = usuario.Activo
            };

            return Ok(response);
        }
    }
}