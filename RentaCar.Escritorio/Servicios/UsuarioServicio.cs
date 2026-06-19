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
            return await _http.GetFromJsonAsync<List<UsuarioResponse>>("usuarios")
                   ?? new List<UsuarioResponse>();
        }

        public async Task<UsuarioResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<UsuarioResponse>($"usuarios/{id}");
        }

        public async Task Agregar(UsuarioCreateRequest request)
        {
            var response = await _http.PostAsJsonAsync("usuarios", request);

            if (!response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task Actualizar(int id, UsuarioUpdateRequest request)
        {
            var response = await _http.PutAsJsonAsync($"usuarios/{id}", request);

            if (!response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"usuarios/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var mensaje = await response.Content.ReadAsStringAsync();
                throw new Exception(mensaje);
            }
        }

        public async Task<LoginResponse?> Login(LoginRequest request)
        {
            var response = await _http.PostAsJsonAsync("usuarios/login", request);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                return null;

            return await response.Content.ReadFromJsonAsync<LoginResponse>();
        }
    }
}