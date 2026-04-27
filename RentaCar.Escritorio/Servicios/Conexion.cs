using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RentaCar.Escritorio
{
    public sealed class Conexion
    {
        private static readonly Lazy<Conexion> _instancia = new Lazy<Conexion>(() => new Conexion());

        public HttpClient Cliente { get; }

        private Conexion()
        {
            Cliente = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7272/api/")
            };

            Cliente.DefaultRequestHeaders.Accept.Clear();
            Cliente.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static Conexion Instancia => _instancia.Value;
    }
}