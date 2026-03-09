using System;

namespace RentaCar.Dominio
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public int Anio { get; set; }
        public int Kilometraje { get; set; }

        //foreign keys
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int ColorId { get; set; }
        public int CombustibleId { get; set; }
        public int EstadoId { get; set; }
        public int TipoId { get; set; }

        public Vehiculo(
            string patente,
            int anio,
            int kilometraje,
            int marcaId,
            int modeloId,
            int colorId,
            int combustibleId,
            int estadoId,
            int tipoId)
        {
            Patente = patente;
            Anio = anio;
            Kilometraje = kilometraje;
            MarcaId = marcaId;
            ModeloId = modeloId;
            ColorId = colorId;
            CombustibleId = combustibleId;
            EstadoId = estadoId;
            TipoId = tipoId;
        }
    }
}