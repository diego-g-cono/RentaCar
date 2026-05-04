using System.Net.Http.Json;
using RentaCar.Dtos.Devoluciones;

namespace RentaCar.Escritorio.Servicios
{
    public class DevolucionServicio
    {
        private readonly HttpClient _http;

        public DevolucionServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }
        public async Task<List<DevolucionResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("devoluciones");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener devoluciones: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<DevolucionResponse>>()
                   ?? new List<DevolucionResponse>();
        }

        public async Task<DevolucionResponse?> ObtenerPorId(int id)
        {
            var response = await _http.GetAsync($"devoluciones/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener devolución: {error}");
            }

            return await response.Content.ReadFromJsonAsync<DevolucionResponse>();
        }

        public async Task Agregar(DevolucionCreateRequest devolucion)
        {
            var response = await _http.PostAsJsonAsync("devoluciones", devolucion);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar devolución: {error}");
            }
        }
        public async Task Actualizar(int id, DevolucionUpdateRequest devolucion)
        {
            var response = await _http.PutAsJsonAsync($"devoluciones/{id}", devolucion);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar devolución: {error}");
            }
        }

        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"devoluciones/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar devolución: {error}");
            }
        }
    }
}