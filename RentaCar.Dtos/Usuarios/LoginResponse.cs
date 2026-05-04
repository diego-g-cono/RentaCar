namespace RentaCar.Dtos.Usuarios
{
    public class LoginResponse
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string RolId { get; set; }
        public string Token { get; set; }
        public bool Activo { get; set; }
    }
}