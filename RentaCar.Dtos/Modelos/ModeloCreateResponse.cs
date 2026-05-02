namespace RentaCar.Dtos.Modelos
{
    public class ModeloCreateRequest
    {
        public string Nombre { get; set; } = null!;
        public int MarcaId { get; set; }
    }
}