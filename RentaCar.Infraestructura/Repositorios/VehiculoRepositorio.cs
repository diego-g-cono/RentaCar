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
            var existente = _context.Vehiculos
                .FirstOrDefault(v => v.Patente == vehiculo.Patente);

            if (existente != null)
            {
                existente.Anio = vehiculo.Anio;
                existente.Kilometraje = vehiculo.Kilometraje;
                existente.MarcaId = vehiculo.MarcaId;
                existente.ModeloId = vehiculo.ModeloId;
                existente.ColorId = vehiculo.ColorId;
                existente.CombustibleId = vehiculo.CombustibleId;
                existente.EstadoId = vehiculo.EstadoId;
                existente.TipoId = vehiculo.TipoId;

                _context.SaveChanges();
            }
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
        public bool ExistePatente(string patente)
        {
            return _context.Vehiculos.Any(v => v.Patente == patente);
        }
    }
}