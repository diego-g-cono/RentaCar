using RentaCar.Dtos.Usuarios;
using System.Net.Http.Json;

namespace RentaCar.Blazor.Services
{
    public class AuthService
    {
        private readonly IHttpClientFactory _httpFactory;

        public string? Token { get; private set; }
        public string? NombreUsuario { get; private set; }
        public bool EstaLogueado => !string.IsNullOrEmpty(Token);

        public int UsuarioId { get; private set; }   
        public int ClienteDni { get; private set; }
        public string? ClienteNombre { get; private set; }
        public string? ClienteApellido { get; private set; }

        public AuthService(IHttpClientFactory httpFactory)
        {
            _httpFactory = httpFactory;
        }

        public async Task<bool> Login(string usuario, string password)
        {
            var client = _httpFactory.CreateClient("Api");

            var request = new LoginRequest
            {
                NombreUsuario = usuario,
                Contrasenia = password
            };

            var response = await client.PostAsJsonAsync("usuarios/login", request);

            if (!response.IsSuccessStatusCode)
                return false;

            var data = await response.Content.ReadFromJsonAsync<LoginResponse>();

            Token = data!.Token;
            NombreUsuario = data.NombreUsuario;
            UsuarioId = data.Id;                    

            ClienteDni = data.ClienteDni;
            ClienteNombre = data.ClienteNombre;
            ClienteApellido = data.ClienteApellido;

            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", Token);

            return true;
        }

        public void Logout()
        {
            Token = null;
            NombreUsuario = null;
            UsuarioId = 0;                           
            ClienteDni = 0;
            ClienteNombre = null;
            ClienteApellido = null;
        }
    }
}