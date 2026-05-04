using System.Net.Http.Json;
using RentaCar.Dtos.Tarifas;

namespace RentaCar.Escritorio.Servicios
{
    public class TarifaServicio
    {
        private readonly HttpClient _http;

        public TarifaServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<TarifaResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("tarifas");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener tarifas: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<TarifaResponse>>()
                   ?? new List<TarifaResponse>();
        }

        public async Task<TarifaResponse?> ObtenerPorId(int id)
        {
            var response = await _http.GetAsync($"tarifas/{id}");

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener tarifa: {error}");
            }

            return await response.Content.ReadFromJsonAsync<TarifaResponse>();
        }

        public async Task Agregar(TarifaCreateRequest tarifa)
        {
            var response = await _http.PostAsJsonAsync("tarifas", tarifa);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar tarifa: {error}");
            }
        }

        public async Task Actualizar(int id, TarifaUpdateRequest tarifa)
        {
            var response = await _http.PutAsJsonAsync($"tarifas/{id}", tarifa);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar tarifa: {error}");
            }
        }

        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"tarifas/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar tarifa: {error}");
            }
        }
    }
}