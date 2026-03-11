using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Infraestructura
{
    public class UsuarioRepositorio
    {
        private readonly RentaCarDBContext _context;

        public UsuarioRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los usuarios
        public List<Usuario> ObtenerTodos()
        {
            return _context.Usuarios.ToList();
        }

        // Obtener usuario por ID
        public Usuario? ObtenerPorId(int id)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.Id == id);
        }

        // Obtener usuario por nombre de usuario (muy útil para login)
        public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
        {
            return _context.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

        // Agregar usuario
        public void Agregar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        // Actualizar usuario
        public void Actualizar(Usuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        // Eliminar usuario
        public void Eliminar(int id)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
            }
        }
    }
}