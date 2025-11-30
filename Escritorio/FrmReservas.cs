using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
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
        private bool seleccionHabilitada = false;
        
        private void FrmReservas_Load(object sender, EventArgs e)
        {
            HabilitarCampos(false);
            dateTimeFechaRetiro.MinDate = DateTime.Today;
            dateTimeFechaDevolucion.MinDate = dateTimeFechaRetiro.Value.AddDays(1);
            cmbBoxEstado.Items.AddRange(new string[]
            {
                "Confirmada",
                "Pendiente",
                "Cancelada"
            });
            using (var db = new RentaCarDBContext())
            {
                var lista = db.Reservas.ToList();
                dataGridViewReservas.AutoGenerateColumns = false;
                dataGridViewReservas.DataSource = lista;
            }
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
            else if (tabControlReservas.SelectedTab == tabPageReservas)
            {
                using (var db = new RentaCarDBContext())
                {
                    var lista = db.Reservas.ToList();
                    dataGridViewReservas.AutoGenerateColumns = false;
                    dataGridViewReservas.DataSource = lista;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimpiarFormulario();
            seleccionHabilitada = true;
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!seleccionHabilitada)return;
            // Evitar error si se hace doble clic en el encabezado
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridViewClientes.Rows[e.RowIndex];
            string dni = fila.Cells["ColumnaDNI"].Value.ToString(); // Ajustar al nombre real de la columna

            txtBoxCliente.Text = dni;
        }
        private void dataGridViewVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!seleccionHabilitada) return;
            // Evitar error si se hace doble clic en el encabezado
            if (e.RowIndex < 0) return;

            DataGridViewRow fila = dataGridViewVehiculos.Rows[e.RowIndex];
            string patente = fila.Cells["ColumnaPatente"].Value.ToString();

            txtBoxVehiculo.Text = patente;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new RentaCarDBContext())
            {
                string patente = txtBoxVehiculo.Text.Trim();
                // Buscar vehículo
                var vehiculo = db.Vehiculos.FirstOrDefault(v => v.Patente == patente);
                if (vehiculo == null)
                {
                    MessageBox.Show("No existe un vehículo con esa patente");
                    return;
                }

                //Validar superposición de reservas
                bool existeSolapamiento = db.Reservas.Any(r =>
                    r.VehiculoPatente == vehiculo.Patente &&
                    DateOnly.FromDateTime(dateTimeFechaRetiro.Value) <= r.FechaFin &&
                    DateOnly.FromDateTime(dateTimeFechaDevolucion.Value) >= r.FechaInicio &&
                    r.Estado != "Cancelada"     // Opcional: ignorar reservas canceladas
                );

                if (existeSolapamiento)
                {
                    MessageBox.Show("El vehículo seleccionado ya está reservado en ese rango de fechas.");
                    return;
                }

                // Buscar cliente por DNI
                int dni = int.Parse(txtBoxCliente.Text.Trim());
                var cliente = db.Clientes.FirstOrDefault(c => c.Dni == dni);

                if (cliente == null)
                {
                    MessageBox.Show("No existe un cliente con ese DNI");
                    return;
                }

              

                if (vehiculo == null)
                {
                    MessageBox.Show("No existe un vehículo con esa patente");
                    return;
                }
                // Crear reserva y asignar objetos encontrados
                var reserva = new Reserva(
                    clienteDni: dni,
                    vehiculoPatente: patente,
                    fechaInicio: DateOnly.FromDateTime(dateTimeFechaRetiro.Value),
                    fechaFin: DateOnly.FromDateTime(dateTimeFechaDevolucion.Value),
                    estado: cmbBoxEstado.SelectedItem?.ToString(),
                    senia: (float?)numBoxSenia.Value
                );

                db.Reservas.Add(reserva);
                db.SaveChanges();
            }

            MessageBox.Show("Reserva guardada correctamente");

            HabilitarCampos(false);
            LimpiarFormulario();
            seleccionHabilitada = false;
        }
        private void LimpiarFormulario()
        {
            foreach (Control ctrl in grBoxReservas.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
                else if (ctrl is NumericUpDown numCtrl)
                    numCtrl.Value = numCtrl.Minimum;
                else if (ctrl is ComboBox comboCtrl)
                    comboCtrl.SelectedIndex = -1;
            }
            dateTimeFechaRetiro.MinDate = DateTime.Today;
            dateTimeFechaDevolucion.MinDate = dateTimeFechaRetiro.Value.AddDays(1);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea cancelar?\nSe perderán los cambios no guardados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            //filaEnEdicion = -1;

            LimpiarFormulario();
            HabilitarCampos(false);
            seleccionHabilitada = false;
        }
        private void dateTimeFechaRetiro_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFechaDevolucion.MinDate = dateTimeFechaRetiro.Value.AddDays(1);
        }
    }
}
