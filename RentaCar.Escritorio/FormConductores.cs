using RentaCar.Dtos.Conductores;
using RentaCar.Escritorio.Helpers;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormConductores : Form
    {
        private readonly ConductorServicio _conductorServicio;

        private bool modoEdicion = false;

        private int dniSeleccionado;

        private List<ConductorResponse> _conductores;

        public FormConductores()
        {
            InitializeComponent();
            _conductorServicio = new ConductorServicio();
        }

        private async void FormConductores_Load(object sender, EventArgs e)
        {
            try
            {
                BloquearCampos(false);
                BloquearBotones(false);
                await CargarConductores();
                dateTimePickerVencLic.MinDate = DateTime.Today;
                dateTimePickerVencLic.MaxDate = DateTime.Today.AddYears(5);

            } catch
            {
                Dialogos.Error(Mensajes.ErrorDatos);
            }
            
        }

        private void BloquearCampos(bool estado)
        {
            dateTimePickerVencLic.Enabled = estado;
            textBoxNombre.Enabled = estado;
            textBoxApellido.Enabled = estado;
            textBoxDni.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private async Task CargarConductores()
        {
            _conductores = await _conductorServicio.ObtenerTodos();

            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = _conductores;
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
            BloquearBotones(true);
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
                    Dialogos.Error(Mensajes.CampoVacio("DNI"));
                    return;
                }

                if (!int.TryParse(textBoxDni.Text, out int dni)
                    || dni <= 0
                    || textBoxDni.Text.Length > 8
                    || textBoxDni.Text.Length < 7)
                {
                    Dialogos.Error(Mensajes.FormatoInvalido("DNI"));
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                {
                    Dialogos.Error(Mensajes.CampoVacio("Nombre"));
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBoxApellido.Text))
                {
                    Dialogos.Error(Mensajes.CampoVacio("Apellido"));
                    return;
                }

                if (dateTimePickerVencLic.Value.Date < DateTime.Today)
                {
                    Dialogos.Error(Mensajes.LicenciaVencida);
                    return;
                }


                if (!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("al conductor")))
                {
                    return;
                }



                if (modoEdicion)
                {
                    var updateRequest = new ConductorUpdateRequest
                    {
                        Nombre = textBoxNombre.Text,
                        Apellido = textBoxApellido.Text,
                        FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
                    };

                    await _conductorServicio.Actualizar(dniSeleccionado, updateRequest);

                    Dialogos.Info(Mensajes.ExitoEdicion("conductor"));
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

                    //MessageBox.Show("Conductor agregado correctamente");
                    Dialogos.Info(Mensajes.ExitoGuardado("conductor"));
                }

                await CargarConductores();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
                modoEdicion = false;
            }
            catch (Exception ex)
            {
                Dialogos.Error(ex.Message);
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("conductor"));
                return;
            }

            var conductor = (ConductorResponse)dataGridViewConductores.SelectedRows[0].DataBoundItem;

            //string mensajeConfirmacion = $"¿Eliminar a {conductor.Nombre} {conductor.Apellido}?";

            if (!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("conductor " + conductor.Dni)))
            {
                return;
            }

            await _conductorServicio.Eliminar(conductor.Dni);

            await CargarConductores();
            LimpiarCampos();
            BloquearBotones(false);

            Dialogos.Info(Mensajes.ExitoEliminacion("conductor"));

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("conductor"));
                return;
            }

            BloquearCampos(true);
            BloquearBotones(true);

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
            if (!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
            {
                return;
            }

            LimpiarCampos();
            BloquearCampos(false);
            BloquearBotones(false);
            modoEdicion = false;
        }

        private void textBoxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewConductores.DataSource = _conductores;
                return;

            }

            var filtrados = _conductores
                .Where(c => c.Dni.ToString().Contains(busqueda) ||
                            c.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                            c.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridViewConductores.DataSource = filtrados;
        }

        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarConductores();
        }
    }
}