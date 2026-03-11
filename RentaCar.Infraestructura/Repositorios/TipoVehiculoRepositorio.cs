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
    public class TipoVehiculoRepositorio
    {
        private readonly RentaCarDBContext _context;

        public TipoVehiculoRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los tipos de vehículo
        public List<TipoVehiculo> ObtenerTodos()
        {
            return _context.TiposVehiculos.ToList();
        }

        // Obtener tipo de vehículo por ID
        public TipoVehiculo? ObtenerPorId(int id)
        {
            return _context.TiposVehiculos
                .FirstOrDefault(t => t.Id == id);
        }

        // Agregar tipo de vehículo
        public void Agregar(TipoVehiculo tipoVehiculo)
        {
            _context.TiposVehiculos.Add(tipoVehiculo);
            _context.SaveChanges();
        }

        // Actualizar tipo de vehículo
        public void Actualizar(TipoVehiculo tipoVehiculo)
        {
            _context.TiposVehiculos.Update(tipoVehiculo);
            _context.SaveChanges();
        }

        // Eliminar tipo de vehículo
        public void Eliminar(int id)
        {
            var tipoVehiculo = _context.TiposVehiculos
                .FirstOrDefault(t => t.Id == id);

            if (tipoVehiculo != null)
            {
                _context.TiposVehiculos.Remove(tipoVehiculo);
                _context.SaveChanges();
            }
        }
    }
}