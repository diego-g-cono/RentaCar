namespace RentaCar.Dtos.Tarifas
{
    public class TarifaResponse
    {
        public int Id { get; set; }

        public decimal PrecioDia { get; set; }
        public decimal PrecioSemana { get; set; }
        public bool Activa { get; set; }

        public int TipoVehiculoId { get; set; }
        public string? TipoVehiculoNombre { get; set; }
    }
}