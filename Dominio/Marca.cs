using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        private int _id_marca;
        private string _nombre;

        public Marca(string nombre)
        {
            _nombre = nombre;
        }
        public int id_marca
        {
            get { return _id_marca; }
            set { _id_marca = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
