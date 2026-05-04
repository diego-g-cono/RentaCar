namespace RentaCar.Dtos.Conductores
{
    public class ConductorCreateRequest
    {
        public int Dni { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;

        public DateOnly FechaVencLic { get; set; }
    }
}