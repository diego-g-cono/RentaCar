namespace RentaCar.Dtos.Modelos
{
    public class ModeloUpdateRequest
    {
        public string Nombre { get; set; } = null!;
        public int MarcaId { get; set; }
    }
}