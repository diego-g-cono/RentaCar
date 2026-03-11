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
    public class SeguroRepositorio
    {
        private readonly RentaCarDBContext _context;

        public SeguroRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los seguros
        public List<Seguro> ObtenerTodos()
        {
            return _context.Seguros.ToList();
        }

        // Obtener seguro por ID
        public Seguro? ObtenerPorId(int id)
        {
            return _context.Seguros
                .FirstOrDefault(s => s.Id == id);
        }

        // Agregar seguro
        public void Agregar(Seguro seguro)
        {
            _context.Seguros.Add(seguro);
            _context.SaveChanges();
        }

        // Actualizar seguro
        public void Actualizar(Seguro seguro)
        {
            _context.Seguros.Update(seguro);
            _context.SaveChanges();
        }

        // Eliminar seguro
        public void Eliminar(int id)
        {
            var seguro = _context.Seguros
                .FirstOrDefault(s => s.Id == id);

            if (seguro != null)
            {
                _context.Seguros.Remove(seguro);
                _context.SaveChanges();
            }
        }
    }
}