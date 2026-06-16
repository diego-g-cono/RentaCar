using RentaCar.Dtos.Devoluciones;
using RentaCar.Dtos.Alquileres;
using RentaCar.Escritorio.Servicios;
using RentaCar.Escritorio.Helpers;

namespace RentaCar.Escritorio
{
    public partial class FormDevoluciones : Form
    {
        private readonly DevolucionServicio _devolucionServicio;
        private readonly AlquilerServicio _alquilerServicio;

        private bool modoEdicion = false;
        private bool autoCompletar = false;
        private int devolucionIdSeleccionada;

        public FormDevoluciones()
        {
            InitializeComponent();
            _devolucionServicio = new DevolucionServicio();
            _alquilerServicio = new AlquilerServicio();
        }

        private async void FormDevoluciones_Load(object sender, EventArgs e)
        {
            dtpFechaDevolucion.MinDate = DateTime.Today;
            BloquearCampos(false);
            BloquearBotones(false);
            await CargarDevoluciones();
            await CargarAlquileres();
            CargarTanqueLleno();
        }

        private async Task CargarDevoluciones()
        {
            var devoluciones = await _devolucionServicio.ObtenerTodos();

            dataGridViewDevoluciones.AutoGenerateColumns = false;
            dataGridViewDevoluciones.DataSource = devoluciones;
        }

        private async Task CargarAlquileres()
        {
            var alquileres = await _alquilerServicio.ObtenerTodos();

            dataGridViewAlquileres.AutoGenerateColumns = false;
            dataGridViewAlquileres.DataSource = alquileres
                .Where(a => a.EstadoId == 2)
                .ToList();
        }

        private void CargarTanqueLleno()
        {
            var opciones = new List<object>
            {
                new { Text = "Sí", Value = true },
                new { Text = "No", Value = false }
            };

            comboBoxTqueLleno.DataSource = opciones;
            comboBoxTqueLleno.DisplayMember = "Text";
            comboBoxTqueLleno.ValueMember = "Value";
            comboBoxTqueLleno.SelectedIndex = -1;
        }

        private void BloquearCampos(bool estado)
        {
            dtpFechaDevolucion.Enabled = estado;
            comboBoxTqueLleno.Enabled = estado;
            textBoxObservaciones.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            dtpFechaDevolucion.Value = DateTime.Now;
            textBoxAlquiler.Text = "";
            comboBoxTqueLleno.SelectedIndex = -1;
            textBoxObservaciones.Text = "";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            modoEdicion = false;
            autoCompletar = true;
            BloquearCampos(true);
            BloquearBotones(true);
            dtpFechaDevolucion.MinDate = DateTime.Today;
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                //MessageBox.Show("No seleccionaste ninguna devolución.");
                Dialogos.Error(Mensajes.SeleccioneEntidad("Devolución"));
                return;
            }

            BloquearCampos(true);
            BloquearBotones(true);

            var devolucion = (DevolucionResponse)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;

            devolucionIdSeleccionada = devolucion.Id;
            dtpFechaDevolucion.MinDate = devolucion.Fecha.ToDateTime(new TimeOnly());
            dtpFechaDevolucion.Value = devolucion.Fecha.ToDateTime(new TimeOnly());
            textBoxAlquiler.Text = devolucion.AlquilerId.ToString();
            comboBoxTqueLleno.SelectedValue = devolucion.TanqueLleno;
            textBoxObservaciones.Text = devolucion.Observaciones;

            autoCompletar = true;
            modoEdicion = true;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAlquiler.Text))
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("alquiler"));
                return;
            }

            if (comboBoxTqueLleno.SelectedIndex == -1)
            {
                Dialogos.Error(Mensajes.TanqueLleno);
                return;
            }

            //var confirm = MessageBox.Show("¿Confirmar operación?", "Confirmar", MessageBoxButtons.YesNo);

            //if (confirm != DialogResult.Yes)
            //    return;
            if (!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("Devolución")))
                return;

            try
            {

                if (modoEdicion)
                {
                    var update = new DevolucionUpdateRequest
                    {
                        Fecha = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        AlquilerId = int.Parse(textBoxAlquiler.Text),
                        TanqueLleno = (bool)comboBoxTqueLleno.SelectedValue,
                        Observaciones = textBoxObservaciones.Text
                    };

                    await _devolucionServicio.Actualizar(devolucionIdSeleccionada, update);

                    Dialogos.Info(Mensajes.ExitoEdicion("Devolución"));
                }
                else
                {
                    var create = new DevolucionCreateRequest
                    {
                        Fecha = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                        AlquilerId = int.Parse(textBoxAlquiler.Text),
                        TanqueLleno = (bool)comboBoxTqueLleno.SelectedValue,
                        Observaciones = textBoxObservaciones.Text
                    };

                    await _devolucionServicio.Agregar(create);

                    Dialogos.Info(Mensajes.ExitoGuardado("Devolución"));
                }

                await CargarDevoluciones();
                await CargarAlquileres();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
                autoCompletar = false;
            }
            catch (Exception ex)
            {
                Dialogos.Error(ex.Message);
                return;
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("devolución"));
                return;
            }

            var devolucion = (DevolucionResponse)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;

            //var confirm = MessageBox.Show("¿Eliminar devolución?", "Confirmar", MessageBoxButtons.YesNo);

            //if (confirm != DialogResult.Yes)
            //    return;

            if (!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("devolución")))
                return;
            try
            {
                await _devolucionServicio.Eliminar(devolucion.Id);

                await CargarDevoluciones();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);

                Dialogos.Info(Mensajes.ExitoEliminacion("Devolución"));

            }
            catch (Exception ex)
            {
                Dialogos.Error(ex.Message);
                return;
            }


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

        private void dataGridViewAlquileres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                var alquiler = (AlquilerResponse)dataGridViewAlquileres.Rows[e.RowIndex].DataBoundItem;
                textBoxAlquiler.Text = alquiler.Id.ToString();
            }
        }

        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarDevoluciones();
            await CargarAlquileres();
        }
    }
}