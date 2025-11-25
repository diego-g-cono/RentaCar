using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Conductor:Persona
    {
        private DateOnly _fechaVencLic;
        public DateOnly FechaVencimiento
        {
            get { return _fechaVencLic; }
            set { _fechaVencLic = value; }
        }
        public Conductor(int dni, string nombre, string apellido, string direccion, DateOnly fechaNacimiento,
                         DateOnly fechaVencimiento)
            : base(dni, nombre, apellido, direccion, fechaNacimiento)
        {
            _fechaVencLic = fechaVencimiento;
        }
    }
}
