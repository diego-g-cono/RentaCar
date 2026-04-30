using RentaCar.Dominio;
using System.Net.Http.Json;

namespace RentaCar.Escritorio.Servicios
{
    public class VehiculoServicio
    {
        private readonly HttpClient _http;

        public VehiculoServicio()
        {
            _http = Conexion.Instancia.Cliente;
        }

        public async Task<List<Vehiculo>> ObtenerTodos()
        {
            return await _http.GetFromJsonAsync<List<Vehiculo>>("vehiculos")
                   ?? new List<Vehiculo>();
        }

        public async Task Agregar(Vehiculo vehiculo)
        {
            await _http.PostAsJsonAsync("vehiculos", vehiculo);
        }

        public async Task Actualizar(Vehiculo vehiculo)
        {
            await _http.PutAsJsonAsync($"vehiculos/{vehiculo.Patente}", vehiculo);
        }

        public async Task Eliminar(string patente)
        {
            await _http.DeleteAsync($"vehiculos/{patente}");
        }
    }
}
