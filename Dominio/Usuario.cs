using System;

namespace RentaCar.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NombreUsuario { get; set; }

        private string _contrasenia;
        public string Contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = PasswordHelper.HashPassword(value); }
        }

        public string Rol { get; set; }

        public bool Activo { get; set; }

        public Usuario(string nombreUsuario, string contrasenia, string rol, bool activo)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Rol = rol;
            Activo = activo;
        }
    }
}