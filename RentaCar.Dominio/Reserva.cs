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

        public decimal PrecioDia { get; set; }
        public decimal PrecioTotal { get; set; }

        public decimal? Senia { get; set; }

        public string Estado { get; set; }

        public Reserva(
            int clienteDni,
            string vehiculoPatente,
            DateOnly fechaInicio,
            DateOnly fechaFin,
            decimal precioDia,
            string estado,
            decimal? senia = null)
        {
            ClienteDni = clienteDni;
            VehiculoPatente = vehiculoPatente;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            PrecioDia = precioDia;
            PrecioTotal = CalcularPrecioTotal(fechaInicio, fechaFin, precioDia);
            Estado = estado;
            Senia = senia;
        }

        private decimal CalcularPrecioTotal(DateOnly inicio, DateOnly fin, decimal precioDia)
        {
            int dias = fin.DayNumber - inicio.DayNumber;
            return dias * precioDia;
        }
    }
}