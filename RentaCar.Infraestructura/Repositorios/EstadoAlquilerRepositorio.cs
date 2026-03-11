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
    public class EstadoAlquilerRepositorio
    {
        private readonly RentaCarDBContext _context;

        public EstadoAlquilerRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los estados de alquiler
        public List<EstadoAlquiler> ObtenerTodos()
        {
            return _context.EstadosAlquileres.ToList();
        }

        // Obtener estado por ID
        public EstadoAlquiler? ObtenerPorId(int id)
        {
            return _context.EstadosAlquileres
                .FirstOrDefault(e => e.Id == id);
        }

        // Agregar estado
        public void Agregar(EstadoAlquiler estado)
        {
            _context.EstadosAlquileres.Add(estado);
            _context.SaveChanges();
        }

        // Actualizar estado
        public void Actualizar(EstadoAlquiler estado)
        {
            _context.EstadosAlquileres.Update(estado);
            _context.SaveChanges();
        }

        // Eliminar estado
        public void Eliminar(int id)
        {
            var estado = _context.EstadosAlquileres
                .FirstOrDefault(e => e.Id == id);

            if (estado != null)
            {
                _context.EstadosAlquileres.Remove(estado);
                _context.SaveChanges();
            }
        }
    }
}