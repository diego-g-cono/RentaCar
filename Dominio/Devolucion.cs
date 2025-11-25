using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Devolucion
    {
        private int _idDevolucion;
        private DateTime _fechaDevolucion;
        private Alquiler _alquiler;
        private bool _tanqueLleno;
        private string _observaciones;

        public Devolucion(int id, DateTime fechaDevolucion, Alquiler alquiler, bool tanqueLleno, string observaciones)
        {
            _idDevolucion = id;
            _fechaDevolucion = fechaDevolucion;
            _alquiler = alquiler;
            _tanqueLleno = tanqueLleno;
            _observaciones = observaciones;
        }
        public int IdDevolucion
        {
            get { return _idDevolucion; }
            set { _idDevolucion = value; }
        }
        public DateTime FechaDevolucion
        {
            get { return _fechaDevolucion; }
            set { _fechaDevolucion = value; }
        }
        public Alquiler Alquiler
        {
            get { return _alquiler; }
            set { _alquiler = value; }
        }
        public bool TanqueLleno
        {
            get { return _tanqueLleno; }
            set { _tanqueLleno = value; }
        }
        public string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
    }
}
