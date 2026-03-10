using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Dominio
{
    public class Administrador : Persona
    {
        public int UsuarioId { get; set; }
        public Administrador(string nombre, string apellido, int dni, int usuarioId) : base(dni, nombre, apellido)
        {
            UsuarioId = usuarioId;
        }
    }
}
