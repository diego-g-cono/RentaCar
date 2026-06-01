using RentaCar.Dtos.Tarifas;
using RentaCar.Dtos.Tipo;
using RentaCar.Escritorio.Helpers;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormTarifas : Form
    {
        private readonly TarifaServicio _repoTarifas;
        private readonly TipoServicio _tipoVehiculoServicio;

        private bool modoEdicion = false;

        public FormTarifas()
        {
            InitializeComponent();
            _repoTarifas = new TarifaServicio();
            _tipoVehiculoServicio = new TipoServicio();
        }

        private async void FormTarifas_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            BloquearBotones(false);
            await CargarTarifas();
            await CargarComboBox();
        }

        private async Task CargarTarifas()
        {
            var tarifas = await _repoTarifas.ObtenerTodos();
            dataGridViewTarifas.AutoGenerateColumns = false;
            dataGridViewTarifas.DataSource = tarifas;
        }

        private async Task CargarComboBox()
        {
            var tiposVehiculo = await _tipoVehiculoServicio.ObtenerTodos();

            comboBoxVehiculo.DataSource = tiposVehiculo;
            comboBoxVehiculo.DisplayMember = "Nombre";
            comboBoxVehiculo.ValueMember = "Id";
            comboBoxVehiculo.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            textBoxPrecioDia.Text = "";
            textBoxPrecioSemana.Text = "";
            comboBoxVehiculo.SelectedIndex = -1;
        }

        private void BloquearCampos(bool estado)
        {
            textBoxPrecioDia.Enabled = estado;
            textBoxPrecioSemana.Enabled = estado;
            comboBoxVehiculo.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            BloquearBotones(true);
            LimpiarCampos();
            modoEdicion = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("campo"));
                return;
            }

            BloquearCampos(true);
            BloquearBotones(true);

            var tarifa = (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            textBoxPrecioDia.Text = tarifa.PrecioDia.ToString();
            textBoxPrecioSemana.Text = tarifa.PrecioSemana.ToString();
            comboBoxVehiculo.SelectedValue = tarifa.TipoVehiculoId;
            //comboBoxEstado.SelectedValue = tarifa.Activa;

            modoEdicion = true;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrecioDia.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Precio por día"));
                return;
            }

            if (!decimal.TryParse(textBoxPrecioDia.Text, out decimal precioDia))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("Precio por día"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrecioSemana.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Precio por semana"));
                return;
            }

            if (!decimal.TryParse(textBoxPrecioSemana.Text, out decimal precioSemana))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("Precio por semana"));
                return;
            }

            if (comboBoxVehiculo.SelectedValue == null)
            {
                Dialogos.Error(Mensajes.CampoVacio("Tipo de vehículo"));
                return;
            }

            //var confirm = MessageBox.Show("¿Confirma que desea guardar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            //if (confirm != DialogResult.Yes)
               // return;

            if(!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("la tarifa")))
                return;

            try
            {
                if (modoEdicion)
                {
                    var tarifa = (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

                    var update = new TarifaUpdateRequest
                    {
                        PrecioDia = precioDia,
                        PrecioSemana = precioSemana,
                        //Activa = (bool)comboBoxEstado.SelectedValue,
                        TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue
                    };

                    await _repoTarifas.Actualizar(tarifa.Id, update);
                }
                else
                {
                    var create = new TarifaCreateRequest
                    {
                        PrecioDia = precioDia,
                        PrecioSemana = precioSemana,
                        //Activa = (bool)comboBoxEstado.SelectedValue,
                        TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue
                    };

                    await _repoTarifas.Agregar(create);
                }

                await CargarTarifas();
                await CargarComboBox();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
                modoEdicion = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if(!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
                return;

            LimpiarCampos();
            BloquearCampos(false);
            BloquearBotones(false);
            modoEdicion = false;
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("campo"));
                return;
            }

            var tarifa = (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            //var confirm = MessageBox.Show("¿Confirma que desea eliminar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("la tarifa")))
            {
                try
                {
                    await _repoTarifas.Eliminar(tarifa.Id);

                    await CargarTarifas();
                    await CargarComboBox();
                    LimpiarCampos();
                    BloquearCampos(false);

                    MessageBox.Show("Tarifa eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxPrecioDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxPrecioSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}