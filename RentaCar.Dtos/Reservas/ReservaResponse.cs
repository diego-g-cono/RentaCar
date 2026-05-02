namespace RentaCar.Dtos.Reservas
{
    public class ReservaResponse
    {
        public int Id { get; set; }

        public int ClienteDni { get; set; }
        public string? ClienteNombre { get; set; }

        public string VehiculoPatente { get; set; } = null!;

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

        public decimal Precio { get; set; }
        public decimal Senia { get; set; }

        public int EstadoId { get; set; }
        public string? EstadoNombre { get; set; }
    }
}