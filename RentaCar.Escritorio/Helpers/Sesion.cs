using RentaCar.Dtos.Usuarios;

namespace RentaCar.Escritorio.Helpers
{
    public static class Sesion
    {
        public static LoginResponse? UsuarioActual { get; set; }

        public static bool EstaLogueado =>
            UsuarioActual != null;

        public static void Cerrar()
        {
            UsuarioActual = null;
        }
    }
}