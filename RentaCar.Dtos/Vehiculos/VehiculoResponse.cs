namespace RentaCar.Dtos.Vehiculos
{
    public class VehiculoResponse
    {
        public string Patente { get; set; } = null!;
        public int Anio { get; set; }
        public int Kilometraje { get; set; }

        public int MarcaId { get; set; }
        public string? MarcaNombre { get; set; }

        public int ModeloId { get; set; }
        public string? ModeloNombre { get; set; }

        public int ColorId { get; set; }
        public string? ColorNombre { get; set; }

        public int CombustibleId { get; set; }
        public string? CombustibleNombre { get; set; }

        public int EstadoId { get; set; }
        public string? EstadoNombre { get; set; }

        public int TipoId { get; set; }
        public string? TipoNombre { get; set; }
        public string? ImagenUrl { get; set; }
    }
}