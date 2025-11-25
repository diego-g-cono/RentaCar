namespace Dominio
{
    public abstract class Persona
    {
        private int _dni;
        private string? _nombre;
        private string? _apellido;
        private string? _direccion;
        private DateOnly? _fechaNacimiento;
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string? Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string? Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string? Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public DateOnly? FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        protected Persona(int dni, string? nombre=null, string? apellido = null, string? direccion = null, DateOnly? fechaNacimiento=null)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _fechaNacimiento = fechaNacimiento;
        }
    }
}

