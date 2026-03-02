using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Empleado : Persona
    {
        private string _puesto;
        private int _usuario_id;

        public Empleado(int dni, string nombre, string apellido, string puesto, int usuario_id)
            : base(dni, nombre, apellido)
        {
            _puesto = puesto;
            _usuario_id = usuario_id;
        }
        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }
        public int usuario_id
        {
            get { return _usuario_id; }
            set { _usuario_id = value; }
        }
    }
}
