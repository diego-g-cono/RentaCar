namespace RentaCar.Dtos.Reservas
{
    public class ReservaUpdateRequest
    {
        public int ClienteDni { get; set; }
        public string VehiculoPatente { get; set; } = null!;

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }

        public decimal Precio { get; set; }
        public decimal Senia { get; set; }

        public int EstadoId { get; set; }
        public int SeguroId { get; set; }
    }
}