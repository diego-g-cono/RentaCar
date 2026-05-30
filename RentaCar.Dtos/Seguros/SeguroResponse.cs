namespace RentaCar.Dtos.Seguros
{ 
    public class SeguroResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public decimal Tasa { get; set; }
    }
}