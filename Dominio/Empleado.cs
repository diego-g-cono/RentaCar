using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Empleado : Persona
    {
        public string Puesto { get; set; }
        public int UsuarioId { get; set; }

        public Empleado(int dni, string nombre, string apellido, string puesto, int usuario_id)
            : base(dni, nombre, apellido)
        {
            Puesto = puesto;
            UsuarioId = usuario_id;
        }
    }
}
