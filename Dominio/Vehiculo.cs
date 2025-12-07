using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Vehiculo
    {
        private string _patente;
        private string _marca;
        private string _modelo;
        private int? _anio;
        private string? _color;
        private string? _tipo_combustible;
        private int? _kilometraje;
        private string _estado;
        public Vehiculo(string patente, string estado, string marca, string modelo, int? anio = null, string? color = null, string? tipo_combustible = null, int? kilometraje = null)
        {
            _patente = patente;
            _kilometraje = kilometraje;
            _estado = estado;
            _marca = marca;
            _modelo = modelo;
            _anio = anio;
            _color = color;
            _tipo_combustible = tipo_combustible;
        }
        public string patente
        {
            get { return _patente; }
            set { _patente = value; }
        }
        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public int? anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
        public string? color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string? tipo_combustible
        {
            get { return _tipo_combustible; }
            set { _tipo_combustible = value; }
        }
        public int? kilometraje
        {
            get { return _kilometraje; }
            set { _kilometraje = value; }
        }
        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
