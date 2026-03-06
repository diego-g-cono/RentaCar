using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;

namespace RentaCar.Escritorio
{
    internal class RentaCarDBContext : DbContext
    {
        public DbSet<Vehiculo> vehiculos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Reserva> reservas { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<Dominio.Color> colores { get; set; }
        public DbSet<Combustible>combustibles { get; set; }
        public DbSet<EstadoVehiculo> estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RentaCarDb;Username=postgres;Password=<1123581321>;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("vehiculos");
                entity.HasKey(v => v.Patente);

                entity.Property(v => v.Patente).HasColumnName("patente");
                entity.Property(v => v.Marca_id).HasColumnName("marca");
                entity.Property(v => v.Modelo_id).HasColumnName("modelo");
                entity.Property(v => v.EstadoVehiculo_id).HasColumnName("estado");
                entity.Property(v => v.Anio).HasColumnName("anio");
                entity.Property(v => v.Color).HasColumnName("color");
                entity.Property(v => v.Tipo_combustible).HasColumnName("tipo_combustible");
                entity.Property(v => v.Kilometraje).HasColumnName("kilometraje");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");
                entity.HasKey(c => c.dni);

                entity.Property(c => c.dni).HasColumnName("dni");
                entity.Property(c => c.nombre).HasColumnName("nombre");
                entity.Property(c => c.apellido).HasColumnName("apellido");
                entity.Property(c => c.email).HasColumnName("email");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("reservas");
                entity.HasKey(r => r.id);

                entity.Property(r => r.id).HasColumnName("id");
                entity.Property(r => r.cliente_dni).HasColumnName("cliente_dni");
                entity.Property(r => r.vehiculo_patente).HasColumnName("vehiculo_patente");
                entity.Property(r => r.fecha_inicio).HasColumnName("fecha_inicio");
                entity.Property(r => r.fecha_fin).HasColumnName("fecha_fin");
                entity.Property(r => r.estado).HasColumnName("estado");
                entity.Property(r => r.senia).HasColumnName("senia");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.ToTable("marcas");
                entity.HasKey(m => m.id);

                entity.Property(m => m.id).HasColumnName("id");
                entity.Property(m => m.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("modelos");
                entity.HasKey(m => m.id);

                entity.Property(m => m.id).HasColumnName("id");
                entity.Property(m => m.nombre).HasColumnName("nombre");
                entity.Property(m => m.id_marca).HasColumnName("marca_id");
            });

            modelBuilder.Entity<Dominio.Color>(entity =>
            {
                entity.ToTable("colores");
                entity.HasKey(c => c.id);

                entity.Property(c => c.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Combustible>(entity =>
            {
                entity.ToTable("combustibles");
                entity.HasKey(c => c.id);

                entity.Property(c => c.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<EstadoVehiculo>(entity => 
            {
                entity.ToTable("estados");
                entity.HasKey(e => e.id);

                entity.Property(e => e.categoria).HasColumnName("categoria");
                entity.Property(e => e.nombre).HasColumnName("nombre");
            });
        }
        public RentaCarDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
