using System.Net.Http.Json;
using RentaCar.Dtos.Vehiculos;

namespace RentaCar.Escritorio.Servicios
{
    public class VehiculoServicio
    {
        private readonly HttpClient _http;

        public VehiculoServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<VehiculoResponse>> ObtenerTodos()
        {
            var response = await _http.GetAsync("vehiculos");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al obtener vehículos: {error}");
            }

            return await response.Content.ReadFromJsonAsync<List<VehiculoResponse>>()
                   ?? new List<VehiculoResponse>();
        }

        public async Task Agregar(VehiculoCreateRequest vehiculo)
        {
            var response = await _http.PostAsJsonAsync("vehiculos", vehiculo);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar vehículo: {error}");
            }
        }

        public async Task Actualizar(string patente, VehiculoUpdateRequest vehiculo)
        {
            var response = await _http.PutAsJsonAsync($"vehiculos/{patente}", vehiculo);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar vehículo: {error}");
            }
        }

        public async Task Eliminar(string patente)
        {
            var response = await _http.DeleteAsync($"vehiculos/{patente}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar vehículo: {error}");
            }
        }
    }
}