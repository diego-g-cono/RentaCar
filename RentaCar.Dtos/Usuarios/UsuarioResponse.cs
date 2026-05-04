namespace RentaCar.Dtos.Usuarios
{
    public class UsuarioResponse
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string RolId { get; set; }
        public bool Activo { get; set; }
    }
}