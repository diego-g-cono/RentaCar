using RentaCar.Dominio;
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

        public async Task<List<Marca>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<Marca>>("marcas")
                   ?? new List<Marca>();
        }

        public async Task<Marca?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<Marca>($"marcas/{id}");
        }

        public async Task Agregar(Marca marca)
        {
            await _http.PostAsJsonAsync("marcas", marca);
        }

        public async Task Actualizar(Marca marca)
        {
            await _http.PutAsJsonAsync($"marcas/{marca.Id}", marca);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"marcas/{id}");
        }
    }
}