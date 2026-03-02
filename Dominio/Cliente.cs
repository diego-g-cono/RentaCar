using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace Dominio
{
    public class Cliente : Persona
    {
        [EmailAddress]
        public string Email { get; set; }

        // Foreign key
        public int Usuario_id { get; set; }

        public Cliente(int dni, string nombre, string apellido, string email, int usuario_id)
            : base(dni, nombre, apellido)
        {
            Email = email;
            Usuario_id = usuario_id;
        }
    }
}