using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmReservas : Form
    {
        public FrmReservas()
        {
            InitializeComponent();
        }
        
        private void FrmReservas_Load(object sender, EventArgs e)
        {
            HabilitarCampos(false);
        }
        private void HabilitarCampos(bool activo)
        {
            foreach (Control ctrl in grBoxReservas.Controls)
            {
                if (ctrl is TextBox || ctrl is NumericUpDown || ctrl is ComboBox || ctrl is DateTimePicker)
                    ctrl.Enabled = activo;
            }
            txtBoxCliente.ReadOnly = true;
            txtBoxVehiculo.ReadOnly = true;
        }

        private void tabControlReservas_Click(object sender, EventArgs e)
        {
            if (tabControlReservas.SelectedTab == tabPageVehiculos)
            {
                using (var db = new RentaCarDBContext())
                {
                    var lista = db.Vehiculos.ToList();
                    dataGridViewVehiculos.AutoGenerateColumns = false;
                    dataGridViewVehiculos.DataSource = lista;
                }
            }
            else if (tabControlReservas.SelectedTab == tabPageClientes)
            {
                using (var db = new RentaCarDBContext())
                {
                    var lista = db.Clientes.ToList();
                    dataGridViewClientes.AutoGenerateColumns = false;
                    dataGridViewClientes.DataSource = lista;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar error si se hace doble clic en el encabezado
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridViewClientes.Rows[e.RowIndex];
            string dni = fila.Cells["ColumnaDNI"].Value.ToString(); // Ajustar al nombre real de la columna

            txtBoxCliente.Text = dni;
        }
        private void dataGridViewVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar error si se hace doble clic en el encabezado
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridViewVehiculos.Rows[e.RowIndex];
            string patente = fila.Cells["ColumnaPatente"].Value.ToString(); // Ajustar al nombre real de la columna

            txtBoxVehiculo.Text = patente;
        }
    }
}
