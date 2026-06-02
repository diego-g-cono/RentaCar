using RentaCar.Dominio;
using RentaCar.Dtos.Vehiculos;
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{
    public partial class FormVehiculo : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly VehiculoServicio _vehiculoServicio;
        private readonly MarcaServicio _marcaServicio;
        private readonly ModeloServicio _modeloServicio;
        private readonly TipoServicio _tipoServicio;
        private readonly ColorServicio _colorServicio;
        private readonly CombustibleServicio _combustibleServicio;
        private readonly EstadoVehiculoServicio _estadoServicio;

        private bool modoEdicion = false;
        private string patenteSeleccionada = null;
        public FormVehiculo()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _vehiculoServicio = new VehiculoServicio();
            _marcaServicio = new MarcaServicio();
            _modeloServicio = new ModeloServicio();
            _tipoServicio = new TipoServicio();
            _colorServicio = new ColorServicio();
            _estadoServicio = new EstadoVehiculoServicio();
            _combustibleServicio = new CombustibleServicio();
        }

        private async void FormVehiculo_Load(object sender, EventArgs e)
        {
            await CargarVehiculos();
            BloquearCampos(false);
            BloquearBotones(false);
            await CargarMarcas();
            await CargarTiposVehiculo();
            await CargarColores();
            await CargarCombustibles();
            await CargarEstados();
        }
        private async Task CargarVehiculos()
        {
            var vehiculos = await _vehiculoServicio.ObtenerTodos();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = vehiculos;
        }

        private void BloquearCampos(bool estado)
        {
            textBoxPatente.Enabled = estado;
            comboBoxMarca.Enabled = estado;
            comboBoxModelo.Enabled = estado;
            comboBoxTipo.Enabled = estado;
            numericUpDownAnio.Enabled = estado;
            comboBoxColor.Enabled = estado;
            comboBoxCombustible.Enabled = estado;
            numericUpDownKm.Enabled = estado;
            comboBoxEstado.Enabled = estado;
        }

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            BloquearBotones(true);
        }
        // Método para cargar marcas en el ComboBox
        private async Task CargarMarcas()
        {
            var marcas = await _marcaServicio.ObtenerTodos();

            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.DisplayMember = "Nombre";
            comboBoxMarca.ValueMember = "Id";
            comboBoxMarca.SelectedIndex = -1;
        }
        // Método para cargar modelos según la marca seleccionada
        private async Task CargarModelos(int marcaId)
        {
            var modelos = await _modeloServicio.ObtenerPorMarca(marcaId);

            comboBoxModelo.DataSource = modelos;
            comboBoxModelo.DisplayMember = "Nombre";
            comboBoxModelo.ValueMember = "Id";
            comboBoxModelo.SelectedIndex = -1;
        }
        // Evento para cargar modelos al seleccionar una marca
        private async void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedValue is int marcaId && marcaId > 0)
            {
                await CargarModelos(marcaId);
            }
        }
        // Método para cargar tipos de vehículo en el ComboBox
        private async Task CargarTiposVehiculo()
        {
            var tipos = await _tipoServicio.ObtenerTodos();

            comboBoxTipo.DataSource = tipos;
            comboBoxTipo.DisplayMember = "Nombre";
            comboBoxTipo.ValueMember = "Id";
            comboBoxTipo.SelectedIndex = -1;
        }
        // Método para cargar colores en el ComboBox
        private async Task CargarColores()
        {
            var colores = await _colorServicio.ObtenerTodos();

            comboBoxColor.DataSource = colores;
            comboBoxColor.DisplayMember = "Nombre";
            comboBoxColor.ValueMember = "Id";
            comboBoxColor.SelectedIndex = -1;
        }
        // Método para cargar combustibles en el ComboBox
        private async Task CargarCombustibles()
        {
            var combustibles = await _combustibleServicio.ObtenerTodos();

            comboBoxCombustible.DataSource = combustibles;
            comboBoxCombustible.DisplayMember = "Nombre";
            comboBoxCombustible.ValueMember = "Id";
            comboBoxCombustible.SelectedIndex = -1;
        }
        private async Task CargarEstados()
        {
            var estados = await _estadoServicio.ObtenerTodos();

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string patente = textBoxPatente.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(patente))
                {
                    Dialogos.Error(Mensajes.CampoVacio("Patente"));
                    return;
                }

                var regex = new System.Text.RegularExpressions.Regex(@"^[A-Z]{3}[0-9]{3}$|^[A-Z]{2}[0-9]{3}[A-Z]{2}$");

                if (!regex.IsMatch(patente))
                {
                    Dialogos.Error(Mensajes.FormatoInvalido("patente"));
                    return;
                }

                int anio = (int)numericUpDownAnio.Value;
                int kilometraje = (int)numericUpDownKm.Value;
                /*
                if (!(comboBoxMarca.SelectedItem is Marca marca) ||
                    !(comboBoxModelo.SelectedItem is Modelo modelo) ||
                    !(comboBoxColor.SelectedItem is Dominio.Color color) ||
                    !(comboBoxCombustible.SelectedItem is Combustible combustible) ||
                    !(comboBoxEstado.SelectedItem is EstadoVehiculo estado) ||
                    !(comboBoxTipo.SelectedItem is TipoVehiculo tipo))
                {
                    MessageBox.Show("Complete todos los campos");
                    return;
                }
                */

                if(comboBoxMarca.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("marca"));
                    return;
                }
                if (comboBoxModelo.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("modelo"));
                    return;
                }
                if (comboBoxColor.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("color"));
                    return;
                }
                if(comboBoxTipo.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("tipo de vehículo"));
                    return;
                }
                if (comboBoxCombustible.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("combustible"));
                    return;
                }
                if (comboBoxEstado.SelectedIndex == -1)
                {
                    Dialogos.Error(Mensajes.SeleccioneEntidad("estado del vehículo"));
                    return;
                }

                if(!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("vehículo")))
                {
                    return;
                }

                if (modoEdicion)
                {
                    var updateRequest = new VehiculoUpdateRequest
                    {
                        MarcaId = (int)comboBoxMarca.SelectedValue,
                        ModeloId = (int)comboBoxModelo.SelectedValue,
                        TipoId = (int)comboBoxTipo.SelectedValue,
                        ColorId = (int)comboBoxColor.SelectedValue,
                        CombustibleId = (int)comboBoxCombustible.SelectedValue,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        Anio = (int)numericUpDownAnio.Value,
                        Kilometraje = (int)numericUpDownKm.Value
                    };

                    await _vehiculoServicio.Actualizar(patenteSeleccionada, updateRequest);

                    Dialogos.Info(Mensajes.ExitoEdicion("Vehículo"));
                    modoEdicion = false;
                    textBoxPatente.Enabled = true;
                }
                else
                {
                    var createRequest = new VehiculoCreateRequest
                    {
                        Patente = patente,
                        MarcaId = (int)comboBoxMarca.SelectedValue,
                        ModeloId = (int)comboBoxModelo.SelectedValue,
                        TipoId = (int)comboBoxTipo.SelectedValue,
                        ColorId = (int)comboBoxColor.SelectedValue,
                        CombustibleId = (int)comboBoxCombustible.SelectedValue,
                        EstadoId = (int)comboBoxEstado.SelectedValue,
                        Anio = (int)numericUpDownAnio.Value,
                        Kilometraje = (int)numericUpDownKm.Value
                    };

                    await _vehiculoServicio.Agregar(createRequest);

                    Dialogos.Info(Mensajes.ExitoGuardado("Vehículo"));
                }

                await CargarVehiculos();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {
            textBoxPatente.Text = textBoxPatente.Text.ToUpper();
            textBoxPatente.SelectionStart = textBoxPatente.Text.Length;
        }
        private void LimpiarCampos()
        {
            textBoxPatente.Clear();

            comboBoxMarca.SelectedIndex = -1;
            comboBoxModelo.DataSource = null; // importante porque depende de marca
            comboBoxTipo.SelectedIndex = -1;
            comboBoxColor.SelectedIndex = -1;
            comboBoxCombustible.SelectedIndex = -1;
            comboBoxEstado.SelectedIndex = -1;

            numericUpDownAnio.Value = numericUpDownAnio.Minimum;
            numericUpDownKm.Value = numericUpDownKm.Minimum;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
            {
                return;
            }

            /*
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar? Se perderán los datos ingresados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            */

            //if (resultado == DialogResult.Yes)
            //{
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
                modoEdicion = false;
            //}
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("vehículo"));
                return;
            }

            var vehiculo = (VehiculoResponse)dataGridView.SelectedRows[0].DataBoundItem;

            patenteSeleccionada = vehiculo.Patente;

            textBoxPatente.Text = vehiculo.Patente;
            textBoxPatente.Enabled = false;

            numericUpDownAnio.Value = vehiculo.Anio;
            numericUpDownKm.Value = vehiculo.Kilometraje;

            comboBoxMarca.SelectedValue = vehiculo.MarcaId;
            await CargarModelos(vehiculo.MarcaId);

            comboBoxModelo.SelectedValue = vehiculo.ModeloId;
            comboBoxTipo.SelectedValue = vehiculo.TipoId;
            comboBoxColor.SelectedValue = vehiculo.ColorId;
            comboBoxCombustible.SelectedValue = vehiculo.CombustibleId;
            comboBoxEstado.SelectedValue = vehiculo.EstadoId;

            BloquearCampos(true);
            BloquearBotones(true);
            modoEdicion = true;
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("vehículo"));
                return;
            }

            var patente = dataGridView.SelectedRows[0].Cells["ColumnPatente"].Value.ToString();

            if(!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("vehículo")))
            {
                return;
            }
            /*
            var resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar el vehículo {patente}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            */
            //if (resultado == DialogResult.Yes)
            //{
            await _vehiculoServicio.Eliminar(patente);

                Dialogos.Info(Mensajes.ExitoEliminacion("Vehículo"));

                await CargarVehiculos();
                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
            //}
        }

    }
}
