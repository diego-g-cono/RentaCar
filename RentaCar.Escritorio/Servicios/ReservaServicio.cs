using RentaCar.Dtos.Reservas;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class ReservaServicio
    {
        private readonly HttpClient _http;

        public ReservaServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<ReservaResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<ReservaResponse>>("reservas")
                   ?? new List<ReservaResponse>();
        }

        public async Task<ReservaResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<ReservaResponse>($"reservas/{id}");
        }

        public async Task Agregar(ReservaCreateRequest request)
        {
            var response = await _http.PostAsJsonAsync("reservas", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }
        }

        public async Task Actualizar(int id, ReservaUpdateRequest request)
        {
            var response = await _http.PutAsJsonAsync($"reservas/{id}", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }
        }

        public async Task Eliminar(int id)
        {
            var response = await _http.DeleteAsync($"reservas/{id}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }
        }
        public async Task<decimal> CalcularPrecio(
    string patente,
    DateOnly inicio,
    DateOnly fin,
    int seguroId)
        {
            string url =
                $"reservas/calcular-precio" +
                $"?patente={patente}" +
                $"&inicio={inicio:yyyy-MM-dd}" +
                $"&fin={fin:yyyy-MM-dd}" +
                $"&seguroId={seguroId}";

            return await _http.GetFromJsonAsync<decimal>(url);
        }
    }
}