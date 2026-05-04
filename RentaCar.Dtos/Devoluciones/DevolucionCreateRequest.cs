namespace RentaCar.Dtos.Devoluciones
{
    public class DevolucionCreateRequest
    {
        public DateOnly Fecha { get; set; }

        public int AlquilerId { get; set; }

        public bool TanqueLleno { get; set; }

        public string? Observaciones { get; set; }
    }
}