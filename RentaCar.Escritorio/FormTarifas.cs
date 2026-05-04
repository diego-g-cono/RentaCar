using RentaCar.Dtos.Tarifas;
using RentaCar.Dtos.Tipo;
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

            comboBoxEstado.DataSource = new[]
            {
                new { Texto = "Si", Valor = true },
                new { Texto = "No", Valor = false }
            };

            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            comboBoxEstado.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            textBoxPrecioDia.Text = "";
            textBoxPrecioSemana.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;
        }

        private void BloquearCampos(bool estado)
        {
            textBoxPrecioDia.Enabled = estado;
            textBoxPrecioSemana.Enabled = estado;
            comboBoxEstado.Enabled = estado;
            comboBoxVehiculo.Enabled = estado;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            LimpiarCampos();
            modoEdicion = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna tarifa.");
                return;
            }

            BloquearCampos(true);

            var tarifa = (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            textBoxPrecioDia.Text = tarifa.PrecioDia.ToString();
            textBoxPrecioSemana.Text = tarifa.PrecioSemana.ToString();
            comboBoxVehiculo.SelectedValue = tarifa.TipoVehiculoId;
            comboBoxEstado.SelectedValue = tarifa.Activa;

            modoEdicion = true;
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrecioDia.Text))
            {
                MessageBox.Show("El precio por día es obligatorio.");
                return;
            }

            if (!decimal.TryParse(textBoxPrecioDia.Text, out decimal precioDia))
            {
                MessageBox.Show("El precio por día debe ser numérico.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrecioSemana.Text))
            {
                MessageBox.Show("El precio por semana es obligatorio.");
                return;
            }

            if (!decimal.TryParse(textBoxPrecioSemana.Text, out decimal precioSemana))
            {
                MessageBox.Show("El precio por semana debe ser numérico.");
                return;
            }

            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (comboBoxVehiculo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de vehículo.");
                return;
            }

            var confirm = MessageBox.Show("¿Confirma que desea guardar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
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
                        Activa = (bool)comboBoxEstado.SelectedValue,
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
                        Activa = (bool)comboBoxEstado.SelectedValue,
                        TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue
                    };

                    await _repoTarifas.Agregar(create);
                }

                await CargarTarifas();
                await CargarComboBox();
                LimpiarCampos();
                BloquearCampos(false);
                modoEdicion = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna tarifa.");
                return;
            }

            var tarifa = (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show("¿Confirma que desea eliminar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
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
    }
}