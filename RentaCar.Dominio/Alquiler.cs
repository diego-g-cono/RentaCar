using System;

namespace RentaCar.Dominio
{
    internal class Alquiler
    {
        public int Id { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public decimal Precio { get; set; }
        //foreign keys
        public int VehiculoPatente { get; set; }
        public int ConductorId { get; set; }
        public int ClienteId { get; set; }
        public int EstadoAlquilerId { get; set; }
        public int? ReservaId { get; set; }
        
        public Alquiler(int id, 
            DateOnly fechaInicio, 
            DateOnly fechaFin, 
            decimal precio, 
            int vehiculoPatente, 
            int conductorId, 
            int clienteId, 
            int estadoAlquilerId, 
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
            EstadoAlquilerId = estadoAlquilerId;
            ReservaId = reservaId;
        }
    }
}