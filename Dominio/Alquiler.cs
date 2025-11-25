using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Alquiler
    {
        private int _idAlquiler;
        private DateOnly _fechaInicio;
        private DateOnly _fechaFin;
        private Vehiculo _vehiculo;
        private Conductor _conductor;
        private Cliente _cliente;
        private float _tarifa;
        private string _status;
        private Reserva? _reserva;

        public Alquiler(int id, DateOnly fechaInicio, DateOnly fechaFin, Vehiculo vehiculo, Conductor conductor, Cliente cliente, float tarifa, string status,Reserva? reserva=null)
        {
            _idAlquiler = id;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _vehiculo = vehiculo;
            _conductor = conductor;
            _cliente = cliente;
            _tarifa = tarifa;
            _status = status;
            _reserva = reserva;
        }
        public int IdAlquiler
        {
            get { return _idAlquiler; }
            set { _idAlquiler = value; }
        }
        public DateOnly FechaInicio
        {
            get { return _fechaInicio; }
            set { _fechaInicio = value; }
        }
        public DateOnly FechaFin
        {
            get { return _fechaFin; }
            set { _fechaFin = value; }
        }
        public Vehiculo Vehiculo
        {
            get { return _vehiculo; }
            set { _vehiculo = value; }
        }
        public Conductor Conductor
        {
            get { return _conductor; }
            set { _conductor = value; }
        }
        public Cliente Cliente
        {
            get { return _cliente; }
            set { _cliente = value; }
        }
        public float Tarifa
        {
            get { return _tarifa; }
            set { _tarifa = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public Reserva? Reserva
        {
            get { return _reserva; }
            set { _reserva = value; }
        }
    }
}
