using System;

namespace Dominio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string MarcaId { get; set; }
        public string ModeloId { get; set; }
        public int? Anio { get; set; }
        public string? ColorId { get; set; }
        public string? TipoCombustible { get; set; }
        public int? Kilometraje { get; set; }
        public string EstadoVehiculoId { get; set; }

        public Vehiculo(string patente, string estado, string marca, string modelo, int? anio = null, string? color = null, string? tipo_combustible = null, int? kilometraje = null)
        {
            Patente = patente;
            EstadoVehiculoId = estado;
            MarcaId = marca;
            ModeloId = modelo;
            Anio = anio;
            ColorId = color;
            TipoCombustible = tipo_combustible;
            Kilometraje = kilometraje;
        }
    }
}