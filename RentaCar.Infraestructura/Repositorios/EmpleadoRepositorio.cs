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
    public class EmpleadoRepositorio
    {
        private readonly RentaCarDBContext _context;

        public EmpleadoRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los empleados
        public List<Empleado> ObtenerTodos()
        {
            return _context.Empleados.ToList();
        }

        // Obtener empleado por DNI
        public Empleado? ObtenerPorDni(int dni)
        {
            return _context.Empleados
                .FirstOrDefault(e => e.Dni == dni);
        }

        // Agregar empleado
        public void Agregar(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        // Actualizar empleado
        public void Actualizar(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            _context.SaveChanges();
        }

        // Eliminar empleado
        public void Eliminar(int dni)
        {
            var empleado = _context.Empleados
                .FirstOrDefault(e => e.Dni == dni);

            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
        }
    }
}