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
    public class ClienteRepositorio
    {
        private readonly RentaCarDBContext _context;

        public ClienteRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }

        // Obtener todos los clientes
        public List<Cliente> ObtenerTodos()
        {
            return _context.Clientes.ToList();
        }

        // Obtener cliente por DNI
        public Cliente? ObtenerPorDni(int dni)
        {
            return _context.Clientes
                .FirstOrDefault(c => c.Dni == dni);
        }

        // Agregar cliente
        public void Agregar(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        // Actualizar cliente
        public void Actualizar(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();
        }

        // Eliminar cliente
        public void Eliminar(int dni)
        {
            var cliente = _context.Clientes.FirstOrDefault(c => c.Dni == dni);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}