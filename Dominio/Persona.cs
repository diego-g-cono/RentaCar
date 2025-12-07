namespace Dominio
{
    public abstract class Persona
    {
        private int _dni;
        private string? _nombre;
        private string? _apellido;
        private string? _direccion;
        private DateOnly? _fecha_nacimiento;
        public int dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        public string? nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string? apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string? direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public DateOnly? fecha_nacimiento
        {
            get { return _fecha_nacimiento; }
            set { _fecha_nacimiento = value; }
        }
        protected Persona(int dni, string? nombre=null, string? apellido = null, string? direccion = null, DateOnly? fecha_nacimiento=null)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _fecha_nacimiento = fecha_nacimiento;
        }
    }
}

