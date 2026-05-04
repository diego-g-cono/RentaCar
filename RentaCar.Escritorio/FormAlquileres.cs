using RentaCar.Dtos.Alquileres;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Dtos.Clientes;
using RentaCar.Dtos.Conductores;
using RentaCar.Dtos.Reservas;
using RentaCar.Dtos.EstadoAlquiler;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormAlquileres : Form
    {
        private readonly AlquilerServicio _alquilerServicio;
        private readonly VehiculoServicio _vehiculoServicio;
        private readonly ClienteServicio _clienteServicio;
        private readonly ConductorServicio _conductorServicio;
        private readonly ReservaServicio _reservaServicio;
        private readonly EstadoAlquilerServicio _estadoServicio;

        private bool modoEdicion = false;
        private bool autoCompletar = false;
        private int alquilerIdSeleccionado;

        public FormAlquileres()
        {
            InitializeComponent();

            _alquilerServicio = new AlquilerServicio();
            _vehiculoServicio = new VehiculoServicio();
            _clienteServicio = new ClienteServicio();
            _conductorServicio = new ConductorServicio();
            _reservaServicio = new ReservaServicio();
            _estadoServicio = new EstadoAlquilerServicio();
        }

        private async void FormAlquileres_Load(object sender, EventArgs e)
        {
            await CargarTodo();
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

        private async Task CargarTodo()
        {
            dataGridViewVehiculos.DataSource = await _vehiculoServicio.ObtenerTodos();
            dataGridViewClientes.DataSource = await _clienteServicio.ObtenerTodos();
            dataGridViewConductores.DataSource = await _conductorServicio.ObtenerTodos();
            dataGridViewReserva.DataSource = await _reservaServicio.ObtenerTodos();
            dataGridViewAlquileres.DataSource = await _alquilerServicio.ObtenerTodos();

            comboBoxEstado.DataSource = await _estadoServicio.ObtenerTodos();
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
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

            var alquiler = (AlquilerResponse)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;

            alquilerIdSeleccionado = alquiler.Id;

            dtpFechaInicio.Value = alquiler.FechaInicio.ToDateTime(new TimeOnly());
            dtpFechaDevolucion.Value = alquiler.FechaFin.ToDateTime(new TimeOnly());
            textBoxVehiculo.Text = alquiler.VehiculoPatente;
            numericUpDownPrecio.Value = alquiler.Precio;
            textBoxDniCliente.Text = alquiler.ClienteDni.ToString();
            textBoxDniCond.Text = alquiler.ConductorDni.ToString();
            textBoxReserva.Text = alquiler.ReservaId?.ToString();

            comboBoxEstado.SelectedValue = alquiler.EstadoId;

            modoEdicion = true;
            autoCompletar = true;
            BloquearCampos(true);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // VALIDACIONES (igual que antes)
                if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
                    throw new Exception("Debe seleccionar un vehículo.");

                if (string.IsNullOrWhiteSpace(textBoxDniCliente.Text))
                    throw new Exception("Debe seleccionar un cliente.");

                if (string.IsNullOrWhiteSpace(textBoxDniCond.Text))
                    throw new Exception("Debe seleccionar un conductor.");

                if (comboBoxEstado.SelectedIndex == -1)
                    throw new Exception("Debe seleccionar un estado.");

                if (dtpFechaDevolucion.Value < dtpFechaInicio.Value)
                    throw new Exception("La fecha de devolución no puede ser menor.");

                if (numericUpDownPrecio.Value <= 0)
                    throw new Exception("El precio debe ser mayor a cero.");

                var confirm = MessageBox.Show("¿Guardar alquiler?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm != DialogResult.Yes) return;

                if (modoEdicion)
                {
                    var update = new AlquilerUpdateRequest
                    {
                        FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        VehiculoPatente = textBoxVehiculo.Text,
                        Precio = numericUpDownPrecio.Value,
                        ClienteDni = int.Parse(textBoxDniCliente.Text),
                        ConductorDni = int.Parse(textBoxDniCond.Text),
                        ReservaId = string.IsNullOrWhiteSpace(textBoxReserva.Text) ? null : int.Parse(textBoxReserva.Text),
                        EstadoId = (int)comboBoxEstado.SelectedValue
                    };

                    await _alquilerServicio.Actualizar(alquilerIdSeleccionado, update);
                    MessageBox.Show("Alquiler actualizado");
                }
                else
                {
                    var create = new AlquilerCreateRequest
                    {
                        FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        VehiculoPatente = textBoxVehiculo.Text,
                        Precio = numericUpDownPrecio.Value,
                        ClienteDni = int.Parse(textBoxDniCliente.Text),
                        ConductorDni = int.Parse(textBoxDniCond.Text),
                        ReservaId = string.IsNullOrWhiteSpace(textBoxReserva.Text) ? null : int.Parse(textBoxReserva.Text),
                        EstadoId = (int)comboBoxEstado.SelectedValue
                    };

                    await _alquilerServicio.Agregar(create);
                    MessageBox.Show("Alquiler creado");
                }

                await CargarTodo();
                LimpiarCampos();
                BloquearCampos(false);
                autoCompletar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlquileres.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún alquiler.");
                return;
            }

            var alquiler = (AlquilerResponse)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            await _alquilerServicio.Eliminar(alquiler.Id);

            await CargarTodo();
            LimpiarCampos();
        }

        private void dataGridViewVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxVehiculo.Text = dataGridViewVehiculos.Rows[e.RowIndex].Cells["ColumnPatente"].Value.ToString();
        }

        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxDniCliente.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnDNI"].Value.ToString();
        }

        private void dataGridViewConductores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxDniCond.Text = dataGridViewConductores.Rows[e.RowIndex].Cells["ColumnDniCond"].Value.ToString();
        }

        private void dataGridViewReserva_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxReserva.Text = dataGridViewReserva.Rows[e.RowIndex].Cells["ColumnId"].Value.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }
    }
}