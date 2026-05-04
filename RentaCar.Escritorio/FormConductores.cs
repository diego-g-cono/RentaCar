using RentaCar.Dtos.Conductores;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormConductores : Form
    {
        private readonly ConductorServicio _conductorServicio;

        private bool modoEdicion = false;
        private int dniSeleccionado;

        public FormConductores()
        {
            InitializeComponent();
            _conductorServicio = new ConductorServicio();
        }

        private async void FormConductores_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            await CargarConductores();
        }

        private void BloquearCampos(bool estado)
        {
            dateTimePickerVencLic.Enabled = estado;
            textBoxNombre.Enabled = estado;
            textBoxApellido.Enabled = estado;
            textBoxDni.Enabled = estado;
        }

        private async Task CargarConductores()
        {
            var conductores = await _conductorServicio.ObtenerTodos();

            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = conductores;
        }

        private void LimpiarCampos()
        {
            textBoxDni.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePickerVencLic.Value = DateTime.Now;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            LimpiarCampos();
            modoEdicion = false;
            textBoxDni.Enabled = true;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxDni.Text))
                {
                    MessageBox.Show("El DNI es obligatorio.");
                    return;
                }

                if (!int.TryParse(textBoxDni.Text, out int dni))
                {
                    MessageBox.Show("El DNI debe ser numérico.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    MessageBox.Show("El nombre es obligatorio.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxApellido.Text))
                {
                    MessageBox.Show("El apellido es obligatorio.");
                    return;
                }

                if (dateTimePickerVencLic.Value.Date < DateTime.Today)
                {
                    MessageBox.Show("La licencia no puede estar vencida.");
                    return;
                }

                var confirm = MessageBox.Show(
                    $"¿Son correctos los datos?\n\n" +
                    $"DNI: {dni}\n" +
                    $"Nombre: {textBoxNombre.Text}\n" +
                    $"Apellido: {textBoxApellido.Text}\n" +
                    $"Vencimiento Licencia: {dateTimePickerVencLic.Value.Date}",
                    "Confirmar",
                    MessageBoxButtons.YesNo
                );

                if (confirm != DialogResult.Yes)
                    return;

                if (modoEdicion)
                {
                    var updateRequest = new ConductorUpdateRequest
                    {
                        Nombre = textBoxNombre.Text,
                        Apellido = textBoxApellido.Text,
                        FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
                    };

                    await _conductorServicio.Actualizar(dniSeleccionado, updateRequest);

                    MessageBox.Show("Conductor editado correctamente");
                }
                else
                {
                    var createRequest = new ConductorCreateRequest
                    {
                        Dni = dni,
                        Nombre = textBoxNombre.Text,
                        Apellido = textBoxApellido.Text,
                        FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
                    };

                    await _conductorServicio.Agregar(createRequest);

                    MessageBox.Show("Conductor agregado correctamente");
                }

                await CargarConductores();
                LimpiarCampos();
                BloquearCampos(false);
                modoEdicion = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún conductor.");
                return;
            }

            var conductor = (ConductorResponse)dataGridViewConductores.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Eliminar a {conductor.Nombre} {conductor.Apellido}?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                await _conductorServicio.Eliminar(conductor.Dni);

                await CargarConductores();
                LimpiarCampos();

                MessageBox.Show("Conductor eliminado correctamente.");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún conductor.");
                return;
            }

            BloquearCampos(true);

            var conductor = (ConductorResponse)dataGridViewConductores.SelectedRows[0].DataBoundItem;

            dniSeleccionado = conductor.Dni;

            textBoxDni.Text = conductor.Dni.ToString();
            textBoxDni.Enabled = false;

            textBoxNombre.Text = conductor.Nombre;
            textBoxApellido.Text = conductor.Apellido;
            dateTimePickerVencLic.Value = conductor.FechaVencLic.ToDateTime(new TimeOnly());

            modoEdicion = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }
    }
}