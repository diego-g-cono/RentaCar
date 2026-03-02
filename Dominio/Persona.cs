namespace Dominio
{
    public abstract class Persona
    {
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        protected Persona(int dni, string nombre, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}