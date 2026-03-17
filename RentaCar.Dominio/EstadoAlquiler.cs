using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public class EstadoAlquiler : Catalogo
    {

        public EstadoAlquiler(string descripcion) : base(descripcion)
        {
        }
        public EstadoAlquiler()
        {
        }
    }
}
