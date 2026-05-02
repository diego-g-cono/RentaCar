using System.Net.Http.Json;
using RentaCar.Dtos.Clientes;

namespace RentaCar.Escritorio.Servicios
{
    public class ClienteServicio
    {
        private readonly HttpClient _http;

        public ClienteServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<ClienteResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<ClienteResponse>>("clientes")
                   ?? new List<ClienteResponse>();
        }

        public async Task Agregar(ClienteCreateRequest cliente)
        {
            var response = await _http.PostAsJsonAsync("clientes", cliente);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al agregar cliente: {error}");
            }
        }

        public async Task Actualizar(int dni, ClienteUpdateRequest cliente)
        {
            var response = await _http.PutAsJsonAsync($"clientes/{dni}", cliente);

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al actualizar cliente: {error}");
            }
        }

        public async Task Eliminar(int dni)
        {
            var response = await _http.DeleteAsync($"clientes/{dni}");

            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error al eliminar cliente: {error}");
            }
        }
    }
}