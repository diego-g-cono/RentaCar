using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Infraestructura.Data
{
    public class ReservaRepositorio
    {
        private readonly RentaCarDBContext _context;

        public ReservaRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todas las reservas
        public List<Reserva> ObtenerTodos()
        {
            return _context.Reservas
                .Include(r => r.Cliente)
                .Include(r => r.Vehiculo)
                .Include(r => r.Estado)
                .ToList();
        }

        // Obtener reserva por ID
        public Reserva? ObtenerPorId(int id)
        {
            return _context.Reservas
                .FirstOrDefault(r => r.Id == id);
        }

        // Agregar reserva
        public void Agregar(Reserva reserva)
        {
            _context.Reservas.Add(reserva);
            _context.SaveChanges();
        }

        // Actualizar reserva
        public void Actualizar(Reserva reserva)
        {
            _context.Reservas.Update(reserva);
            _context.SaveChanges();
        }

        // Eliminar reserva
        public void Eliminar(int id)
        {
            var reserva = _context.Reservas
                .FirstOrDefault(r => r.Id == id);

            if (reserva != null)
            {
                _context.Reservas.Remove(reserva);
                _context.SaveChanges();
            }
        }
    }
}