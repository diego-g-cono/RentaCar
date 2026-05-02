using RentaCar.Dtos.Common;

namespace RentaCar.Dtos.Modelos

{
    public class ModeloResponse : CatalogoResponse
    {
        public int MarcaId { get; set; }
        public string? MarcaNombre { get; set; }
    }
}