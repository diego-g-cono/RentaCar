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

        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDevoluciones form = new FormDevoluciones();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }

        private void alquileresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlquileres form = new FormAlquileres();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }

        private void conductoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConductores form = new FormConductores();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }

        private void tarifasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTarifas form = new FormTarifas();
            form.MdiParent = this;   // para que sea hijo del formulario principal
            form.Show();
        }
    }
}
