namespace RentaCar.Dtos.Usuarios
{
    public class UsuarioUpdateRequest
    {
        public string NombreUsuario { get; set; }
        public string? Contrasenia { get; set; }
        public string RolId { get; set; }
        public bool Activo { get; set; }
    }
}