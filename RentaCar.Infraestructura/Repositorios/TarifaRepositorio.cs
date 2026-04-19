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
    public class TarifaRepositorio
    {
        private readonly RentaCarDBContext _context;

        public TarifaRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todas las tarifas
        public List<Tarifa> ObtenerTodos()
        {
            return _context.Tarifas
                .Include(t => t.TipoVehiculo)
                .ToList();
        }

        // Obtener tarifa por ID
        public Tarifa? ObtenerPorId(int id)
        {
            return _context.Tarifas
                .FirstOrDefault(t => t.Id == id);
        }

        // Obtener tarifa activa de un tipo de vehículo
        public Tarifa? ObtenerTarifaActivaPorTipoVehiculo(int tipoVehiculoId)
        {
            return _context.Tarifas
                .FirstOrDefault(t => t.TipoVehiculoId == tipoVehiculoId && t.Activa);
        }

        // Agregar tarifa
        public void Agregar(Tarifa tarifa)
        {
            _context.Tarifas.Add(tarifa);
            _context.SaveChanges();
        }

        // Actualizar tarifa
        public void Actualizar(Tarifa tarifa)
        {
            _context.Tarifas.Update(tarifa);
            _context.SaveChanges();
        }

        // Eliminar tarifa
        public void Eliminar(int id)
        {
            var tarifa = _context.Tarifas
                .FirstOrDefault(t => t.Id == id);

            if (tarifa != null)
            {
                _context.Tarifas.Remove(tarifa);
                _context.SaveChanges();
            }
        }
    }
}