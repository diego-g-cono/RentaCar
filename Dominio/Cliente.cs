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
    public class Cliente:Persona
    {
        private string? _usuario;
        private string? _contrasenia_hash;
        private string? _email;
        public string? usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string? contrasenia_hash
        {
            get { return _contrasenia_hash; }
            private set { _contrasenia_hash = value; }
        }

        [EmailAddress]
        public string? email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Cliente(int dni) : base(dni)
        {
            // Constructor sin parámetros para EF Core
        }
        public Cliente(int dni, string? nombre = null, string? apellido = null, string? direccion = null, DateOnly? fechaNacimiento=null,
                        string? usuario = null, string? contrasenia = null, string? email = null)
            : base(dni, nombre, apellido, direccion, fechaNacimiento)
        {
            _usuario = usuario;
            _contrasenia_hash = BCrypt.Net.BCrypt.HashPassword(contrasenia); ;
            _email = email;
        }
        public bool VerificarContraseña(string contraseña)
        {
            return BCrypt.Net.BCrypt.Verify(contraseña, contrasenia_hash);
        }
    }
}
