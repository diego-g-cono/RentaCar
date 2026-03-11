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
    public class AdministradorRepositorio
    {
        private readonly RentaCarDBContext _context;

        public AdministradorRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los administradores
        public List<Administrador> ObtenerTodos()
        {
            return _context.Administradores.ToList();
        }

        // Obtener administrador por DNI
        public Administrador? ObtenerPorDni(int dni)
        {
            return _context.Administradores
                .FirstOrDefault(a => a.Dni == dni);
        }

        // Agregar administrador
        public void Agregar(Administrador administrador)
        {
            _context.Administradores.Add(administrador);
            _context.SaveChanges();
        }

        // Actualizar administrador
        public void Actualizar(Administrador administrador)
        {
            _context.Administradores.Update(administrador);
            _context.SaveChanges();
        }

        // Eliminar administrador
        public void Eliminar(int dni)
        {
            var administrador = _context.Administradores
                .FirstOrDefault(a => a.Dni == dni);

            if (administrador != null)
            {
                _context.Administradores.Remove(administrador);
                _context.SaveChanges();
            }
        }
    }
}