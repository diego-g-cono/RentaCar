using RentaCar.Dtos.EstadoVehiculo;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class EstadoVehiculoServicio
    {
        private readonly HttpClient _http;

        public EstadoVehiculoServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<EstadoVehiculoResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<EstadoVehiculoResponse>>("estadosvehiculo")
                   ?? new List<EstadoVehiculoResponse>();
        }

        public async Task<EstadoVehiculoResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<EstadoVehiculoResponse>($"estadosvehiculo/{id}");
        }

        public async Task Agregar(EstadoVehiculoCreateRequest request)
        {
            await _http.PostAsJsonAsync("estadosvehiculo", request);
        }

        public async Task Actualizar(int id, EstadoVehiculoUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"estadosvehiculo/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"estadosvehiculo/{id}");
        }
    }
}