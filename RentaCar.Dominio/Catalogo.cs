using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public abstract class Catalogo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";

        protected Catalogo() { }

        protected Catalogo(string nombre)
        {
            Nombre = nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}