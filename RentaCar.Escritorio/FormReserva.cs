using RentaCar.Dominio;
using RentaCar.Dtos.Clientes;
using RentaCar.Dtos.EstadoReserva;
using RentaCar.Dtos.Reservas;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Escritorio.Helpers;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormReserva : Form
    {
        private readonly ReservaServicio _reservaServicio;
        private readonly ClienteServicio _clienteServicio;
        private readonly VehiculoServicio _vehiculoServicio;
        private readonly EstadoReservaServicio _estadoServicio;
        private readonly SeguroServicio _seguroServicio;
        private bool modoEdicion = false;
        private bool autoCompletar = false;
        private int idSeleccionado;
        private List<ReservaResponse> _reservas;
        private List<VehiculoResponse> _vehiculos;
        private List<ClienteResponse> _clientes;

        public FormReserva()
        {
            InitializeComponent();

            _reservaServicio = new ReservaServicio();
            _clienteServicio = new ClienteServicio();
            _vehiculoServicio = new VehiculoServicio();
            _estadoServicio = new EstadoReservaServicio();
            _seguroServicio = new SeguroServicio();
        }

        private async void FormReserva_Load(object sender, EventArgs e)
        {
            try
            {
                BloquearCampos(false);
                BloquearBotones(false);
                textBoxCliente.ReadOnly = true;
                textBoxVehiculo.ReadOnly = true;
                dtpFechaRetiro.MinDate = DateTime.Today;
                dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);
                textBoxPrecio.ReadOnly = true;

                await CargarVehiculos();
                await CargarClientes();
                await CargarReservas();
                await CargarEstados();
                await CargarSeguros();

            } catch
            {
                Dialogos.Error(Mensajes.ErrorDatos);
            }
            
        }

        private void BloquearCampos(bool estado)
        {
            textBoxCliente.Enabled = estado;
            textBoxVehiculo.Enabled = estado;
            dtpFechaRetiro.Enabled = estado;
            dtpFechaDevolucion.Enabled = estado;
            textBoxPrecio.Enabled = estado;
            numericUpDownSenia.Enabled = estado;
            comboBoxEstado.Enabled = estado;
            comboBoxSeguro.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }


        private async Task CargarVehiculos()
        {
            _vehiculos = await _vehiculoServicio.ObtenerTodos();

            dataGridViewVehiculo.AutoGenerateColumns = false;
            dataGridViewVehiculo.DataSource = _vehiculos;
        }

        private async Task CargarClientes()
        {
            _clientes = await _clienteServicio.ObtenerTodos();

            dataGridViewCliente.AutoGenerateColumns = false;
            dataGridViewCliente.DataSource = _clientes;
        }

        private async Task CargarReservas()
        {
            _reservas = await _reservaServicio.ObtenerTodos();

            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = _reservas;
        }

        private async Task CargarEstados()
        {
            var estados = await _estadoServicio.ObtenerTodos();

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }
        private async Task CargarSeguros()
        {
            var seguros = await _seguroServicio.ObtenerTodos();

            comboBoxSeguro.DataSource = seguros.Where(s => s.Activo).ToList();
            comboBoxSeguro.DisplayMember = "Nombre";
            comboBoxSeguro.ValueMember = "Id";
            comboBoxSeguro.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(true);
            BloquearBotones(true);
            modoEdicion = false;
            autoCompletar = true;
            dtpFechaRetiro.MinDate = DateTime.Today;
            dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);

        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewReserva.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("reserva"));
                return;
            }

            var reserva = (ReservaResponse)dataGridViewReserva.SelectedRows[0].DataBoundItem;

            idSeleccionado = reserva.Id;

            textBoxCliente.Text = reserva.ClienteDni.ToString();
            textBoxVehiculo.Text = reserva.VehiculoPatente;

            //dtpFechaRetiro.MinDate = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            //dtpFechaDevolucion.MinDate = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            dtpFechaRetiro.MinDate = DateTimePicker.MinimumDateTime;
            dtpFechaDevolucion.MinDate = DateTimePicker.MinimumDateTime;

            dtpFechaRetiro.Value = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            dtpFechaDevolucion.Value = reserva.FechaFin.ToDateTime(TimeOnly.MinValue);
            textBoxPrecio.Text = reserva.Precio.ToString();
            numericUpDownSenia.Value = reserva.Senia;
            comboBoxEstado.SelectedValue = reserva.EstadoId;
            comboBoxSeguro.SelectedValue = reserva.SeguroId;

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

            decimal precio = decimal.Parse(textBoxPrecio.Text);
            decimal senia = numericUpDownSenia.Value;

            if (string.IsNullOrWhiteSpace(textBoxCliente.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("cliente"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("vehículo"));
                return;
            }

            if (!modoEdicion && dtpFechaRetiro.Value.Date < DateTime.Today)
            {
                Dialogos.Error(Mensajes.FechaRetiroInvalida);
                return;
            }

            if (dtpFechaDevolucion.Value <= dtpFechaRetiro.Value)
            {
                Dialogos.Error(Mensajes.FechaInicioMayorFechaFin);
                return;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                Dialogos.Error(Mensajes.CampoVacio("estado"));
                return;
            }
            if (comboBoxSeguro.SelectedIndex == -1)
            {
                Dialogos.Error(Mensajes.CampoVacio("seguro"));
                return;
            }

            if (senia > precio)
            {
                Dialogos.Error("La seña no puede ser mayor al precio de la reserva.");
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
                        Precio = decimal.Parse(textBoxPrecio.Text),
                        Senia = numericUpDownSenia.Value,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        SeguroId = (int)comboBoxSeguro.SelectedValue
                    };

                    await _reservaServicio.Actualizar(idSeleccionado, updateRequest);

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
                        Precio = decimal.Parse(textBoxPrecio.Text),
                        Senia = numericUpDownSenia.Value,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        SeguroId = (int)comboBoxSeguro.SelectedValue
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

            if (!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("la reserva")))
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
        private async void dataGridViewVehiculo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxVehiculo.Text = ((VehiculoResponse)dataGridViewVehiculo.Rows[e.RowIndex].DataBoundItem).Patente;
            await ActualizarPrecio();
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
            textBoxPrecio.Text = "";
            numericUpDownSenia.Value = 0;
            comboBoxEstado.SelectedIndex = -1;
        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            switch (tabControl.SelectedTab.Name)
            {
                case "tabPageReserva":
                    FiltrarReservas(busqueda);
                    break;

                case "tabPageCliente":
                    FiltrarClientes(busqueda);
                    break;

                case "tabPageVehiculo":
                    FiltrarVehiculos(busqueda);
                    break;

            }

        }
        private void FiltrarReservas(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewReserva.DataSource = _reservas;
                return;
            }
            var filtrados = _reservas
                .Where(r =>
                    r.Id.ToString().Contains(busqueda) ||
                    r.ClienteDni.ToString().Contains(busqueda) ||
                    r.ClienteNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewReserva.DataSource = filtrados;
        }
        private void FiltrarVehiculos(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewVehiculo.DataSource = _vehiculos;
                return;
            }
            var filtrados = _vehiculos
                .Where(v =>
                    v.Patente.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    v.MarcaNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    v.ModeloNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewVehiculo.DataSource = filtrados;
        }
        private void FiltrarClientes(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewCliente.DataSource = _clientes;
                return;
            }
            var filtrados = _clientes
                .Where(c =>
                    c.Dni.ToString().Contains(busqueda) ||
                    c.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    c.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewCliente.DataSource = filtrados;
        }

        private void numericUpDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarVehiculos();
            await CargarClientes();
            await CargarReservas();
            await CargarEstados();
            await CargarSeguros();
        }
        private async Task ActualizarPrecio()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
                    return;

                if (comboBoxSeguro.SelectedValue == null)
                    return;

                int seguroId = (int)comboBoxSeguro.SelectedValue;

                decimal precio = await _reservaServicio.CalcularPrecio(
                    textBoxVehiculo.Text,
                    DateOnly.FromDateTime(dtpFechaRetiro.Value),
                    DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                    seguroId);

                textBoxPrecio.Text = precio.ToString("0.00");
            }
            catch
            {
                textBoxPrecio.Text = "";
            }
        }
        private async void comboBoxSeguro_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ActualizarPrecio();
        }
        private async void dateTimePickerFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaDevolucion.MinDate = dtpFechaRetiro.Value.AddDays(1);

            if (dtpFechaDevolucion.Value <= dtpFechaRetiro.Value)
            {
                dtpFechaDevolucion.Value = dtpFechaRetiro.Value.AddDays(1);
            }
            await ActualizarPrecio();
        }

        private async void dateTimePickerFechaFin_ValueChanged(object sender, EventArgs e)
        {
            await ActualizarPrecio();
        }
    }
}