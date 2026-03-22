using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace RentaCar.Dominio
{
    public class Cliente : Persona
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Telefono { get; set; }

        // Foreign key
        public int? UsuarioId { get; set; }
        public Cliente() { }
        public Cliente(int dni, string nombre, string apellido, string email, int? usuarioId, string telefono)
            : base(dni, nombre, apellido)
        {
            Email = email;
            UsuarioId = usuarioId;
            Telefono = telefono;
        }
    }
}