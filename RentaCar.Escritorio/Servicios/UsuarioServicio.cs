using System.Net.Http.Json;
using RentaCar.Dtos.Usuarios;

namespace RentaCar.Escritorio.Servicios
{
    public class UsuarioServicio
    {
        private readonly HttpClient _http;

        public UsuarioServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }
        public async Task<List<UsuarioResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("usuarios");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener usuarios: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<UsuarioResponse>>()
                   ?? new List<UsuarioResponse>();
        }
        public async Task<UsuarioResponse?> ObtenerPorId(int id)
        {
            var response = await _http.GetAsync($"usuarios/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener usuario: {error}");
            }

            return await response.Content.ReadFromJsonAsync<UsuarioResponse>();
        }

        public async Task Agregar(UsuarioCreateRequest usuario)
        {
            var response = await _http.PostAsJsonAsync("usuarios", usuario);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al crear usuario: {error}");
            }
        }
        public async Task Actualizar(int id, UsuarioUpdateRequest usuario)
        {
            var response = await _http.PutAsJsonAsync($"usuarios/{id}", usuario);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar usuario: {error}");
            }
        }
        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"usuarios/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar usuario: {error}");
            }
        }

        public async Task<LoginResponse?> Login(LoginRequest request)
        {
            var response = await _http.PostAsJsonAsync("usuarios/login", request);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return null;

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error en login: {error}");
            }

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }
    }
}