using RentaCar.Dtos.Reservas;
using RentaCar.Dtos.Clientes;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Dtos.EstadoReserva;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormReserva : Form
    {
        private readonly ReservaServicio _reservaServicio;
        private readonly ClienteServicio _clienteServicio;
        private readonly VehiculoServicio _vehiculoServicio;
        private readonly EstadoReservaServicio _estadoServicio;

        public FormReserva()
        {
            InitializeComponent();

            _reservaServicio = new ReservaServicio();
            _clienteServicio = new ClienteServicio();
            _vehiculoServicio = new VehiculoServicio();
            _estadoServicio = new EstadoReservaServicio();
        }

        private async void FormReserva_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);

            await CargarVehiculos();
            await CargarClientes();
            await CargarReservas();
            await CargarEstados();
        }

        private void BloquearCampos(bool estado)
        {
            textBoxCliente.Enabled = estado;
            textBoxVehiculo.Enabled = estado;
            dtpFechaRetiro.Enabled = estado;
            dtpFechaDevolucion.Enabled = estado;
            numericUpDownPrecio.Enabled = estado;
            numericUpDownSenia.Enabled = estado;
            comboBoxEstado.Enabled = estado;
        }

        private async Task CargarVehiculos()
        {
            var vehiculos = await _vehiculoServicio.ObtenerTodos();

            dataGridViewVehiculo.AutoGenerateColumns = false;
            dataGridViewVehiculo.DataSource = vehiculos;
        }

        private async Task CargarClientes()
        {
            var clientes = await _clienteServicio.ObtenerTodos();

            dataGridViewCliente.AutoGenerateColumns = false;
            dataGridViewCliente.DataSource = clientes;
        }

        private async Task CargarReservas()
        {
            var reservas = await _reservaServicio.ObtenerTodos();

            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = reservas;
        }

        private async Task CargarEstados()
        {
            var estados = await _estadoServicio.ObtenerTodos();

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var request = new ReservaCreateRequest
                {
                    ClienteDni = int.Parse(textBoxCliente.Text),
                    VehiculoPatente = textBoxVehiculo.Text,
                    FechaInicio = DateOnly.FromDateTime(dtpFechaRetiro.Value),
                    FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                    Precio = numericUpDownPrecio.Value,
                    Senia = numericUpDownSenia.Value,
                    EstadoId = (int)comboBoxEstado.SelectedValue
                };

                await _reservaServicio.Agregar(request);

                MessageBox.Show("Reserva creada correctamente");

                await CargarReservas();
                BloquearCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserva.CurrentRow == null) return;

            var reserva = (ReservaResponse)dataGridViewReserva.CurrentRow.DataBoundItem;

            await _reservaServicio.Eliminar(reserva.Id);

            MessageBox.Show("Reserva eliminada");

            await CargarReservas();
        }

        private void textBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {
            textBoxVehiculo.Text = textBoxVehiculo.Text.ToUpper();
            textBoxVehiculo.SelectionStart = textBoxVehiculo.Text.Length;
        }
    }
}