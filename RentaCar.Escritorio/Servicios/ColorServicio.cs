using RentaCar.Dtos.Color;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class ColorServicio
    {
        private readonly HttpClient _http;

        public ColorServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<ColorResponse>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<ColorResponse>>("colores")
                   ?? new List<ColorResponse>();
        }

        public async Task<ColorResponse?> ObtenerPorId(int id)
        {
            return await _http.GetFromJsonAsync<ColorResponse>($"colores/{id}");
        }

        public async Task Agregar(ColorCreateRequest request)
        {
            await _http.PostAsJsonAsync("colores", request);
        }

        public async Task Actualizar(int id, ColorUpdateRequest request)
        {
            await _http.PutAsJsonAsync($"colores/{id}", request);
        }

        public async Task Eliminar(int id)
        {
            await _http.DeleteAsync($"colores/{id}");
        }
    }
}