using RentaCar.Dtos.Usuarios;
using RentaCar.Escritorio.Helpers;
using System.Net.Http.Json;

namespace RentaCar.Escritorio
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private async void buttonIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient
                {
                    BaseAddress = new Uri("https://localhost:7272/api/")
                };

                var request = new
                {
                    NombreUsuario = textBoxUsuario.Text,
                    Contrasenia = textBoxContrasena.Text
                };

                var response = await client.PostAsJsonAsync(
                    "usuarios/login",
                    request);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                var login =
                    await response.Content.ReadFromJsonAsync<LoginResponse>();
                
                Sesion.UsuarioActual = login;

                if (login.RolId != 1 && login.RolId != 2)
                {
                    MessageBox.Show(
                        "No tiene permisos para acceder al sistema.",
                        "Acceso denegado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var formPrincipal = new FormPrincipal();

                formPrincipal.Show();

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}