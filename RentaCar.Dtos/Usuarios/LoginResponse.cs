namespace RentaCar.Dtos.Usuarios
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public int RolId { get; set; }
        public string Token { get; set; }
        public bool Activo { get; set; }
        public int ClienteDni { get; set; }
        public string ClienteNombre { get; set; } = string.Empty;
        public string ClienteApellido { get; set; } = string.Empty;
    }
}