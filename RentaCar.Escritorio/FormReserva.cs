using RentaCar.Dtos.Reservas;
using RentaCar.Dtos.Clientes;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Dtos.EstadoReserva;
using RentaCar.Escritorio.Servicios;
using RentaCar.Escritorio.Helpers;

namespace RentaCar.Escritorio
{
    public partial class FormReserva : Form
    {
        private readonly ReservaServicio _reservaServicio;
        private readonly ClienteServicio _clienteServicio;
        private readonly VehiculoServicio _vehiculoServicio;
        private readonly EstadoReservaServicio _estadoServicio;
        private bool modoEdicion = false;
        private bool autoCompletar = false;

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
            BloquearBotones(false);
            textBoxCliente.ReadOnly = true;
            textBoxVehiculo.ReadOnly = true;
            dtpFechaRetiro.MinDate = DateTime.Today;
            dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);

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

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
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
            BloquearBotones(true);
            modoEdicion = false;
            autoCompletar = true;
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserva.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("reserva"));
                return;
            }

            var reserva = (ReservaResponse)dataGridViewReserva.SelectedRows[0].DataBoundItem;

            textBoxCliente.Text = reserva.ClienteDni.ToString();
            textBoxVehiculo.Text = reserva.VehiculoPatente;
            dtpFechaRetiro.Value = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            dtpFechaDevolucion.Value = reserva.FechaFin.ToDateTime(TimeOnly.MinValue);
            numericUpDownPrecio.Value = reserva.Precio;
            numericUpDownSenia.Value = reserva.Senia;
            comboBoxEstado.SelectedValue = reserva.EstadoId;

            modoEdicion = true;
            autoCompletar = true;
            BloquearCampos(true);
            BloquearBotones(true);
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            /*
            var resultado = MessageBox.Show(
                "Se perderán los datos ingresados. ¿Deseás continuar?",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            */
            if (!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
            {
                return;
            }

                LimpiarCampos();
                modoEdicion = false;
                autoCompletar = false;
                BloquearCampos(false);
                BloquearBotones(false);
            
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxCliente.Text)){
                Dialogos.Error(Mensajes.CampoVacio("cliente"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("vehículo"));
                return;
            }
            
            if(dtpFechaRetiro.Value.Date < DateTime.Today)
            {
                Dialogos.Error(Mensajes.FechaRetiroInvalida);
                return;
            }

            if (dtpFechaDevolucion.Value <= dtpFechaRetiro.Value)
            {
                Dialogos.Error(Mensajes.FechaInicioMayorFechaFin);
                return;
            }

            if(comboBoxEstado.SelectedIndex == -1)
            {
                Dialogos.Error(Mensajes.CampoVacio("estado"));
                return;
            }

            if (!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("Reserva")))
            {
                return;
            }

            try
            {
                if (modoEdicion)
                {
                    var reserva = (ReservaResponse)dataGridViewReserva.SelectedRows[0].DataBoundItem;

                    var updateRequest = new ReservaUpdateRequest
                    {
                        ClienteDni = int.Parse(textBoxCliente.Text),
                        VehiculoPatente = textBoxVehiculo.Text,
                        FechaInicio = DateOnly.FromDateTime(dtpFechaRetiro.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        Precio = numericUpDownPrecio.Value,
                        Senia = numericUpDownSenia.Value,
                        EstadoId = (int)comboBoxEstado.SelectedValue
                    };

                    await _reservaServicio.Actualizar(reserva.Id, updateRequest);

                    Dialogos.Info(Mensajes.ExitoEdicion("Reserva"));
                }
                else
                {
                    var createRequest = new ReservaCreateRequest
                    {
                        ClienteDni = int.Parse(textBoxCliente.Text),
                        VehiculoPatente = textBoxVehiculo.Text,
                        FechaInicio = DateOnly.FromDateTime(dtpFechaRetiro.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        Precio = numericUpDownPrecio.Value,
                        Senia = numericUpDownSenia.Value,
                        EstadoId = (int)comboBoxEstado.SelectedValue
                    };

                    await _reservaServicio.Agregar(createRequest);

                    Dialogos.Info(Mensajes.ExitoGuardado("Reserva"));
                }

                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
                await CargarReservas();
                modoEdicion = false;
                autoCompletar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}");
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserva.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("reserva"));
                return;
            }
            
            if(!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("la reserva")))
            {
                return;
            }

            var reserva = (ReservaResponse)dataGridViewReserva.SelectedRows[0].DataBoundItem;

            await _reservaServicio.Eliminar(reserva.Id);

            Dialogos.Info(Mensajes.ExitoEliminacion("Reserva"));

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
        private void dataGridViewVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxVehiculo.Text = ((VehiculoResponse)dataGridViewVehiculo.Rows[e.RowIndex].DataBoundItem).Patente;
        }

        private void dataGridViewCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxCliente.Text = ((ClienteResponse)dataGridViewCliente.Rows[e.RowIndex].DataBoundItem).Dni.ToString();
        }
        private void LimpiarCampos()
        {
            textBoxCliente.Clear();
            textBoxVehiculo.Clear();
            dtpFechaRetiro.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(1);
            numericUpDownPrecio.Value = 0;
            numericUpDownSenia.Value = 0;
            comboBoxEstado.SelectedIndex = -1;
        }
        private void dtpFechaRetiro_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaDevolucion.MinDate = dtpFechaRetiro.Value.AddDays(1);

            if (dtpFechaDevolucion.Value <= dtpFechaRetiro.Value)
            {
                dtpFechaDevolucion.Value = dtpFechaRetiro.Value.AddDays(1);
            }
        }

    }
}