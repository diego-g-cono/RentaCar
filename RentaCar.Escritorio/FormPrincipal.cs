namespace RentaCar.Escritorio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            var mdi = this.Controls.OfType<MdiClient>().FirstOrDefault();

            if (mdi != null)
            {
                mdi.BackColor = SystemColors.Desktop;
                mdi.BackgroundImage = Properties.Resources.fondo;
                mdi.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVehiculo form = new FormVehiculo();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }
    }
}
