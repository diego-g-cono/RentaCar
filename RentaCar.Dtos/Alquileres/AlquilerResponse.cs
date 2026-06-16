namespace RentaCar.Dtos.Alquileres
{
    public class AlquilerResponse
    {
        public int Id { get; set; }

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }

        public string VehiculoPatente { get; set; } = null!;

        public int ConductorDni { get; set; }
        public string? ConductorNombre { get; set; }

        public int ClienteDni { get; set; }
        public string? ClienteNombre { get; set; }

        public int EstadoId { get; set; }
        public string? EstadoNombre { get; set; }

        public int? ReservaId { get; set; }
        public bool Activo { get; set; }
    }
}