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
        int filaEnEdicion = -1;
        private bool seleccionHabilitada = false;
        public FrmReservas()
        {
            InitializeComponent();
        }
        
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
                    var lista = db.Vehiculos
                        .Where(v => v.Estado == "Disponible")
                        .Select(v => new
                        {
                            Patente = v.Patente,
                            Marca = v.Marca,
                            Modelo = v.Modelo,
                            Anio = v.Anio,
                            Color = v.Color,
                            Kilometraje = v.Kilometraje,
                            Estado = v.Estado,
                            TipoCombustible = v.TipoCombustible
                        })
                        .ToList();

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
            if (string.IsNullOrWhiteSpace(txtBoxCliente.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBoxVehiculo.Text))
            {
                MessageBox.Show("Debe seleccionar un vehículo.");
                return;
            }

            if (cmbBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (filaEnEdicion == -1)
            {
                using (var db = new RentaCarDBContext())
                {
                    string patente = txtBoxVehiculo.Text.Trim();
                    var vehiculo = db.Vehiculos.FirstOrDefault(v => v.Patente == patente);
                    if (vehiculo == null)
                    {
                        MessageBox.Show("No existe un vehículo con esa patente");
                        return;
                    }

                    bool existeSolapamiento = db.Reservas.Any(r =>
                        r.VehiculoPatente == vehiculo.Patente &&
                        DateOnly.FromDateTime(dateTimeFechaRetiro.Value) <= r.FechaFin &&
                        DateOnly.FromDateTime(dateTimeFechaDevolucion.Value) >= r.FechaInicio &&
                        r.Estado != "Cancelada"
                    );

                    if (existeSolapamiento)
                    {
                        MessageBox.Show("El vehículo seleccionado ya está reservado en ese rango de fechas.");
                        return;
                    }

                    // Buscar cliente por DNI
                    int dni = int.Parse(txtBoxCliente.Text.Trim());
                    var cliente = db.Clientes.FirstOrDefault(c => c.Dni == dni);

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
                filaEnEdicion = -1;
            }
            else
            {
                
                using (var db = new RentaCarDBContext())
                {
                    string patente = txtBoxVehiculo.Text.Trim();
                    var vehiculo = db.Vehiculos.FirstOrDefault(v => v.Patente == patente);
                    var reservaActual = db.Reservas.ToList()[filaEnEdicion];

                    bool existeSolapamiento = db.Reservas.Any(r =>
                        r.VehiculoPatente == vehiculo.Patente &&
                        DateOnly.FromDateTime(dateTimeFechaRetiro.Value) <= r.FechaFin &&
                        DateOnly.FromDateTime(dateTimeFechaDevolucion.Value) >= r.FechaInicio &&
                        r.IdReserva != reservaActual.IdReserva &&
                        r.Estado != "Cancelada"
                    );

                    if (existeSolapamiento)
                    {
                        MessageBox.Show("El vehículo seleccionado ya está reservado en ese rango de fechas.");
                        return;
                    }

                    var reserva = db.Reservas.ToList()[filaEnEdicion];
                    reserva.Senia = (float?)numBoxSenia.Value;
                    reserva.Estado = cmbBoxEstado.SelectedItem?.ToString();
                    reserva.FechaInicio = DateOnly.FromDateTime(dateTimeFechaRetiro.Value);
                    reserva.FechaFin = DateOnly.FromDateTime(dateTimeFechaDevolucion.Value);
                    reserva.ClienteDni = int.Parse(txtBoxCliente.Text.Trim());
                    reserva.VehiculoPatente = txtBoxVehiculo.Text.Trim();
                    db.SaveChanges();
                }

                MessageBox.Show("Cambios actualizados correctamente");
                HabilitarCampos(false);
                LimpiarFormulario();
                seleccionHabilitada = false;
                filaEnEdicion = -1;
            }

            using (var db = new RentaCarDBContext())
            {
                var lista = db.Reservas.ToList();
                dataGridViewReservas.AutoGenerateColumns = false;
                dataGridViewReservas.DataSource = lista;
            }
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

            filaEnEdicion = -1;

            LimpiarFormulario();
            HabilitarCampos(false);
            seleccionHabilitada = false;
        }
        private void dateTimeFechaRetiro_ValueChanged(object sender, EventArgs e)
        {
            dateTimeFechaDevolucion.MinDate = dateTimeFechaRetiro.Value.AddDays(1);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar una reserva para editar.");
                return;
            }

            var fila = dataGridViewReservas.SelectedRows[0];
            filaEnEdicion = fila.Index;

            txtBoxCliente.Text = fila.Cells["ColumnaCliente"].Value?.ToString();
            txtBoxVehiculo.Text = fila.Cells["ColumnaVehiculo"].Value?.ToString();
            numBoxSenia.Value = Convert.ToDecimal(fila.Cells["ColumnaSenia"].Value);
            cmbBoxEstado.SelectedItem = fila.Cells["ColumnaEstadoR"].Value?.ToString();

            DateOnly fechaInicio = (DateOnly)fila.Cells["ColumnaFechaRetiro"].Value;
            dateTimeFechaRetiro.Value = fechaInicio.ToDateTime(TimeOnly.MinValue);

            DateOnly fechaFin = (DateOnly)fila.Cells["ColumnaFechaDevolucion"].Value;
            dateTimeFechaDevolucion.Value = fechaFin.ToDateTime(TimeOnly.MinValue);

            HabilitarCampos(true);
            seleccionHabilitada = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReservas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una reserva para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea cancelar esta reserva?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.No)
                return;

            // Obtengo el ID de la reserva seleccionada
            int idReserva = Convert.ToInt32(
                dataGridViewReservas.SelectedRows[0].Cells["ColumnaId"].Value
            );

            using (var db = new RentaCarDBContext())
            {
                var reserva = db.Reservas.FirstOrDefault(r => r.IdReserva == idReserva);

                if (reserva != null)
                {
                    reserva.Estado = "Cancelada";
                    db.SaveChanges();
                }
            }

            // Reflejar el cambio en la grilla
            dataGridViewReservas.SelectedRows[0].Cells["ColumnaEstadoR"].Value = "Cancelada";

            MessageBox.Show("Reserva cancelada correctamente");

            LimpiarFormulario();
            HabilitarCampos(false);
            seleccionHabilitada = false;
        }
    }
}
