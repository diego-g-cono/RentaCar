using RentaCar.Dtos.Conductores;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class ConductorServicio
    {
        private readonly HttpClient _http;

        public ConductorServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<ConductorResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<ConductorResponse>>("conductores")
                   ?? new List<ConductorResponse>();
        }

        public async Task<ConductorResponse?> ObtenerPorDni(int dni)
        {
            return await _http.GetFromJsonAsync<ConductorResponse>($"conductores/{dni}");
        }

        public async Task Agregar(ConductorCreateRequest request)
        {
            var response = await _http.PostAsJsonAsync("conductores", request);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }
        }

        public async Task Actualizar(int dni, ConductorUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"conductores/{dni}", request);
        }

        public async Task Eliminar(int dni)
        {
            await _http.DeleteAsync($"conductores/{dni}");
        }
    }
}