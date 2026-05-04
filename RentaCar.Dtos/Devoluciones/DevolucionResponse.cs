namespace RentaCar.Dtos.Devoluciones
{
    public class DevolucionResponse
    {
        public int Id { get; set; }

        public DateOnly Fecha { get; set; }

        public int AlquilerId { get; set; }

        public string? VehiculoPatente { get; set; }
        public int? ClienteDni { get; set; }

        public bool TanqueLleno { get; set; }

        public string? Observaciones { get; set; }
    }
}