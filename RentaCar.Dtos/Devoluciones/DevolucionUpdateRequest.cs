namespace RentaCar.Dtos.Devoluciones
{
    public class DevolucionUpdateRequest
    {
        public DateOnly Fecha { get; set; }

        public bool TanqueLleno { get; set; }

        public string? Observaciones { get; set; }

        public int AlquilerId { get; set; }
    }
}