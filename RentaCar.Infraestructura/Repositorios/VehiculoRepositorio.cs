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
                .Where(v => v.Activo)
                .ToList();
        }

        public Vehiculo? ObtenerPorPatente(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
                return null;

            patente = patente.Trim().ToUpper();

            return _context.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.Color)
                .Include(v => v.Tipo)
                .Include(v => v.Estado)
                .Include(v => v.Combustible)
                .FirstOrDefault(v => v.Patente == patente);
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
                existente.ImagenUrl = vehiculo.ImagenUrl;
                _context.SaveChanges();
            }
        }

        public void Eliminar(string patente)
        {
            var vehiculo = _context.Vehiculos.FirstOrDefault(v => v.Patente == patente);

            if (vehiculo != null)
            {
                vehiculo.Activo = false;
                _context.SaveChanges();
            }
        }
        public bool ExistePatente(string patente)
        {
            return _context.Vehiculos.Any(v => v.Patente == patente);
        }
        public List<Vehiculo> ObtenerDisponibles(DateOnly inicio, DateOnly fin)
        {
            return _context.Vehiculos
                .Include(v => v.Marca)
                .Include(v => v.Modelo)
                .Include(v => v.Color)
                .Include(v => v.Combustible)
                .Include(v => v.Estado)
                .Include(v => v.Tipo)
                .Where(v =>

                    // No tiene reservas superpuestas
                    !_context.Reservas.Any(r =>
                        r.VehiculoPatente == v.Patente &&
                        r.Activo &&
                        r.EstadoId != 3 && // cancelada
                        inicio <= r.FechaFin &&
                        fin >= r.FechaInicio
                    )

                    &&

                    // No tiene alquileres superpuestos
                    !_context.Alquileres.Any(a =>
                        a.VehiculoPatente == v.Patente &&
                        a.Activo &&
                        a.EstadoId != 4 && // cancelado
                        inicio <= a.FechaFin &&
                        fin >= a.FechaInicio
                    )

                )
                .ToList();
        }
    }
}