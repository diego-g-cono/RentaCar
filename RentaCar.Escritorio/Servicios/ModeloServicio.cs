using RentaCar.Dominio;
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

        public async Task<List<Modelo>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<Modelo>>("modelos")
                   ?? new List<Modelo>();
        }

        public async Task<Modelo?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<Modelo>($"modelos/{id}");
        }

        public async Task Agregar(Modelo modelo)
        {
            await _http.PostAsJsonAsync("modelos", modelo);
        }

        public async Task Actualizar(Modelo modelo)
        {
            await _http.PutAsJsonAsync($"modelos/{modelo.Id}", modelo);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"modelos/{id}");
        }
        public async Task<List<Modelo>> ObtenerPorMarca(int marcaId)
        {
            return await _http.GetFromJsonAsync<List<Modelo>>($"modelos/marca/{marcaId}")
                   ?? new List<Modelo>();
        }
    }
}