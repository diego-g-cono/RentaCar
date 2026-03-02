using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Combustible
    {
        private int _id;
        private string _nombre;
        public Combustible(string nombre)
        {
            _nombre = nombre;
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
    }
}
