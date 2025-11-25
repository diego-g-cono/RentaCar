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
        private string? _contraseñaHash;
        private string? _email;
        public string? Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string? ContraseñaHash
        {
            get { return _contraseñaHash; }
            private set { _contraseñaHash = value; }
        }

        [EmailAddress]
        public string? Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Cliente(int dni) : base(dni)
        {
            // Constructor sin parámetros para EF Core
        }
        public Cliente(int dni, string? nombre = null, string? apellido = null, string? direccion = null, DateOnly? fechaNacimiento=null,
                        string? usuario = null, string? contraseña = null, string? email = null)
            : base(dni, nombre, apellido, direccion, fechaNacimiento)
        {
            _usuario = usuario;
            _contraseñaHash = BCrypt.Net.BCrypt.HashPassword(contraseña); ;
            _email = email;
        }
        public bool VerificarContraseña(string contraseña)
        {
            return BCrypt.Net.BCrypt.Verify(contraseña, ContraseñaHash);
        }
    }
}
