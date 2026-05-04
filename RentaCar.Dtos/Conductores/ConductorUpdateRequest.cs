namespace RentaCar.Dtos.Conductores
{
    public class ConductorUpdateRequest
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;

        public DateOnly FechaVencLic { get; set; }
    }
}