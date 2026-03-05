using System;

namespace Dominio
{
    internal class Devolucion
    {
        public int Id { get; set; }

        public DateTime FechaDevolucion { get; set; }

        public Alquiler Alquiler { get; set; }

        public bool TanqueLleno { get; set; }

        public string Observaciones { get; set; }

        public Devolucion(int id, DateTime fechaDevolucion, Alquiler alquiler, bool tanqueLleno, string observaciones)
        {
            Id = id;
            FechaDevolucion = fechaDevolucion;
            Alquiler = alquiler;
            TanqueLleno = tanqueLleno;
            Observaciones = observaciones;
        }
    }
}