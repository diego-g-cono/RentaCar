using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;

namespace RentaCar.Infraestructura.Data
{
    public class RentaCarDBContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Dominio.Color> Colores { get; set; }
        public DbSet<Combustible> Combustibles { get; set; }
        public DbSet<EstadoVehiculo> EstadosVehiculos { get; set; }
        public DbSet<EstadoReserva> EstadosReservas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Devolucion> Devoluciones { get; set; }
        public DbSet<Conductor> Conductores { get; set; }
        public DbSet<EstadoAlquiler> EstadosAlquileres { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Tarifa> Tarifas { get; set; }
        public DbSet<TipoVehiculo> TiposVehiculos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=rentacar;Username=postgres;Password=postgres;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehiculo>(entity =>
            {
                entity.ToTable("vehiculos");
                entity.HasKey(v => v.Patente);

                entity.Property(v => v.Patente).HasColumnName("patente");
                entity.Property(v => v.MarcaId).HasColumnName("marca_id");
                entity.Property(v => v.ModeloId).HasColumnName("modelo_id");
                entity.Property(v => v.EstadoId).HasColumnName("estado_id");
                entity.Property(v => v.Anio).HasColumnName("anio");
                entity.Property(v => v.ColorId).HasColumnName("color_id");
                entity.Property(v => v.CombustibleId).HasColumnName("combustible_id");
                entity.Property(v => v.Kilometraje).HasColumnName("kilometraje");
                entity.Property(v => v.TipoId).HasColumnName("tipo_id");

                entity.HasOne(v => v.Marca)
                      .WithMany()
                      .HasForeignKey(v => v.MarcaId);

                entity.HasOne(v => v.Modelo)
                      .WithMany()
                      .HasForeignKey(v => v.ModeloId);

                entity.HasOne(v => v.Color)
                      .WithMany()
                      .HasForeignKey(v => v.ColorId);

                entity.HasOne(v => v.Estado)
                      .WithMany()
                      .HasForeignKey(v => v.EstadoId);

                entity.HasOne(v => v.Combustible)
                      .WithMany()
                      .HasForeignKey(v => v.CombustibleId);

                entity.HasOne(v => v.Tipo)
                      .WithMany()
                      .HasForeignKey(v => v.TipoId);
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("clientes");
                entity.HasKey(c => c.Dni);

                entity.Property(c => c.Dni).HasColumnName("dni");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Apellido).HasColumnName("apellido");
                entity.Property(c => c.Email).HasColumnName("email");
                entity.Property(c => c.Telefono).HasColumnName("telefono");
                entity.Property(c => c.UsuarioId).HasColumnName("usuario_id");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.ToTable("reservas");
                entity.HasKey(r => r.Id);

                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.ClienteDni).HasColumnName("cliente_dni");
                entity.Property(r => r.VehiculoPatente).HasColumnName("vehiculo_patente");
                entity.Property(r => r.FechaInicio).HasColumnName("fecha_inicio");
                entity.Property(r => r.FechaFin).HasColumnName("fecha_fin");
                entity.Property(r => r.EstadoId).HasColumnName("estado_id");
                entity.Property(r => r.Senia).HasColumnName("senia");
                entity.Property(r => r.Precio).HasColumnName("precio");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.ToTable("marcas");
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Id).HasColumnName("id");
                entity.Property(m => m.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Modelo>(entity =>
            {
                entity.ToTable("modelos");
                entity.HasKey(m => m.Id);

                entity.Property(m => m.Id).HasColumnName("id");
                entity.Property(m => m.Nombre).HasColumnName("nombre");
                entity.Property(m => m.MarcaId).HasColumnName("marca_id");
            });

            modelBuilder.Entity<Dominio.Color>(entity =>
            {
                entity.ToTable("colores");
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Combustible>(entity =>
            {
                entity.ToTable("combustibles");
                entity.HasKey(c => c.Id);

                entity.Property(c => c.Id).HasColumnName("id");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<EstadoVehiculo>(entity => 
            {
                entity.ToTable("estados_vehiculos");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<EstadoReserva>(entity =>
            {
                entity.ToTable("estados_reservas");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.ToTable("administradores");
                entity.HasKey(a => a.Dni);

                entity.Property(a => a.Dni).HasColumnName("dni");
                entity.Property(a => a.Nombre).HasColumnName("nombre");
                entity.Property(a => a.Apellido).HasColumnName("apellido");
                entity.Property(a => a.UsuarioId).HasColumnName("usuario_id");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("empleados");
                entity.HasKey(e => e.Dni);

                entity.Property(e => e.Dni).HasColumnName("dni");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
                entity.Property(e => e.Apellido).HasColumnName("apellido");
                entity.Property(e => e.Puesto).HasColumnName("puesto");
                entity.Property(e => e.UsuarioId).HasColumnName("usuario_id");
            });

            modelBuilder.Entity<Alquiler>(entity =>
            {
                entity.ToTable("alquileres");
                entity.HasKey(a => a.Id);

                entity.Property(a => a.Id).HasColumnName("id");
                entity.Property(a => a.ReservaId).HasColumnName("reserva_id");
                entity.Property(a => a.FechaInicio).HasColumnName("fecha_inicio");
                entity.Property(a => a.FechaFin).HasColumnName("fecha_fin");
                entity.Property(a => a.EstadoId).HasColumnName("estado_id");
                entity.Property(a => a.Precio).HasColumnName("precio");
                entity.Property(a => a.ConductorId).HasColumnName("conductor_id");
                entity.Property(a => a.ClienteId).HasColumnName("cliente_id");
                entity.Property(a => a.VehiculoPatente).HasColumnName("vehiculo_patente");
            });

            modelBuilder.Entity<Devolucion>(entity =>
            {
                entity.ToTable("devoluciones");
                entity.HasKey(d => d.Id);

                entity.Property(d => d.Id).HasColumnName("id");
                entity.Property(d => d.AlquilerId).HasColumnName("alquiler_id");
                entity.Property(d => d.TanqueLleno).HasColumnName("tanque_lleno");
                entity.Property(d => d.Observaciones).HasColumnName("obervaciones");
            });

            modelBuilder.Entity<Conductor>(entity =>
            {
                entity.ToTable("conductores");
                entity.HasKey(c => c.Dni);

                entity.Property(c => c.Dni).HasColumnName("dni");
                entity.Property(c => c.Nombre).HasColumnName("nombre");
                entity.Property(c => c.Apellido).HasColumnName("apellido");
                entity.Property(c => c.FechaVencLic).HasColumnName("fecha_venc_lic");
            });

            modelBuilder.Entity<EstadoAlquiler>(entity =>
            {
                entity.ToTable("estados_alquileres");
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.ToTable("roles");
                entity.HasKey(r => r.Id);

                entity.Property(r => r.Id).HasColumnName("id");
                entity.Property(r => r.Nombre).HasColumnName("nombre");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Id).HasColumnName("id");
                entity.Property(u => u.NombreUsuario).HasColumnName("nombre_usuario");
                entity.Property(u => u.Contrasenia).HasColumnName("contrasenia");
                entity.Property(u => u.RolId).HasColumnName("rol_id");
                entity.Property(u => u.Activo).HasColumnName("activo");
            });

            modelBuilder.Entity<Seguro>(entity =>
            {
                entity.ToTable("seguros");
                entity.HasKey(s => s.Id);

                entity.Property(s => s.Id).HasColumnName("id");
                entity.Property(s => s.Nombre).HasColumnName("nombre");
                entity.Property(s => s.Tasa).HasColumnName("tasa");
            });

            modelBuilder.Entity<Tarifa>(entity =>
            {
                entity.ToTable("tarifas");
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Id).HasColumnName("id");
                entity.Property(t => t.TipoVehiculoId).HasColumnName("tipo_vehiculo_id");
                entity.Property(t => t.PrecioSemana).HasColumnName("precio_semana");
                entity.Property(t => t.PrecioDia).HasColumnName("precio_dia");
                entity.Property(t => t.Activa).HasColumnName("activa");
            });

            modelBuilder.Entity<TipoVehiculo>(entity =>
            {
                entity.ToTable("tipos_vehiculos");
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Id).HasColumnName("id");
                entity.Property(t => t.Nombre).HasColumnName("nombre");
            });
        }
        public RentaCarDBContext()
        {
            Database.EnsureCreated();
        }
    }
}

