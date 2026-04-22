using System;

namespace RentaCar.Dominio
{
    public class Devolucion
    {
        public int Id { get; set; }

        public DateOnly Fecha { get; set; }

        public int AlquilerId { get; set; }

        public bool TanqueLleno { get; set; }

        public string Observaciones { get; set; }

        public Devolucion(int id, DateOnly fecha, int alquilerId, bool tanqueLleno, string observaciones)
        {
            Id = id;
            Fecha = fecha;
            AlquilerId = alquilerId;
            TanqueLleno = tanqueLleno;
            Observaciones = observaciones;
        }

        public Devolucion()
        {
        }
    }
}