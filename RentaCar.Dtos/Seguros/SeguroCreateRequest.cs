namespace RentaCar.Dtos.Seguros
{
    public class SeguroCreateRequest
    {
        public string Nombre { get; set; }
        public decimal Tasa { get; set; }
        public bool Activo { get; set; }
    }
}