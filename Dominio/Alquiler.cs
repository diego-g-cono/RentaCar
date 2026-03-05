using System;

namespace Dominio
{
    internal class Alquiler
    {
        public int AlquilerId { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Conductor Conductor { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Tarifa { get; set; }
        public string Status { get; set; }
        public Reserva? Reserva { get; set; }

        public Alquiler(
            int alquilerId,
            DateOnly fechaInicio,
            DateOnly fechaFin,
            Vehiculo vehiculo,
            Conductor conductor,
            Cliente cliente,
            decimal tarifa,
            string status,
            Reserva? reserva = null)
        {
            AlquilerId = alquilerId;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Vehiculo = vehiculo;
            Conductor = conductor;
            Cliente = cliente;
            Tarifa = tarifa;
            Status = status;
            Reserva = reserva;
        }
    }
}