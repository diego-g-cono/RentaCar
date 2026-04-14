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
    public class ConductorRepositorio
    {
        private readonly RentaCarDBContext _context;

        public ConductorRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los conductores
        public List<Conductor> ObtenerTodos()
        {
            //return _context.Conductores.ToList();
            return _context.Conductores
        .FromSqlRaw("SELECT dni as id, dni, nombre, apellido, fecha_venc_lic FROM conductores")
        .ToList();
        }

        // Obtener conductor por DNI
        public Conductor? ObtenerPorDni(int dni)
        {
            return _context.Conductores
                .FirstOrDefault(c => c.Dni == dni);
        }

        // Agregar conductor
        public void Agregar(Conductor conductor)
        {
            _context.Conductores.Add(conductor);
            _context.SaveChanges();
        }

        // Actualizar conductor
        public void Actualizar(Conductor conductor)
        {
            _context.Conductores.Update(conductor);
            _context.SaveChanges();
        }

        // Eliminar conductor
        public void Eliminar(int dni)
        {
            var conductor = _context.Conductores
                .FirstOrDefault(c => c.Dni == dni);

            if (conductor != null)
            {
                _context.Conductores.Remove(conductor);
                _context.SaveChanges();
            }
        }
    }
}