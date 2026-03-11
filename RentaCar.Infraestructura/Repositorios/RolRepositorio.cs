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
    public class RolRepositorio
    {
        private readonly RentaCarDBContext _context;

        public RolRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los roles
        public List<Rol> ObtenerTodos()
        {
            return _context.Roles.ToList();
        }

        // Obtener rol por ID
        public Rol? ObtenerPorId(int id)
        {
            return _context.Roles
                .FirstOrDefault(r => r.Id == id);
        }

        // Agregar rol
        public void Agregar(Rol rol)
        {
            _context.Roles.Add(rol);
            _context.SaveChanges();
        }

        // Actualizar rol
        public void Actualizar(Rol rol)
        {
            _context.Roles.Update(rol);
            _context.SaveChanges();
        }

        // Eliminar rol
        public void Eliminar(int id)
        {
            var rol = _context.Roles
                .FirstOrDefault(r => r.Id == id);

            if (rol != null)
            {
                _context.Roles.Remove(rol);
                _context.SaveChanges();
            }
        }
    }
}