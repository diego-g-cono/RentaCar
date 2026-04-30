using RentaCar.Dominio;
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
        private readonly TipoVehiculoRepositorio _repoTiposVehiculo;
        private readonly ColorRepositorio _repoColores;
        private readonly CombustibleRepositorio _repoCombustibles;
        private readonly EstadoVehiculoRepositorio _repoEstados;

        private bool modoEdicion = false;
        private string patenteSeleccionada = null;
        public FormVehiculo()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _vehiculoServicio = new VehiculoServicio();
            _marcaServicio = new MarcaServicio();
            _modeloServicio = new ModeloServicio();
            _repoTiposVehiculo = new TipoVehiculoRepositorio(_context);
            _repoColores = new ColorRepositorio(_context);
            _repoEstados = new EstadoVehiculoRepositorio(_context);
            _repoCombustibles = new CombustibleRepositorio(_context);
        }

        private async void FormVehiculo_Load(object sender, EventArgs e)
        {
            await CargarVehiculos();
            BloquearCampos(false);
            await CargarMarcas();
            CargarTiposVehiculo();
            CargarColores();
            CargarCombustibles();
            CargarEstados();
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
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
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
            if (comboBoxMarca.SelectedValue is int marcaId)
            {
                await CargarModelos(marcaId);
            }
        }
        // Método para cargar tipos de vehículo en el ComboBox
        private void CargarTiposVehiculo()
        {
            var tipos = _repoTiposVehiculo.ObtenerTodos();

            comboBoxTipo.DataSource = tipos;
            comboBoxTipo.DisplayMember = "Nombre";
            comboBoxTipo.ValueMember = "Id";
            comboBoxTipo.SelectedIndex = -1;
        }
        // Método para cargar colores en el ComboBox
        private void CargarColores()
        {
            var colores = _repoColores.ObtenerTodos();

            comboBoxColor.DataSource = colores;
            comboBoxColor.DisplayMember = "Nombre";
            comboBoxColor.ValueMember = "Id";
            comboBoxColor.SelectedIndex = -1;
        }
        // Método para cargar combustibles en el ComboBox
        private void CargarCombustibles()
        {
            var combustibles = _repoCombustibles.ObtenerTodos();

            comboBoxCombustible.DataSource = combustibles;
            comboBoxCombustible.DisplayMember = "Nombre";
            comboBoxCombustible.ValueMember = "Id";
            comboBoxCombustible.SelectedIndex = -1;
        }
        private void CargarEstados()
        {
            var estados = _repoEstados.ObtenerTodos();

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string patente = textBoxPatente.Text.Trim().ToUpper();

            if (string.IsNullOrWhiteSpace(patente))
            {
                MessageBox.Show("Ingrese la patente");
                return;
            }

            var regex = new System.Text.RegularExpressions.Regex(@"^[A-Z]{3}[0-9]{3}$|^[A-Z]{2}[0-9]{3}[A-Z]{2}$");

            if (!regex.IsMatch(patente))
            {
                MessageBox.Show("Formato de patente inválido");
                return;
            }

            int anio = (int)numericUpDownAnio.Value;

            if (anio < 1950 || anio > DateTime.Now.Year)
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }
            int kilometraje = (int)numericUpDownKm.Value;

            if (kilometraje < 0)
            {
                MessageBox.Show("El kilometraje no puede ser negativo");
                return;
            }
            // Validación básica
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
            var vehiculo = new Vehiculo
            {
                Patente = textBoxPatente.Text,
                MarcaId = ((Marca)comboBoxMarca.SelectedItem).Id,
                ModeloId = ((Modelo)comboBoxModelo.SelectedItem).Id,
                TipoId = ((TipoVehiculo)comboBoxTipo.SelectedItem).Id,
                ColorId = ((Dominio.Color)comboBoxColor.SelectedItem).Id,
                CombustibleId = ((Combustible)comboBoxCombustible.SelectedItem).Id,
                EstadoId = ((EstadoVehiculo)comboBoxEstado.SelectedItem).Id,
                Anio = (int)numericUpDownAnio.Value,
                Kilometraje = (int)numericUpDownKm.Value
            };
           
            if (modoEdicion)
            {
                await _vehiculoServicio.Actualizar(vehiculo);
                MessageBox.Show("Vehículo actualizado correctamente");
                modoEdicion = false;
                textBoxPatente.Enabled = true;
            }
            else
            {
                await _vehiculoServicio.Agregar(vehiculo);
                MessageBox.Show("Vehículo guardado correctamente");
            }

            await Task.Delay(100); // opcional para evitar race condition visual
            CargarVehiculos();
            LimpiarCampos();
            BloquearCampos(false);
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
            var resultado = MessageBox.Show(
                "¿Está seguro que desea cancelar? Se perderán los datos ingresados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                BloquearCampos(false);
                modoEdicion = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo para editar");
                return;
            }

            // Obtener datos de la fila
            var fila = dataGridView.CurrentRow;

            patenteSeleccionada = fila.Cells["ColumnPatente"].Value.ToString();

            textBoxPatente.Text = patenteSeleccionada;
            textBoxPatente.Enabled = false;

            numericUpDownAnio.Value = Convert.ToInt32(fila.Cells["ColumnAnio"].Value);
            numericUpDownKm.Value = Convert.ToInt32(fila.Cells["ColumnKm"].Value);

            comboBoxMarca.Text = fila.Cells["ColumnMarca"].Value.ToString();
            comboBoxModelo.Text = fila.Cells["ColumnModelo"].Value.ToString();
            comboBoxTipo.Text = fila.Cells["ColumnTipo"].Value.ToString();
            comboBoxColor.Text = fila.Cells["ColumnColor"].Value.ToString();
            comboBoxCombustible.Text = fila.Cells["ColumnCombustible"].Value.ToString();
            comboBoxEstado.Text = fila.Cells["ColumnEstado"].Value.ToString();

            BloquearCampos(true);

            modoEdicion = true;
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo para eliminar");
                return;
            }

            var patente = dataGridView.CurrentRow.Cells["ColumnPatente"].Value.ToString();

            var resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar el vehículo {patente}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                await _vehiculoServicio.Eliminar(patente);

                MessageBox.Show("Vehículo eliminado correctamente");

                CargarVehiculos();
                LimpiarCampos();
                BloquearCampos(false);
            }
        }

    }
}
