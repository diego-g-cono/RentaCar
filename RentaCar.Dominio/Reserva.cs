using System;

namespace RentaCar.Dominio
{
    public class Reserva
    {
        public int Id { get; set; }

        // Foreign keys
        public int ClienteDni { get; set; }
        public string VehiculoPatente { get; set; }

        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }

        public decimal Senia { get; set; }

        public int EstadoId { get; set; }

        public Reserva(
            int clienteDni,
            string vehiculoPatente,
            DateOnly fechaInicio,
            DateOnly fechaFin,
            decimal precio,
            int estadoId,
            decimal senia)
        {
            ClienteDni = clienteDni;
            VehiculoPatente = vehiculoPatente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = precio;
            EstadoId = estadoId;
            Senia = senia;
        }

    }
}