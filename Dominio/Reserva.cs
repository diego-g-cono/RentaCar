using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Reserva
    {
        private int _id_reserva;
        // Foreign keys
        public int _cliente_dni;
        public string _vehiculo_patente;

        private float? _senia;
        private DateOnly _fecha_inicio;
        private DateOnly _fecha_fin;
        private string _estado;

        public Reserva(int cliente_dni, string vehiculo_patente, DateOnly fecha_inicio, DateOnly fecha_fin, string estado, float? senia = null)
        {
            _senia = senia;
            _fecha_inicio = fecha_inicio;
            _fecha_fin = fecha_fin;
            _estado = estado;
            _cliente_dni = cliente_dni;
            _vehiculo_patente = vehiculo_patente;
        }
        public int id_reserva
        {
            get { return _id_reserva; }
            set { _id_reserva = value; }
        }
        public float? senia
        {
            get { return _senia; }
            set { _senia = value; }
        }
        public DateOnly fecha_inicio
        {
            get { return _fecha_inicio; }
            set { _fecha_inicio = value; }
        }
        public DateOnly fecha_fin
        {
            get { return _fecha_fin; }
            set { _fecha_fin = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
        public int cliente_dni
        {
            get { return _cliente_dni; }
            set { _cliente_dni = value; }
        }
        public string vehiculo_patente
        {
            get { return _vehiculo_patente; }
            set { _vehiculo_patente = value; }
        }
    }
}
