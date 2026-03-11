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
    public class EstadoReservaRepositorio
    {
        private readonly RentaCarDBContext _context;

        public EstadoReservaRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los estados de reserva
        public List<EstadoReserva> ObtenerTodos()
        {
            return _context.EstadosReservas.ToList();
        }

        // Obtener estado por ID
        public EstadoReserva? ObtenerPorId(int id)
        {
            return _context.EstadosReservas
                .FirstOrDefault(e => e.Id == id);
        }

        // Agregar estado
        public void Agregar(EstadoReserva estado)
        {
            _context.EstadosReservas.Add(estado);
            _context.SaveChanges();
        }

        // Actualizar estado
        public void Actualizar(EstadoReserva estado)
        {
            _context.EstadosReservas.Update(estado);
            _context.SaveChanges();
        }

        // Eliminar estado
        public void Eliminar(int id)
        {
            var estado = _context.EstadosReservas
                .FirstOrDefault(e => e.Id == id);

            if (estado != null)
            {
                _context.EstadosReservas.Remove(estado);
                _context.SaveChanges();
            }
        }
    }
}