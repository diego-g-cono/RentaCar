namespace RentaCar.Dtos.Vehiculos
{
    public class VehiculoUpdateRequest
    {
        public int Anio { get; set; }
        public int Kilometraje { get; set; }

        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int ColorId { get; set; }
        public int CombustibleId { get; set; }
        public int EstadoId { get; set; }
        public int TipoId { get; set; }
    }
}