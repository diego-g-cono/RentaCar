using RentaCar.Dtos.Modelos;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class ModeloServicio
    {
        private readonly HttpClient _http;

        public ModeloServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<ModeloResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<ModeloResponse>>("modelos")
                   ?? new List<ModeloResponse>();
        }

        public async Task<ModeloResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<ModeloResponse>($"modelos/{id}");
        }

        public async Task Agregar(ModeloCreateRequest request)
        {
            await _http.PostAsJsonAsync("modelos", request);
        }

        public async Task Actualizar(int id, ModeloUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"modelos/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"modelos/{id}");
        }

        public async Task<List<ModeloResponse>> ObtenerPorMarca(int marcaId)
        {
            return await _http.GetFromJsonAsync<List<ModeloResponse>>($"modelos/marca/{marcaId}")
                   ?? new List<ModeloResponse>();
        }
    }
}