using System;

namespace RentaCar.Dominio
{
    public class Alquiler
    {
        public int Id { get; set; }

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }
        public string VehiculoPatente { get; set; } = null!;
        public int ConductorDni { get; set; }
        public int ClienteDni { get; set; }
        public int EstadoId { get; set; }
        public int? ReservaId { get; set; }
        public Vehiculo? Vehiculo { get; set; }
        public Conductor? Conductor { get; set; }
        public Cliente? Cliente { get; set; }
        public EstadoAlquiler? Estado { get; set; }
        public Reserva? Reserva { get; set; }

        public bool Activo { get; set; } = true;

        public Alquiler(
            DateOnly fechaInicio,
            DateOnly fechaFin,
            decimal precio,
            string vehiculoPatente,
            int conductorDni,
            int clienteDni,
            int estadoId,
            int? reservaId)
        {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = precio;
            VehiculoPatente = vehiculoPatente;
            ConductorDni = conductorDni;
            ClienteDni = clienteDni;
            EstadoId = estadoId;
            ReservaId = reservaId;
        }
        public Alquiler()
        {
        }
    }
}