namespace RentaCar.Dtos.Usuarios
{
    public class UsuarioCreateRequest
    {
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public int RolId { get; set; }
        public bool Activo { get; set; }
    }
}