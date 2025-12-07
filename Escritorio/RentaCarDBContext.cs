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
        public DbSet<Vehiculo> vehiculos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Reserva> reservas { get; set; }
        public DbSet<Marca> marcas { get; set; }
        public DbSet<Modelo> modelos { get; set; }
        public DbSet<ColorV> colores { get; set; }
        public DbSet<Combustible>combustibles { get; set; }
        public DbSet<Estado> estados { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=RentaCarDb;Username=postgres;Password=<1123581321>;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("vehiculos");
                entity.HasKey(v => v.patente);

                entity.Property(v => v.patente).HasColumnName("patente");
                entity.Property(v => v.marca).HasColumnName("marca");
                entity.Property(v => v.modelo).HasColumnName("modelo");
                entity.Property(v => v.estado).HasColumnName("estado");
                entity.Property(v => v.anio).HasColumnName("anio");
                entity.Property(v => v.color).HasColumnName("color");
                entity.Property(v => v.tipo_combustible).HasColumnName("tipo_combustible");
                entity.Property(v => v.kilometraje).HasColumnName("kilometraje");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");
                entity.HasKey(c => c.dni);

                entity.Property(c => c.dni).HasColumnName("dni");
                entity.Property(c => c.nombre).HasColumnName("nombre");
                entity.Property(c => c.apellido).HasColumnName("apellido");
                entity.Property(c => c.direccion).HasColumnName("direccion");
                entity.Property(c => c.fecha_nacimiento).HasColumnName("fecha_nacimiento");
                entity.Property(c => c.usuario).HasColumnName("usuario");
                entity.Property(c => c.contrasenia_hash).HasColumnName("contrasenia_hash");
                entity.Property(c => c.email).HasColumnName("email");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("reservas");
                entity.HasKey(r => r.id_reserva);

                entity.Property(r => r.id_reserva).HasColumnName("id_reserva");
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
                entity.HasKey(m => m.id_marca);
                entity.Property(m => m.id_marca).HasColumnName("id_marca");
                entity.Property(m => m.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("modelos");
                entity.HasKey(m => m.id_modelo);
                entity.Property(m => m.id_modelo).HasColumnName("id_modelo");
                entity.Property(m => m.nombre).HasColumnName("nombre");
                entity.Property(m => m.id_marca).HasColumnName("id_marca");
            });

            modelBuilder.Entity<ColorV>(entity =>
            {
                entity.ToTable("colores");
                entity.HasKey(c => c.id_color);
                entity.Property(c => c.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Combustible>(entity =>
            {
                entity.ToTable("combustibles");
                entity.HasKey(c => c.id_combustible);
                entity.Property(c => c.nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Estado>()
                        .ToTable("estados")
                        .HasKey(e => e.id_estado);

            modelBuilder.Entity<Estado>()
                        .Property(e => e.categoria).HasColumnName("categoria");

            modelBuilder.Entity<Estado>()
                        .Property(e => e.nombre).HasColumnName("nombre");
        }
        public RentaCarDBContext()
        {
            Database.EnsureCreated();
        }
    }
}
