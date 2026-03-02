using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Conductor : Persona
    {
        public DateOnly Fecha_venc_lic { get; set; }

        public Conductor(int dni, string nombre, string apellido, DateOnly fecha_venc_lic)
            : base(dni, nombre, apellido)
        {
            Fecha_venc_lic = fecha_venc_lic;
        }
    }
}
