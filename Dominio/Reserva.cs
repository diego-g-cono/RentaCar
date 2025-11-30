using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        private int _idReserva;
        // Foreign keys
        public int _clienteDni;
        public string _vehiculoPatente;

        private Cliente _cliente;
        private float? _senia;
        private DateOnly _fechaInicio;
        private DateOnly _fechaFin;
        private Vehiculo _vehiculo;
        private string _estado;

        public Reserva(int clienteDni, string vehiculoPatente, DateOnly fechaInicio, DateOnly fechaFin, string estado, float? senia = null)
        {
            _senia = senia;
            _fechaInicio = fechaInicio;
            _fechaFin = fechaFin;
            _estado = estado;
            _clienteDni = clienteDni;
            _vehiculoPatente = vehiculoPatente;

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
        public string Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public int ClienteDni
        {
            get { return _clienteDni; }
            set { _clienteDni = value; }
        }
        public string VehiculoPatente
        {
            get { return _vehiculoPatente; }
            set { _vehiculoPatente = value; }
        }
    }
}
