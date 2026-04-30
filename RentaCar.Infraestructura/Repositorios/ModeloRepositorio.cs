using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaCar.Infraestructura.Repositorios
{
    public class ModeloRepositorio
    {
        private readonly RentaCarDBContext _context;

        public ModeloRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los modelos
        public List<Modelo> ObtenerTodos()
        {
            return _context.Modelos.ToList();
        }

        // Obtener modelo por ID
        public Modelo? ObtenerPorId(int id)
        {
            return _context.Modelos
                .FirstOrDefault(m => m.Id == id);
        }

        // Obtener modelos por marca
        public List<Modelo> ObtenerPorMarca(int marcaId)
        {
            return _context.Modelos
                .Where(m => m.MarcaId == marcaId)
                .ToList();
        }

        // Agregar modelo
        public void Agregar(Modelo modelo)
        {
            _context.Modelos.Add(modelo);
            _context.SaveChanges();
        }

        // Actualizar modelo
        public void Actualizar(Modelo modelo)
        {
            _context.Modelos.Update(modelo);
            _context.SaveChanges();
        }

        // Eliminar modelo
        public void Eliminar(int id)
        {
            var modelo = _context.Modelos
                .FirstOrDefault(m => m.Id == id);

            if (modelo != null)
            {
                _context.Modelos.Remove(modelo);
                _context.SaveChanges();
            }
        }
    }
}