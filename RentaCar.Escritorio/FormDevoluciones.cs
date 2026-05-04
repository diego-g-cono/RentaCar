using RentaCar.Dtos.Devoluciones;
using RentaCar.Dtos.Alquileres;
using RentaCar.Escritorio.Servicios;

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
            BloquearCampos(false);
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
            dataGridViewAlquileres.DataSource = alquileres;
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
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna devolución.");
                return;
            }

            BloquearCampos(true);

            var devolucion = (DevolucionResponse)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;

            devolucionIdSeleccionada = devolucion.Id;

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
                MessageBox.Show("Debe seleccionar un alquiler.");
                return;
            }

            if (comboBoxTqueLleno.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si el tanque está lleno.");
                return;
            }

            var confirm = MessageBox.Show("¿Confirmar operación?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

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

                MessageBox.Show("Devolución actualizada correctamente.");
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

                MessageBox.Show("Devolución creada correctamente.");
            }

            await CargarDevoluciones();
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna devolución.");
                return;
            }

            var devolucion = (DevolucionResponse)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show("¿Eliminar devolución?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            await _devolucionServicio.Eliminar(devolucion.Id);

            await CargarDevoluciones();
            LimpiarCampos();
            BloquearCampos(false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }

        private void dataGridViewAlquileres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                var alquiler = (AlquilerResponse)dataGridViewAlquileres.Rows[e.RowIndex].DataBoundItem;
                textBoxAlquiler.Text = alquiler.Id.ToString();
            }
        }
    }
}