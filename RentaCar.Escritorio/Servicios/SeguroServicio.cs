using RentaCar.Dtos.Seguros;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class SeguroServicio
    {
        private readonly HttpClient _http;

        public SeguroServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<SeguroResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<SeguroResponse>>("seguros")
                   ?? new List<SeguroResponse>();
        }

        public async Task<SeguroResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<SeguroResponse>($"seguros/{id}");
        }

        public async Task Agregar(SeguroCreateRequest request)
        {
            await _http.PostAsJsonAsync("seguros", request);
        }

        public async Task Actualizar(int id, SeguroUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"seguros/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"seguros/{id}");
        }
    }
}