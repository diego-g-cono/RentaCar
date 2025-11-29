namespace Escritorio
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehiculos frmVehiculos = new FrmVehiculos();
            frmVehiculos.MdiParent = this;
            frmVehiculos.Show();
        }
        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.MdiParent = this;
            frmClientes.Show();
        }
        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservas frmReservas = new FrmReservas();
            frmReservas.MdiParent = this;
            frmReservas.Show();
        }
    }
}
