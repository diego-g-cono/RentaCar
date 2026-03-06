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

        public Conductor(int dni, string nombre, string apellido, DateOnly fecha_venc_lic)
            : base(dni, nombre, apellido)
        {
            FechaVencLic = fecha_venc_lic;
        }
    }
}
