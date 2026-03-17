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
    public class ColorRepositorio
    {
        private readonly RentaCarDBContext _context;

        public ColorRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los colores
        public List<Color> ObtenerTodos()
        {
            return _context.Colores.ToList();
        }

        // Obtener color por ID
        public Color? ObtenerPorId(int id)
        {
            return _context.Colores
                .FirstOrDefault(c => c.Id == id);
        }

        // Agregar color
        public void Agregar(Color color)
        {
            _context.Colores.Add(color);
            _context.SaveChanges();
        }

        // Actualizar color
        public void Actualizar(Color color)
        {
            _context.Colores.Update(color);
            _context.SaveChanges();
        }

        // Eliminar color
        public void Eliminar(int id)
        {
            var color = _context.Colores
                .FirstOrDefault(c => c.Id == id);

            if (color != null)
            {
                _context.Colores.Remove(color);
                _context.SaveChanges();
            }
        }
    }
}