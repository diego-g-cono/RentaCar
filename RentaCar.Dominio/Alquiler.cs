using System;

namespace RentaCar.Dominio
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }
        //foreign keys
        public string VehiculoPatente { get; set; }
        public int ConductorId { get; set; }
        public int ClienteId { get; set; }
        public int EstadoId { get; set; }
        public int? ReservaId { get; set; }
        
        public Alquiler(int id, 
            DateOnly fechaInicio, 
            DateOnly fechaFin, 
            decimal precio, 
            string vehiculoPatente, 
            int conductorId, 
            int clienteId, 
            int estadoId, 
            int? reservaId
        )
        {
            Id = id;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Precio = precio;
            VehiculoPatente = vehiculoPatente;
            ConductorId = conductorId;
            ClienteId = clienteId;
            EstadoId = estadoId;
            ReservaId = reservaId;
        }

        public Alquiler() { }
    }
}