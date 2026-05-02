using RentaCar.Dtos.Tipo;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class TipoServicio
    {
        private readonly HttpClient _http;

        public TipoServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<TipoResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<TipoResponse>>("tiposvehiculo")
                   ?? new List<TipoResponse>();
        }

        public async Task<TipoResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<TipoResponse>($"tiposvehiculo/{id}");
        }

        public async Task Agregar(TipoCreateRequest request)
        {
            await _http.PostAsJsonAsync("tiposvehiculo", request);
        }

        public async Task Actualizar(int id, TipoUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"tiposvehiculo/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"tiposvehiculo/{id}");
        }
    }
}