using RentaCar.Dtos.Marcas;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class MarcaServicio
    {
        private readonly HttpClient _http;

        public MarcaServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<MarcaResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<MarcaResponse>>("marcas")
                   ?? new List<MarcaResponse>();
        }

        public async Task<MarcaResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<MarcaResponse>($"marcas/{id}");
        }

        public async Task Agregar(MarcaCreateRequest request)
        {
            await _http.PostAsJsonAsync("marcas", request);
        }

        public async Task Actualizar(int id, MarcaUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"marcas/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"marcas/{id}");
        }
    }
}