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

        public string Estado { get; set; }

        public Reserva(
            int clienteDni,
            string vehiculoPatente,
            DateOnly fechaInicio,
            DateOnly fechaFin,
            string estado,
            decimal senia)
        {
            ClienteDni = clienteDni;
            VehiculoPatente = vehiculoPatente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = CalcularPrecioTotal(fechaInicio, fechaFin);
            Estado = estado;
            Senia = senia;
        }

        private decimal CalcularPrecioTotal(DateOnly inicio, DateOnly fin)
        {
            int dias = fin.DayNumber - inicio.DayNumber;
            return dias;
        }
    }
}