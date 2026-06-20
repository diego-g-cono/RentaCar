namespace RentaCar.Dtos.Alquileres
{
    public class AlquilerUpdateRequest
    {
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }

        public string VehiculoPatente { get; set; } = null!;
        public int ConductorDni { get; set; }
        public int ClienteDni { get; set; }
        public int EstadoId { get; set; }
        public int? ReservaId { get; set; }
        public int SeguroId { get; set; }
    }
}