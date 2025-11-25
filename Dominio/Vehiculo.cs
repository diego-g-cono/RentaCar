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
        private string? _marca;
        private string? _modelo;
        private int? _anio;
        private string? _color;
        private string? _tipoCombustible;
        private int? _kilometraje;
        private string? _estado;
        public Vehiculo(string patente, string? tipoCombustible = null, int? kilometraje = null, string? estado = null, string? marca = null, string? modelo = null, int? anio = null, string? color = null)
        {
            _patente = patente;
            _kilometraje = kilometraje;
            _estado = estado;
            _marca = marca;
            _modelo = modelo;
            _anio = anio;
            _color = color;
            _tipoCombustible = tipoCombustible;
        }
        public string Patente
        {
            get { return _patente; }
            set { _patente = value; }
        }
        public string? Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string? Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }
        public int? Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }
        public string? Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public string? TipoCombustible
        {
            get { return _tipoCombustible; }
            set { _tipoCombustible = value; }
        }
        public int? Kilometraje
        {
            get { return _kilometraje; }
            set { _kilometraje = value; }
        }
        public string? Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }
    }
}
