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
    public class AlquilerRepositorio
    {
        private readonly RentaCarDBContext _context;

        public AlquilerRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los alquileres
        public List<Alquiler> ObtenerTodos()
        {
            return _context.Alquileres.ToList();
        }

        // Obtener alquiler por ID
        public Alquiler? ObtenerPorId(int id)
        {
            return _context.Alquileres
                .FirstOrDefault(a => a.Id == id);
        }

        // Agregar alquiler
        public void Agregar(Alquiler alquiler)
        {
            _context.Alquileres.Add(alquiler);
            _context.SaveChanges();
        }

        // Actualizar alquiler
        public void Actualizar(Alquiler alquiler)
        {
            _context.Alquileres.Update(alquiler);
            _context.SaveChanges();
        }

        // Eliminar alquiler
        public void Eliminar(int id)
        {
            var alquiler = _context.Alquileres
                .FirstOrDefault(a => a.Id == id);

            if (alquiler != null)
            {
                _context.Alquileres.Remove(alquiler);
                _context.SaveChanges();
            }
        }
    }
}