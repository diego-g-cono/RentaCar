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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RentaCarDb;Username=postgres;Password=<1123581321>;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>()
                .HasKey(v => v.Patente);
            
            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.Dni);
        }
        public RentaCarDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
