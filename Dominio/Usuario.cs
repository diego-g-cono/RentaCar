using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        private int _id;
        private string _nombre_usuario;
        private string _contrasenia;
        private string _rol;
        private bool _activo;

        public Usuario(string nombre_usuario, string contrasenia, string rol, bool activo)
        {
            _nombre_usuario = nombre_usuario;
            _contrasenia = PasswordHelper.HashPassword(contrasenia);
            _rol = rol;
            _activo = activo;
        }
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string nombre_usuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }
        public string contrasenia
        {
            get { return _contrasenia; }
            set { _contrasenia = PasswordHelper.HashPassword(value); }
        }
        public string rol
        {
            get { return _rol; }
            set { _rol = value; }
        }
        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
    }
}
