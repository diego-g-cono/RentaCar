using System.Net.Http.Json;
using RentaCar.Dtos.Roles;

namespace RentaCar.Escritorio.Servicios
{
    public class RolServicio
    {
        private readonly HttpClient _http;

        public RolServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<RolResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("roles");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener roles: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<RolResponse>>()
                   ?? new List<RolResponse>();
        }

        public async Task<RolResponse?> ObtenerPorId(int id)
        {
            var response = await _http.GetAsync($"roles/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener rol: {error}");
            }

            return await response.Content.ReadFromJsonAsync<RolResponse>();
        }

        public async Task Agregar(RolCreateRequest rol)
        {
            var response = await _http.PostAsJsonAsync("roles", rol);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar rol: {error}");
            }
        }

        public async Task Actualizar(int id, RolUpdateRequest rol)
        {
            var response = await _http.PutAsJsonAsync($"roles/{id}", rol);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar rol: {error}");
            }
        }

        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"roles/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar rol: {error}");
            }
        }
    }
}