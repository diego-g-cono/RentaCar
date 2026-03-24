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

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente form = new FormCliente();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }
        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReserva form = new FormReserva();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }
    }
}
