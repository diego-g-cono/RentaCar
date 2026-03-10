using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public class Seguro : Catalogo
    {
        public decimal Tasa { get; set; }
        public Seguro(string nombre, decimal tasa) : base(nombre)
        {
            Tasa = tasa;
        }
    }
}
