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
    public class CombustibleRepositorio
    {
        private readonly RentaCarDBContext _context;

        public CombustibleRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los combustibles
        public List<Combustible> ObtenerTodos()
        {
            return _context.Combustibles.ToList();
        }

        // Obtener combustible por ID
        public Combustible? ObtenerPorId(int id)
        {
            return _context.Combustibles
                .FirstOrDefault(c => c.Id == id);
        }

        // Agregar combustible
        public void Agregar(Combustible combustible)
        {
            _context.Combustibles.Add(combustible);
            _context.SaveChanges();
        }

        // Actualizar combustible
        public void Actualizar(Combustible combustible)
        {
            _context.Combustibles.Update(combustible);
            _context.SaveChanges();
        }

        // Eliminar combustible
        public void Eliminar(int id)
        {
            var combustible = _context.Combustibles
                .FirstOrDefault(c => c.Id == id);

            if (combustible != null)
            {
                _context.Combustibles.Remove(combustible);
                _context.SaveChanges();
            }
        }
    }
}