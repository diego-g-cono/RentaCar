using RentaCar.Dominio;
using RentaCar.Dtos.Alquileres;
using RentaCar.Dtos.Clientes;
using RentaCar.Dtos.Conductores;
using RentaCar.Dtos.EstadoAlquiler;
using RentaCar.Dtos.Reservas;
using RentaCar.Dtos.Vehiculos;
using RentaCar.Escritorio.Helpers;
using RentaCar.Escritorio.Servicios;
using System.Windows.Forms;

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
        private readonly SeguroServicio _seguroServicio;
        private List<AlquilerResponse> _alquileres;
        private List<VehiculoResponse> _vehiculos;
        private List<ConductorResponse> _conductores;
        private List<ReservaResponse> _reservas;
        private List<ClienteResponse> _clientes;

        private bool modoEdicion = false;
        private bool autoCompletar = false;
        private int alquilerIdSeleccionado;
        private TabPage _tabReserva;
        private TabPage _tabVehiculo;
        private TabPage _tabCliente;

        public FormAlquileres()
        {
            InitializeComponent();

            _alquilerServicio = new AlquilerServicio();
            _vehiculoServicio = new VehiculoServicio();
            _clienteServicio = new ClienteServicio();
            _conductorServicio = new ConductorServicio();
            _reservaServicio = new ReservaServicio();
            _estadoServicio = new EstadoAlquilerServicio();
            _seguroServicio = new SeguroServicio();
            _tabReserva = tabPage4;
            _tabVehiculo = tabPage2;
            _tabCliente = tabPage5;
        }

        private async void FormAlquileres_Load(object sender, EventArgs e)
        {
            try
            {
                await CargarTodo();

                BloquearCampos(false);
                BloquearBotones(false);

                dtpFechaInicio.MinDate = DateTime.Today;
                dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);

                radioButtonSReserva.Checked = true;

                CambiarModoAlquiler();

            }catch {
                Dialogos.Error(Mensajes.ErrorDatos);
            }
        }

        private void BloquearCampos(bool estado)
        {
            dtpFechaInicio.Enabled = estado;
            dtpFechaDevolucion.Enabled = estado;
            textBoxPrecio.Enabled = estado;
            comboBoxEstado.Enabled = estado;
            comboBoxSeguro.Enabled = estado;
            radioButtonCReserva.Enabled = estado;
            radioButtonSReserva.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            // Restaurar fechas mínimas
            dtpFechaInicio.MinDate = DateTime.Today;
            dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);

            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaDevolucion.Value = DateTime.Today.AddDays(1);

            textBoxVehiculo.Clear();
            textBoxPrecio.Text = "0";
            textBoxDniCliente.Clear();
            textBoxDniCond.Clear();
            textBoxReserva.Clear();
            comboBoxEstado.SelectedIndex = -1;
            comboBoxSeguro.SelectedIndex = -1;
            textBoxSaldo.Clear();
        }

        private async Task CargarTodo()
        {
            _vehiculos = await _vehiculoServicio.ObtenerTodos();
            dataGridViewVehiculos.AutoGenerateColumns = false;
            dataGridViewVehiculos.DataSource = await _vehiculoServicio.ObtenerTodos();

            _clientes = await _clienteServicio.ObtenerTodos();
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.DataSource = await _clienteServicio.ObtenerTodos();

            _conductores = await _conductorServicio.ObtenerTodos();
            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = await _conductorServicio.ObtenerTodos();

            _reservas = (await _reservaServicio.ObtenerTodos())
                        .Where(r => r.EstadoId == 1) // Confirmada
                        .ToList();

            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = _reservas;


            _alquileres = await _alquilerServicio.ObtenerTodos();
            dataGridViewAlquileres.AutoGenerateColumns = false;
            dataGridViewAlquileres.DataSource = _alquileres;

            comboBoxEstado.DataSource = await _estadoServicio.ObtenerTodos();
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;

            var seguros = await _seguroServicio.ObtenerTodos();

            comboBoxSeguro.DataSource = seguros.Where(s => s.Activo).ToList();
            comboBoxSeguro.DisplayMember = "Nombre";
            comboBoxSeguro.ValueMember = "Id";
            comboBoxSeguro.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            dtpFechaInicio.MinDate = DateTime.Today;
            dtpFechaDevolucion.MinDate = DateTime.Today.AddDays(1);
            autoCompletar = true;
            modoEdicion = false;
            BloquearCampos(true);
            BloquearBotones(true);
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewAlquileres.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("alquiler"));
                return;
            }

            var alquiler = (AlquilerResponse)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;

            alquilerIdSeleccionado = alquiler.Id;

            dtpFechaInicio.MinDate = alquiler.FechaInicio.ToDateTime(new TimeOnly());
            dtpFechaDevolucion.MinDate = alquiler.FechaInicio.ToDateTime(new TimeOnly());

            dtpFechaInicio.Value = alquiler.FechaInicio.ToDateTime(new TimeOnly());
            dtpFechaDevolucion.Value = alquiler.FechaFin.ToDateTime(new TimeOnly());
            textBoxVehiculo.Text = alquiler.VehiculoPatente;
            textBoxPrecio.Text = alquiler.Precio.ToString();
            textBoxDniCliente.Text = alquiler.ClienteDni.ToString();
            textBoxDniCond.Text = alquiler.ConductorDni.ToString();
            textBoxReserva.Text = alquiler.ReservaId?.ToString();

            comboBoxEstado.SelectedValue = alquiler.EstadoId;
            comboBoxSeguro.SelectedValue = alquiler.SeguroId;

            modoEdicion = true;
            autoCompletar = true;
            BloquearCampos(true);
            BloquearBotones(true);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("vehículo"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDniCliente.Text))
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("cliente"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDniCond.Text))
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("conductor"));
                return;
            }

            if (comboBoxEstado.SelectedIndex == -1)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("estado"));
                return;
            }

            if (comboBoxSeguro.SelectedValue == null)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("seguro"));
                return;
            }

            if (dtpFechaDevolucion.Value < dtpFechaInicio.Value)
            {
                Dialogos.Error(Mensajes.FechaInicioMayorFechaFin);
                return;
            }

            if (!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("alquiler")))
            {
                return;
            }

            try
            {
                int? reservaId = null;

                if (radioButtonCReserva.Checked)
                {
                    reservaId = int.Parse(textBoxReserva.Text);
                }

                if (modoEdicion)
                {
                    var update = new AlquilerUpdateRequest
                    {
                        FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        VehiculoPatente = textBoxVehiculo.Text,
                        Precio = decimal.Parse(textBoxPrecio.Text),
                        ClienteDni = int.Parse(textBoxDniCliente.Text),
                        ConductorDni = int.Parse(textBoxDniCond.Text),
                        ReservaId = reservaId,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        SeguroId = (int)comboBoxSeguro.SelectedValue
                    };

                    await _alquilerServicio.Actualizar(alquilerIdSeleccionado, update);

                    Dialogos.Info(Mensajes.ExitoEdicion("Alquiler"));
                    if (reservaId.HasValue)
                    {
                        var reserva = _reservas.First(r => r.Id == reservaId.Value);

                        var updateReserva = new ReservaUpdateRequest
                        {
                            FechaInicio = reserva.FechaInicio,
                            FechaFin = reserva.FechaFin,
                            VehiculoPatente = reserva.VehiculoPatente,
                            ClienteDni = reserva.ClienteDni,
                            Precio = reserva.Precio,
                            Senia = reserva.Senia,
                            EstadoId = 4, // Finalizada
                            SeguroId = reserva.SeguroId
                        };

                        await _reservaServicio.Actualizar(reservaId.Value, updateReserva);
                    }
                }
                else
                {
                    var create = new AlquilerCreateRequest
                    {
                        FechaInicio = DateOnly.FromDateTime(dtpFechaInicio.Value),
                        FechaFin = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        VehiculoPatente = textBoxVehiculo.Text,
                        Precio = decimal.Parse(textBoxPrecio.Text),
                        ClienteDni = int.Parse(textBoxDniCliente.Text),
                        ConductorDni = int.Parse(textBoxDniCond.Text),
                        ReservaId = reservaId,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        SeguroId = (int)comboBoxSeguro.SelectedValue
                    };

                    await _alquilerServicio.Agregar(create);

                    Dialogos.Info(Mensajes.ExitoGuardado("Alquiler"));

                    if (reservaId.HasValue)
                    {
                        var reserva = _reservas.First(r => r.Id == reservaId.Value);

                        var updateReserva = new ReservaUpdateRequest
                        {
                            FechaInicio = reserva.FechaInicio,
                            FechaFin = reserva.FechaFin,
                            VehiculoPatente = reserva.VehiculoPatente,
                            ClienteDni = reserva.ClienteDni,
                            Precio = reserva.Precio,
                            Senia = reserva.Senia,
                            EstadoId = 4, // Finalizada
                            SeguroId = reserva.SeguroId
                        };

                        await _reservaServicio.Actualizar(reservaId.Value, updateReserva);
                    }
                }

                await CargarTodo();

                LimpiarCampos();

                BloquearCampos(false);
                BloquearBotones(false);

                autoCompletar = false;
                modoEdicion = false;
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
                Dialogos.Error(Mensajes.SeleccioneEntidad("alquiler"));
                return;
            }

            var alquiler = (AlquilerResponse)dataGridViewAlquileres.SelectedRows[0].DataBoundItem;

            //var confirm = MessageBox.Show("¿Eliminar?", "Confirmar", MessageBoxButtons.YesNo);
            //if (confirm != DialogResult.Yes) return;

            if (!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("alquiler")))
            {
                return;
            }

            await _alquilerServicio.Eliminar(alquiler.Id);

            await CargarTodo();
            LimpiarCampos();

            Dialogos.Info(Mensajes.ExitoEliminacion("Alquiler"));
        }

        private async void dataGridViewVehiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                textBoxVehiculo.Text =
                    dataGridViewVehiculos.Rows[e.RowIndex]
                    .Cells["ColumnPatente"]
                    .Value.ToString();

                await ActualizarPrecio();
            }
        }

        private void dataGridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxDniCliente.Text = dataGridViewClientes.Rows[e.RowIndex].Cells["ColumnDNI"].Value.ToString();
        }

        private void dataGridViewConductores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
                textBoxDniCond.Text = dataGridViewConductores.Rows[e.RowIndex].Cells["ColumnDniCond"].Value.ToString();
        }

        private void dataGridViewReserva_CellDoubleClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !autoCompletar)
                return;

            var reserva = (ReservaResponse)
                dataGridViewReserva.Rows[e.RowIndex].DataBoundItem;

            textBoxReserva.Text = reserva.Id.ToString();

            textBoxVehiculo.Text = reserva.VehiculoPatente;
            textBoxDniCliente.Text = reserva.ClienteDni.ToString();

            DateTime fechaInicio = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            DateTime fechaFin = reserva.FechaFin.ToDateTime(TimeOnly.MinValue);

            // Permitir cargar reservas viejas
            fechaInicio = reserva.FechaInicio.ToDateTime(TimeOnly.MinValue);
            fechaFin = reserva.FechaFin.ToDateTime(TimeOnly.MinValue);

            // Si la reserva es anterior a hoy, permitir mostrarla
            dtpFechaInicio.MinDate = fechaInicio < DateTime.Today
                ? fechaInicio
                : DateTime.Today;

            dtpFechaDevolucion.MinDate = fechaFin < DateTime.Today.AddDays(1)
                ? fechaFin
                : DateTime.Today.AddDays(1);

            dtpFechaInicio.Value = fechaInicio;
            dtpFechaDevolucion.Value = fechaFin;

            dtpFechaInicio.Value = fechaInicio;
            dtpFechaDevolucion.Value = fechaFin;

            comboBoxSeguro.SelectedValue = reserva.SeguroId;

            textBoxPrecio.Text = reserva.Precio.ToString();

            textBoxSaldo.Text =
                (reserva.Precio - reserva.Senia).ToString("0.00");
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
                return;

            LimpiarCampos();
            BloquearCampos(false);
            BloquearBotones(false);
            autoCompletar = false;
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            switch (tabControlAlquileres.SelectedTab.Name)
            {
                case "tabPage1":
                    FiltrarAlquileres(busqueda);
                    break;

                case "tabPage2":
                    FiltrarVehiculos(busqueda);
                    break;

                case "tabPage5":
                    FiltrarClientes(busqueda);
                    break;

                case "tabPage3":
                    FiltrarConductores(busqueda);
                    break;

                case "tabPage4":
                    FiltrarReservas(busqueda);
                    break;
            }
        }
        private void FiltrarAlquileres(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewAlquileres.DataSource = _alquileres;
                return;
            }

            var filtrados = _alquileres
                .Where(a =>
                    a.ClienteDni.ToString().Contains(busqueda) ||
                    a.ClienteNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    a.ConductorNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    a.ConductorDni.ToString().Contains(busqueda))
                .ToList();

            dataGridViewAlquileres.DataSource = filtrados;
        }
        private void FiltrarVehiculos(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewVehiculos.DataSource = _vehiculos;
                return;
            }
            var filtrados = _vehiculos
                .Where(v =>
                    v.Patente.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    v.MarcaNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    v.ModeloNombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewVehiculos.DataSource = filtrados;
        }

        private void FiltrarClientes(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewClientes.DataSource = _clientes;
                return;
            }
            var filtrados = _clientes
                .Where(c =>
                    c.Dni.ToString().Contains(busqueda) ||
                    c.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    c.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewClientes.DataSource = filtrados;
        }

        private void FiltrarConductores(string busqueda)
        {
            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewConductores.DataSource = _conductores;
                return;
            }
            var filtrados = _conductores
                .Where(c =>
                    c.Dni.ToString().Contains(busqueda) ||
                    c.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    c.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();
            dataGridViewConductores.DataSource = filtrados;
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
        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarTodo();
        }
        private void CambiarModoAlquiler()
        {
            bool conReserva = radioButtonCReserva.Checked;

            textBoxDniCond.Enabled = true;
            comboBoxEstado.Enabled = true;

            textBoxReserva.Enabled = conReserva;

            textBoxVehiculo.Enabled = !conReserva;
            textBoxDniCliente.Enabled = !conReserva;
            dtpFechaInicio.Enabled = !conReserva;
            dtpFechaDevolucion.Enabled = !conReserva;
            comboBoxSeguro.Enabled = !conReserva;

            textBoxPrecio.Enabled = false;
            textBoxSaldo.Enabled = false;

            if (!conReserva)
                textBoxReserva.Clear();

            if (conReserva)
            {
                // Mostrar Reserva
                if (!tabControlAlquileres.TabPages.Contains(_tabReserva))
                    tabControlAlquileres.TabPages.Add(_tabReserva);

                // Ocultar Cliente y Vehículo
                if (tabControlAlquileres.TabPages.Contains(_tabVehiculo))
                    tabControlAlquileres.TabPages.Remove(_tabVehiculo);

                if (tabControlAlquileres.TabPages.Contains(_tabCliente))
                    tabControlAlquileres.TabPages.Remove(_tabCliente);
            }
            else
            {
                // Ocultar Reserva
                if (tabControlAlquileres.TabPages.Contains(_tabReserva))
                    tabControlAlquileres.TabPages.Remove(_tabReserva);

                // Mostrar Vehículo
                if (!tabControlAlquileres.TabPages.Contains(_tabVehiculo))
                    tabControlAlquileres.TabPages.Add(_tabVehiculo);

                // Mostrar Cliente
                if (!tabControlAlquileres.TabPages.Contains(_tabCliente))
                    tabControlAlquileres.TabPages.Add(_tabCliente);
            }
        }
        private void radioButtonSReserva_CheckedChanged(object sender, EventArgs e)
        {
            CambiarModoAlquiler();
        }

        private void radioButtonCReserva_CheckedChanged(object sender, EventArgs e)
        {
            CambiarModoAlquiler();
        }
        private async Task ActualizarPrecio()
        {
            if (radioButtonCReserva.Checked)
                return;

            if (string.IsNullOrWhiteSpace(textBoxVehiculo.Text))
                return;

            if (comboBoxSeguro.SelectedValue == null)
                return;

            decimal precio =
                await _reservaServicio.CalcularPrecio(
                    textBoxVehiculo.Text,
                    DateOnly.FromDateTime(dtpFechaInicio.Value),
                    DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                    (int)comboBoxSeguro.SelectedValue);

            textBoxPrecio.Text = precio.ToString("0.00");

            textBoxSaldo.Text = precio.ToString("0.00");
        }
        private async void comboBoxSeguro_SelectedIndexChanged(object sender,
    EventArgs e)
        {
            await ActualizarPrecio();
        }
        private async void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            await ActualizarPrecio();
        }

        private async void dtpFechaDevolucion_ValueChanged(object sender, EventArgs e)
        {
            await ActualizarPrecio();
        }
    }
}