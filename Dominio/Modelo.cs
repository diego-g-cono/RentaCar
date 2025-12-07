using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Modelo
    {
        private int _id_modelo;
        private string _nombre;
        //Foreign key
        private int _id_marca;

        public Modelo(string nombre, int id_marca)
        {
            _nombre = nombre;
            _id_marca = id_marca;
            _id_marca = id_marca;
        }
        public int id_modelo
        {
            get { return _id_modelo; }
            set { _id_modelo = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int id_marca
        {
            get { return _id_marca; }
            set { _id_marca = value; }
        }
    }
}
