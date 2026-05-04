using System.Net.Http.Json;
using RentaCar.Dtos.Alquileres;

namespace RentaCar.Escritorio.Servicios
{
    public class AlquilerServicio
    {
        private readonly HttpClient _http;

        public AlquilerServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }
        public async Task<List<AlquilerResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("alquileres");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener alquileres: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<AlquilerResponse>>()
                   ?? new List<AlquilerResponse>();
        }
        public async Task<AlquilerResponse?> ObtenerPorId(int id)
        {
            var response = await _http.GetAsync($"alquileres/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener alquiler: {error}");
            }

            return await response.Content.ReadFromJsonAsync<AlquilerResponse>();
        }
        public async Task Agregar(AlquilerCreateRequest alquiler)
        {
            var response = await _http.PostAsJsonAsync("alquileres", alquiler);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar alquiler: {error}");
            }
        }
        public async Task Actualizar(int id, AlquilerUpdateRequest alquiler)
        {
            var response = await _http.PutAsJsonAsync($"alquileres/{id}", alquiler);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar alquiler: {error}");
            }
        }
        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"alquileres/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar alquiler: {error}");
            }
        }
    }
}