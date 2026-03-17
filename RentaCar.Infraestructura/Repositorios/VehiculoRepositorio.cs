using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using System.Collections.Generic;
using System.Linq;

namespace RentaCar.Infraestructura.Repositorios
{
    public class VehiculoRepositorio
    {
        private readonly RentaCarDBContext _context;

        public VehiculoRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        public List<Vehiculo> ObtenerTodos()
        {
            return _context.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.Color)
                .Include(v => v.Tipo)
                .Include(v => v.Estado)
                .Include(v => v.Combustible)
                .ToList();
        }

        public Vehiculo ObtenerPorPatente(string patente)
        {
            return _context.Vehiculos.FirstOrDefault(v => v.Patente == patente);
        }

        public void Agregar(Vehiculo vehiculo)
        {
            _context.Vehiculos.Add(vehiculo);
            _context.SaveChanges();
        }

        public void Actualizar(Vehiculo vehiculo)
        {
            _context.Vehiculos.Update(vehiculo);
            _context.SaveChanges();
        }

        public void Eliminar(string patente)
        {
            var vehiculo = _context.Vehiculos.FirstOrDefault(v => v.Patente == patente);

            if (vehiculo != null)
            {
                _context.Vehiculos.Remove(vehiculo);
                _context.SaveChanges();
            }
        }
    }
}