namespace RentaCar.Dtos.Tarifas
{
    public class TarifaCreateRequest
    {
        public decimal PrecioDia { get; set; }
        public decimal PrecioSemana { get; set; }
        public bool Activa { get; set; }

        public int TipoVehiculoId { get; set; }
    }
}