using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ColorV
    {
        private int _id_color;
        private string _nombre;

        public ColorV(string nombre)
        {
            _nombre = nombre;
        }
        public int id_color
        {
            get { return _id_color; }
            set { _id_color = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
