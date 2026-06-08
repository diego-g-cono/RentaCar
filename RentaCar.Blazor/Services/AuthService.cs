using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using RentaCar.Dtos.Usuarios;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace RentaCar.Blazor.Services
{
    public class AuthService
    {
        private readonly IHttpClientFactory _httpFactory;
        private readonly ProtectedSessionStorage _sessionStorage;
        public bool Inicializado { get; private set; }
        public string? Token { get; private set; }
        public string? NombreUsuario { get; private set; }

        public int UsuarioId { get; private set; }
        public int ClienteDni { get; private set; }
        public string? ClienteNombre { get; private set; }
        public string? ClienteApellido { get; private set; }

        public bool EstaLogueado => !string.IsNullOrEmpty(Token);
        public int RolId { get; private set; }

        public bool PuedeEditarVehiculos => RolId == 1 || RolId == 2;
        public AuthService(
            IHttpClientFactory httpFactory,
            ProtectedSessionStorage sessionStorage)
        {
            _httpFactory = httpFactory;
            _sessionStorage = sessionStorage;
        }

        public async Task<bool> Login(string usuario, string password)
        {
            var client = _httpFactory.CreateClient("Api");

            var request = new LoginRequest
            {
                NombreUsuario = usuario,
                Contrasenia = password
            };

            var response = await client.PostAsJsonAsync(
                "usuarios/login",
                request);

            if (!response.IsSuccessStatusCode)
                return false;

            var data = await response.Content
                .ReadFromJsonAsync<LoginResponse>();

            Token = data!.Token;
            NombreUsuario = data.NombreUsuario;
            UsuarioId = data.Id;
            RolId = data.RolId;

            ClienteDni = data.ClienteDni;
            ClienteNombre = data.ClienteNombre;
            ClienteApellido = data.ClienteApellido;

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", Token);

            // Guardar sesión
            await _sessionStorage.SetAsync("token", Token);
            await _sessionStorage.SetAsync("nombreUsuario", NombreUsuario);
            await _sessionStorage.SetAsync("usuarioId", UsuarioId);

            await _sessionStorage.SetAsync("clienteDni", ClienteDni);
            await _sessionStorage.SetAsync("clienteNombre", ClienteNombre);
            await _sessionStorage.SetAsync("clienteApellido", ClienteApellido);
            await _sessionStorage.SetAsync("rolId", RolId);

            return true;
        }

        public async Task RestaurarSesion()
        {
            try
            {
                var token = await _sessionStorage.GetAsync<string>("token");

                if (token.Success && !string.IsNullOrWhiteSpace(token.Value))
                {
                    Token = token.Value;

                    NombreUsuario =
                        (await _sessionStorage.GetAsync<string>("nombreUsuario")).Value;

                    UsuarioId =
                        (await _sessionStorage.GetAsync<int>("usuarioId")).Value;

                    ClienteDni =
                        (await _sessionStorage.GetAsync<int>("clienteDni")).Value;

                    ClienteNombre =
                        (await _sessionStorage.GetAsync<string>("clienteNombre")).Value;

                    ClienteApellido =
                        (await _sessionStorage.GetAsync<string>("clienteApellido")).Value;

                    RolId =
                        (await _sessionStorage.GetAsync<int>("rolId")).Value;

                    var client = _httpFactory.CreateClient("Api");

                    client.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", Token);
                }
            }
            finally
            {
                Inicializado = true;
            }
        }

        public async Task Logout()
        {
            await _sessionStorage.DeleteAsync("token");
            await _sessionStorage.DeleteAsync("nombreUsuario");
            await _sessionStorage.DeleteAsync("usuarioId");
            await _sessionStorage.DeleteAsync("clienteDni");
            await _sessionStorage.DeleteAsync("clienteNombre");
            await _sessionStorage.DeleteAsync("clienteApellido");
            await _sessionStorage.DeleteAsync("rolId");

            Token = null;
            NombreUsuario = null;
            UsuarioId = 0;
            ClienteDni = 0;
            ClienteNombre = null;
            ClienteApellido = null;
            RolId = 0;

            Inicializado = true;
        }
    }
}