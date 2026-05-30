namespace RentaCar.Dtos.Tarifas
{
    public class TarifaUpdateRequest
    {
        public decimal PrecioDia { get; set; }
        public decimal PrecioSemana { get; set; }
        public bool Activo { get; set; }

        public int TipoVehiculoId { get; set; }
    }
}