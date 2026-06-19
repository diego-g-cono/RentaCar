using RentaCar.Dominio;
using RentaCar.Dtos.Tarifas;
using RentaCar.Dtos.Tipo;
using RentaCar.Escritorio.Helpers;
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
        private List<TarifaResponse> _tarifas = new();

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
            BloquearBotones(false);

            await CargarComboBox();
            await CargarTarifas();
        }

        private async Task CargarTarifas()
        {
            try
            {
                _tarifas = await _tarifaServicio.ObtenerTodos();

                dataGridViewTarifas.AutoGenerateColumns = false;
                dataGridViewTarifas.DataSource = _tarifas;
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

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }



        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            LimpiarCampos();
            modoEdicion = false;
            BloquearBotones(true);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                //MessageBox.Show("No seleccionaste ninguna tarifa.");
                Dialogos.Error(Mensajes.SeleccioneEntidad("tarifa"));
                return;
            }

            TarifaResponse tarifa =
                (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            textBoxPrecioDia.Text = tarifa.PrecioDia.ToString();
            textBoxPrecioSemana.Text = tarifa.PrecioSemana.ToString();

            comboBoxVehiculo.SelectedValue = tarifa.TipoVehiculoId;

            modoEdicion = true;
            BloquearCampos(true);
            BloquearBotones(true);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrecioDia.Text))
            {
                //MessageBox.Show("El precio por día es obligatorio.");
                Dialogos.Error(Mensajes.CampoVacio("precio por día"));
                return;
            }

            if (!decimal.TryParse(textBoxPrecioDia.Text, out decimal precioDia))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("precio por día"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrecioSemana.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("precio por semana"));
                return;
            }

            if (!decimal.TryParse(textBoxPrecioSemana.Text, out decimal precioSemana))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("precio por semana"));
                return;
            }

            if (comboBoxVehiculo.SelectedValue == null)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("tipo de vehículo"));
                return;
            }

            //var confirm = MessageBox.Show("¿Confirma que desea guardar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            // if (confirm != DialogResult.Yes)
            //    return;

            if (!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("la tarifa")))
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
                    Dialogos.Info(Mensajes.ExitoEdicion("Tarifa"));
                }
                else
                {
                    var request = new TarifaCreateRequest
                    {
                        PrecioDia = precioDia,
                        PrecioSemana = precioSemana,
                        TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue,
                        Activo = true
                    };

                    await _tarifaServicio.Agregar(request);
                    Dialogos.Info(Mensajes.ExitoGuardado("Tarifa"));
                }

                await CargarTarifas();

                LimpiarCampos();
                BloquearCampos(false);
                modoEdicion = false;
                BloquearBotones(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //CargarTarifas();
            //CargarComboBox();
            //LimpiarCampos();
            //BloquearCampos(false);
            //BloquearBotones(false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
                return;


            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
            BloquearBotones(false);
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("tarifa"));
                return;
            }

            TarifaResponse tarifa =
                        (TarifaResponse)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            //var confirm = MessageBox.Show("¿Confirma que desea eliminar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("la tarifa")))
            {
                await _tarifaServicio.Eliminar(tarifa.Id);

                await CargarTarifas();

                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);

                Dialogos.Info(Mensajes.ExitoEliminacion("Tarifa"));
            }
        }
        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewTarifas.DataSource = _tarifas;
                return;
            }
            var filtrados = _tarifas
                .Where(t =>
                    t.TipoVehiculoNombre.ToString().Contains(busqueda))
                .ToList();

            dataGridViewTarifas.DataSource = filtrados;

        }

        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarTarifas();
        }
    }
}
