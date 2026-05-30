namespace RentaCar.Dtos.Usuarios
{
    public class RegistroClienteRequest
    {
        public int Dni { get; set; }

        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";

        public string Email { get; set; } = "";
        public string Telefono { get; set; } = "";

        public string NombreUsuario { get; set; } = "";
        public string Contrasenia { get; set; } = "";
    }
}