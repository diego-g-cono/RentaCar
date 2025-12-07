using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Estado
    {
        private int _id_estado;
        private string _nombre;
        private string _categoria;
        public Estado(string nombre, string categoria)
        {
            _nombre = nombre;
            _categoria = categoria;
        }
        public int id_estado
        {
            get { return id_estado; }
            set { id_estado = value; }
        }
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }
    }
}
