using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Reserva
    {
        private int _idReserva;
        private Cliente _cliente;
        private float? _senia;
        private DateOnly _fechaInicio;
        private DateOnly _fechaFin;
        private Vehiculo _vehiculo;

        public Reserva(int id, Cliente cliente, DateOnly fechaInicio, DateOnly fechaFin, Vehiculo vehiculo, float? senia = null)
        {
            _idReserva = id;
            _cliente = cliente;
            _senia = senia;
            _fechaFin = fechaFin;
            _vehiculo = vehiculo;
        }
        public int IdReserva
        {
            get { return _idReserva; }
            set { _idReserva = value; }
        }
        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        public float? Senia
        {
            get { return _senia; }
            set { _senia = value; }
        }
        public DateOnly FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        public Vehiculo Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }
        public DateOnly FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }
    }
}
