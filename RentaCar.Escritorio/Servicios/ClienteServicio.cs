using System.Net.Http.Json;
using RentaCar.Dominio;

namespace RentaCar.Escritorio.Servicios
{
    public class ClienteServicio
    {
        private readonly HttpClient _http;

        public ClienteServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<Cliente>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<Cliente>>("clientes")
                   ?? new List<Cliente>();
        }

        public async Task Agregar(Cliente cliente)
        {
            await _http.PostAsJsonAsync("clientes", cliente);
        }

        public async Task Actualizar(Cliente cliente)
        {
            await _http.PutAsJsonAsync($"clientes/{cliente.Dni}", cliente);
        }

        public async Task Eliminar(int dni)
        {
            await _http.DeleteAsync($"clientes/{dni}");
        }
    }
}