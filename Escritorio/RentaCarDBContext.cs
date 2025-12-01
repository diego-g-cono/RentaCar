using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Escritorio
{
    internal class RentaCarDBContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RentaCarDb;Username=postgres;Password=yourPassword;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
                .HasKey(v => v.Patente);
            
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Dni);

            modelBuilder.Entity<Reserva>()
                .HasKey(r => r.IdReserva);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Cliente)
                .WithMany()
                .HasForeignKey(r => r.ClienteDni);

            modelBuilder.Entity<Reserva>()
                .HasOne(r => r.Vehiculo)
                .WithMany()
                .HasForeignKey(r => r.VehiculoPatente);
        }
        public RentaCarDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
