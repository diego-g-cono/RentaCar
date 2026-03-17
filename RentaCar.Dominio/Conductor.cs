using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public class Conductor : Persona
    {
        public DateOnly FechaVencLic { get; set; }
        public Conductor(int dni, string nombre, string apellido, DateOnly fechaVencLic)
            : base(dni, nombre, apellido)
        {
            FechaVencLic = fechaVencLic;
        }
    }
}
