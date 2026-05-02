using RentaCar.Dtos.Combustible;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class CombustibleServicio
    {
        private readonly HttpClient _http;

        public CombustibleServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<CombustibleResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<CombustibleResponse>>("combustibles")
                   ?? new List<CombustibleResponse>();
        }

        public async Task<CombustibleResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<CombustibleResponse>($"combustibles/{id}");
        }

        public async Task Agregar(CombustibleCreateRequest request)
        {
            await _http.PostAsJsonAsync("combustibles", request);
        }

        public async Task Actualizar(int id, CombustibleUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"combustibles/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"combustibles/{id}");
        }
    }
}