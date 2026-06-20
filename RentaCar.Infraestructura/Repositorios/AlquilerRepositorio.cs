using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Infraestructura.Data;

namespace RentaCar.Infraestructura
{
    public class AlquilerRepositorio
    {
        private readonly RentaCarDBContext _context;

        public AlquilerRepositorio(RentaCarDBContext context)
        {
            _context = context;
        }
        public List<Alquiler> ObtenerTodos()
        {
            return _context.Alquileres
                .Include(a => a.Conductor)
                .Include(a => a.Cliente)
                .Include(a => a.Estado)
                .Include(a => a.Reserva)
                .Include(a => a.Vehiculo)
                .Include(a => a.Seguro)
                .Where(a => a.Activo)
                .ToList();
        }
        public Alquiler? ObtenerPorId(int id)
        {
            return _context.Alquileres
                .Include(a => a.Conductor)
                .Include(a => a.Cliente)
                .Include(a => a.Estado)
                .Include(a => a.Reserva)
                .Include(a => a.Vehiculo)
                .Include(a => a.Seguro)
                .FirstOrDefault(a => a.Id == id);
        }

        public void Agregar(Alquiler alquiler)
        {
            _context.Alquileres.Add(alquiler);
            _context.SaveChanges();
        }
        public void Actualizar(Alquiler alquiler)
        {
            _context.Alquileres.Update(alquiler);
            _context.SaveChanges();
        }
        public void Eliminar(int id)
        {
            var alquiler = _context.Alquileres.Find(id);

            if (alquiler != null)
            {
                alquiler.Activo = false;
                _context.SaveChanges();
            }
        }
    }
}