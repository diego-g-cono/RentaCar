using RentaCar.Dtos.EstadoAlquiler;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class EstadoAlquilerServicio
    {
        private readonly HttpClient _http;

        public EstadoAlquilerServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<EstadoAlquilerResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<EstadoAlquilerResponse>>("estadosalquiler")
                   ?? new List<EstadoAlquilerResponse>();
        }

        public async Task<EstadoAlquilerResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<EstadoAlquilerResponse>($"estadosalquiler/{id}");
        }

        public async Task Agregar(EstadoAlquilerCreateRequest request)
        {
            await _http.PostAsJsonAsync("estadosalquiler", request);
        }

        public async Task Actualizar(int id, EstadoAlquilerUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"estadosalquiler/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"estadosalquiler/{id}");
        }
    }
}