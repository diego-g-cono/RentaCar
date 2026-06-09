using RentaCar.Escritorio.Helpers;

namespace RentaCar.Escritorio
{
    public partial class FormLogin : Form
    {
       
        public FormLogin()
        {
            InitializeComponent();
            
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            





            var formPrincipal = new FormPrincipal();
            formPrincipal.Show();
            this.Hide();
        }
    }
}