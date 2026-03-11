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
    public class EstadoVehiculoRepositorio
    {
        private readonly RentaCarDBContext _context;

        public EstadoVehiculoRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los estados de vehículo
        public List<EstadoVehiculo> ObtenerTodos()
        {
            return _context.EstadosVehiculos.ToList();
        }

        // Obtener estado por ID
        public EstadoVehiculo? ObtenerPorId(int id)
        {
            return _context.EstadosVehiculos
                .FirstOrDefault(e => e.Id == id);
        }

        // Agregar estado
        public void Agregar(EstadoVehiculo estado)
        {
            _context.EstadosVehiculos.Add(estado);
            _context.SaveChanges();
        }

        // Actualizar estado
        public void Actualizar(EstadoVehiculo estado)
        {
            _context.EstadosVehiculos.Update(estado);
            _context.SaveChanges();
        }

        // Eliminar estado
        public void Eliminar(int id)
        {
            var estado = _context.EstadosVehiculos
                .FirstOrDefault(e => e.Id == id);

            if (estado != null)
            {
                _context.EstadosVehiculos.Remove(estado);
                _context.SaveChanges();
            }
        }
    }
}