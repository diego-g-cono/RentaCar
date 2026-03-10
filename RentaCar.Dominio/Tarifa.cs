using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public class Tarifa
    {
        public int Id { get; set; }
        public decimal PrecioDia { get; set; }
        public decimal PrecioSemana { get; set; }
        public bool Activa { get; set; }
        //foreign keys
        public int TipoVehiculoId { get; set; }

        public Tarifa(int id, decimal precioDia, decimal precioSemana, bool activa, int tipoVehiculoId)
        {
            Id = id;
            PrecioDia = precioDia;
            PrecioSemana = precioSemana;
            Activa = activa;
            TipoVehiculoId = tipoVehiculoId;
        }
    }
}
