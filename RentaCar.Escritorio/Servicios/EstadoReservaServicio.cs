using RentaCar.Dtos.EstadoReserva;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class EstadoReservaServicio
    {
        private readonly HttpClient _http;

        public EstadoReservaServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<EstadoReservaResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<EstadoReservaResponse>>("estadosreserva")
                   ?? new List<EstadoReservaResponse>();
        }

        public async Task<EstadoReservaResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<EstadoReservaResponse>($"estadosreserva/{id}");
        }

        public async Task Agregar(EstadoReservaCreateRequest request)
        {
            await _http.PostAsJsonAsync("estadosreserva", request);
        }

        public async Task Actualizar(int id, EstadoReservaUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"estadosreserva/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"estadosreserva/{id}");
        }
    }
}