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
    public class MarcaRepositorio
    {
        private readonly RentaCarDBContext _context;

        public MarcaRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todas las marcas
        public List<Marca> ObtenerTodos()
        {
            return _context.Marcas.ToList();
        }

        // Obtener marca por ID
        public Marca? ObtenerPorId(int id)
        {
            return _context.Marcas
                .FirstOrDefault(m => m.Id == id);
        }

        // Agregar marca
        public void Agregar(Marca marca)
        {
            _context.Marcas.Add(marca);
            _context.SaveChanges();
        }

        // Actualizar marca
        public void Actualizar(Marca marca)
        {
            _context.Marcas.Update(marca);
            _context.SaveChanges();
        }

        // Eliminar marca
        public void Eliminar(int id)
        {
            var marca = _context.Marcas
                .FirstOrDefault(m => m.Id == id);

            if (marca != null)
            {
                _context.Marcas.Remove(marca);
                _context.SaveChanges();
            }
        }
    }
}