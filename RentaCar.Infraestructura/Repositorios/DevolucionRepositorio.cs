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
    public class DevolucionRepositorio
    {
        private readonly RentaCarDBContext _context;

        public DevolucionRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todas las devoluciones
        public List<Devolucion> ObtenerTodos()
        {
            return _context.Devoluciones.ToList();
        }

        // Obtener devolución por ID
        public Devolucion? ObtenerPorId(int id)
        {
            return _context.Devoluciones
                .FirstOrDefault(d => d.Id == id);
        }

        // Agregar devolución
        public void Agregar(Devolucion devolucion)
        {
            _context.Devoluciones.Add(devolucion);
            _context.SaveChanges();
        }

        // Actualizar devolución
        public void Actualizar(Devolucion devolucion)
        {
            _context.Devoluciones.Update(devolucion);
            _context.SaveChanges();
        }

        // Eliminar devolución
        public void Eliminar(int id)
        {
            var devolucion = _context.Devoluciones
                .FirstOrDefault(d => d.Id == id);

            if (devolucion != null)
            {
                _context.Devoluciones.Remove(devolucion);
                _context.SaveChanges();
            }
        }
    }
}