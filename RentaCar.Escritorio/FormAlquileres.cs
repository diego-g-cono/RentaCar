using RentaCar.Dominio;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{
    public partial class FormAlquileres : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly AlquilerRepositorio _repoAlquileres;
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly ClienteRepositorio _repoClientes;
        private readonly ConductorRepositorio _repoConductores;
        private readonly ReservaRepositorio _repoReserva;
        private bool modoEdicion = false;
        private bool autoCompletar = false;

        public FormAlquileres()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _repoAlquileres = new AlquilerRepositorio(_context);
            _repoVehiculos = new VehiculoRepositorio(_context);
            _repoClientes = new ClienteRepositorio(_context);
            _repoConductores = new ConductorRepositorio(_context);
            _repoReserva = new ReservaRepositorio(_context);

        }
        private void FormAlquileres_Load(object sender, EventArgs e)
        {
            CargarTablas();
            CargarEstados();
            BloquearCampos(false);
        }

        private void BloquearCampos(bool estado)
        {
            dtpFechaInicio.Enabled = estado;
            dtpFechaDevolucion.Enabled = estado;
            numericUpDownPrecio.Enabled = estado;
            comboBoxEstado.Enabled = estado;
        }

        
        
        private void LimpiarCampos()
        {
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaDevolucion.Value = DateTime.Now;
            textBoxVehiculo.Clear();
            numericUpDownPrecio.Value = 0;
            textBoxDniCliente.Clear();
            textBoxDniCond.Clear();
            textBoxReserva.Clear();
            comboBoxEstado.SelectedIndex = -1;
        }

        private void CargarEstados()
        {
            comboBoxEstado.DataSource = _context.EstadosAlquileres.ToList();
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }

        private void CargarTablas()
        {
            dataGridViewVehiculos.AutoGenerateColumns = false;
            dataGridViewVehiculos.DataSource = _repoVehiculos.ObtenerTodos();

            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.DataSource = _repoClientes.ObtenerTodos();

            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = _repoReserva.ObtenerTodos();

            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = _repoConductores.ObtenerTodos();

            dataGridViewAlquileres.AutoGenerateColumns = false;
            dataGridViewAlquileres.DataSource = _repoAlquileres.ObtenerTodos();

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            autoCompletar = true;
            modoEdicion = false;
            BloquearCampos(true);
            LimpiarCampos();

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {

            if (dataGridViewAlquileres.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún alquiler.");
                return;
            }

            BloquearCampos(true);

            Alquiler alquilerSeleccionado = (Alquiler)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;
            dtpFechaInicio.Value = alquilerSeleccionado.FechaInicio.ToDateTime(new TimeOnly());
            dtpFechaDevolucion.Value = alquilerSeleccionado.FechaFin.ToDateTime(new TimeOnly());
            textBoxVehiculo.Text = alquilerSeleccionado.VehiculoPatente.ToString();
            numericUpDownPrecio.Value = alquilerSeleccionado.Precio;
            textBoxDniCliente.Text = alquilerSeleccionado.ClienteId.ToString();
            textBoxDniCond.Text = alquilerSeleccionado.ConductorId.ToString();
            textBoxReserva.Text = alquilerSeleccionado.ReservaId.ToString();

            autoCompletar = true;
            modoEdicion = true;
      
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
            {
                MessageBox.Show("Debe seleccionar un vehículo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDniCliente.Text))
            {
                MessageBox.Show("Debe seleccionar un cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDniCond.Text))
            {
                MessageBox.Show("Debe seleccionar un conductor.");
                return;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (dtpFechaDevolucion.Value < dtpFechaInicio.Value)
            {
                MessageBox.Show("La fecha de devolución no puede ser menor a la fecha de inicio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxReserva.Text))
            {
                MessageBox.Show("Debe seleccionar una reserva.");
                return;
            }

            if (numericUpDownPrecio.Value <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a cero.");
                return;
            }


            var confirm = MessageBox.Show(
                    $"¿Estás seguro de guardar este alquiler?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );
    
                if (confirm != DialogResult.Yes)
                    return;

            Alquiler alquiler;

            if (modoEdicion)
            {
                alquiler = (Alquiler)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;
                alquiler.FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value);
                alquiler.FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value);
                alquiler.VehiculoPatente = textBoxVehiculo.Text;
                alquiler.Precio = numericUpDownPrecio.Value;
                alquiler.ClienteId = int.Parse(textBoxDniCliente.Text);
                alquiler.ConductorId = int.Parse(textBoxDniCond.Text);
                alquiler.ReservaId = int.Parse(textBoxReserva.Text);
                alquiler.EstadoId = (int)comboBoxEstado.SelectedValue;
                
                _repoAlquileres.Actualizar(alquiler);
                MessageBox.Show("Alquiler actualizado correctamente.");

            } else
            {
                alquiler = new Alquiler()
                {
                    FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                    FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                    VehiculoPatente = textBoxVehiculo.Text,
                    Precio = numericUpDownPrecio.Value,
                    ClienteId = int.Parse(textBoxDniCliente.Text),
                    ConductorId = int.Parse(textBoxDniCond.Text),
                    ReservaId = int.Parse(textBoxReserva.Text),
                    EstadoId = (int)comboBoxEstado.SelectedValue
                };
                _repoAlquileres.Agregar(alquiler);
                MessageBox.Show("Alquiler agregado correctamente.");
            }

            _context.SaveChanges();

            CargarTablas();
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlquileres.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún alquiler.");
                return;
            }

            var confirm = MessageBox.Show(
                    $"¿Estás seguro de eliminar este alquiler?",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );
    
                if (confirm != DialogResult.Yes)
                    return;

                var alquilerSeleccionado = (Alquiler)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;
                _repoAlquileres.Eliminar(alquilerSeleccionado.Id);

            CargarTablas();
            LimpiarCampos();
        }

        private void dataGridViewVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                DataGridViewRow row = dataGridViewVehiculos.Rows[e.RowIndex];
                textBoxVehiculo.Text = row.Cells["ColumnPatente"].Value.ToString();
            }
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];
                textBoxDniCliente.Text = row.Cells["ColumnDni"].Value.ToString();
            }
        }

        private void dataGridViewConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                DataGridViewRow row = dataGridViewConductores.Rows[e.RowIndex];
                textBoxDniCond.Text = row.Cells["ColumnDniCond"].Value.ToString();
            }
        }

        private void dataGridViewReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                DataGridViewRow row = dataGridViewReserva.Rows[e.RowIndex];
                textBoxReserva.Text = row.Cells["ColumnId"].Value.ToString();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }
    }
}
