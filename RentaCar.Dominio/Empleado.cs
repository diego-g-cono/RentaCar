using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    internal class Empleado : Persona
    {
        public string Puesto { get; set; }
        public int? UsuarioId { get; set; }

        public Empleado(int dni, string nombre, string apellido, string puesto, int? usuarioId)
            : base(dni, nombre, apellido)
        {
            Puesto = puesto;
            UsuarioId = usuarioId;
        }
    }
}
