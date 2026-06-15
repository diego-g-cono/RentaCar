using RentaCar.Dominio;
using RentaCar.Dtos.Tarifas;
using RentaCar.Dtos.Tipo;
using RentaCar.Escritorio.Servicios;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{

    public partial class FormTarifas : Form
    {
        private readonly TarifaServicio _tarifaServicio;
        private readonly TipoServicio _tipoServicio;

        private bool modoEdicion = false;
        public FormTarifas()
        {
            InitializeComponent();

            _tarifaServicio = new TarifaServicio();
            _tipoServicio = new TipoServicio();
        }
        private async void FormTarifas_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);

            await CargarComboBox();
            await CargarTarifas();
        }

        private async Task CargarTarifas()
        {
            try
            {
                var tarifas = await _tarifaServicio.ObtenerTodos();

                dataGridViewTarifas.AutoGenerateColumns = false;
                dataGridViewTarifas.DataSource = tarifas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async Task CargarComboBox()
        {
            var tipos = await _tipoServicio.ObtenerTodos();

            comboBoxVehiculo.DataSource = tipos;
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

            TarifaResponse tarifa =
                (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            textBoxPrecioDia.Text = tarifa.PrecioDia.ToString();
            textBoxPrecioSemana.Text = tarifa.PrecioSemana.ToString();

            comboBoxVehiculo.SelectedValue = tarifa.TipoVehiculoId;

            modoEdicion = true;
            BloquearCampos(true);
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
                    var tarifa =
                        (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

                    var request = new TarifaUpdateRequest
                    {
                        PrecioDia = precioDia,
                        PrecioSemana = precioSemana,
                        TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue,
                        Activo = true
                    };

                    await _tarifaServicio.Actualizar(tarifa.Id, request);
                }
                else
                {
                    var request = new TarifaCreateRequest
                    {
                        PrecioDia = precioDia,
                        PrecioSemana = precioSemana,
                        TipoVehiculoId = ((TipoResponse)comboBoxVehiculo.SelectedValue).Id,
                        Activo = true
                    };

                    await _tarifaServicio.Agregar(request);
                }

                await CargarTarifas();

                LimpiarCampos();

                BloquearCampos(false);

                modoEdicion = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarTarifas();
            CargarComboBox();
            LimpiarCampos();
            BloquearCampos(false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewTarifas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna tarifa.");
                return;
            }

            TarifaResponse tarifa =
                        (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show("¿Confirma que desea eliminar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                await _tarifaServicio.Eliminar(tarifa.Id);

                await CargarTarifas();

                LimpiarCampos();

                BloquearCampos(false);

                MessageBox.Show("Tarifa eliminada correctamente.");
            }
        }
    }
}
