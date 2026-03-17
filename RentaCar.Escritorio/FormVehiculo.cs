using RentaCar.Dominio;
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
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly MarcaRepositorio _repoMarcas;
        private readonly ModeloRepositorio _repoModelos;
        private readonly TipoVehiculoRepositorio _repoTiposVehiculo;
        private readonly ColorRepositorio _repoColores;
        private readonly CombustibleRepositorio _repoCombustibles;
        private readonly EstadoVehiculoRepositorio _repoEstados;
        public FormVehiculo()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _repoVehiculos = new VehiculoRepositorio(_context);
            _repoMarcas = new MarcaRepositorio(_context);
            _repoModelos = new ModeloRepositorio(_context);
            _repoTiposVehiculo = new TipoVehiculoRepositorio(_context);
            _repoColores = new ColorRepositorio(_context);
            _repoEstados = new EstadoVehiculoRepositorio(_context);
            _repoCombustibles = new CombustibleRepositorio(_context);
        }

        private void FormVehiculo_Load(object sender, EventArgs e)
        {
            List<Vehiculo> vehiculos = _repoVehiculos.ObtenerTodos();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = vehiculos;

            BloquearCampos(false);
            CargarMarcas();
            CargarTiposVehiculo();
            CargarColores();
            CargarCombustibles();
            CargarEstados();
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
        private void CargarMarcas()
        {
            var marcas = _repoMarcas.ObtenerTodos();

            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.DisplayMember = "Nombre"; // lo que se muestra
            comboBoxMarca.ValueMember = "Id"; // el valor real
            comboBoxMarca.SelectedIndex = -1;
        }
        // Método para cargar modelos según la marca seleccionada
        private void CargarModelos(int marcaId)
        {
            var modelos = _repoModelos.ObtenerTodos()
                            .Where(m => m.MarcaId == marcaId)
                            .ToList();

            comboBoxModelo.DataSource = modelos;
            comboBoxModelo.DisplayMember = "Nombre";
            comboBoxModelo.ValueMember = "Id";
            comboBoxModelo.SelectedIndex = -1;
        }
        // Evento para cargar modelos al seleccionar una marca
        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedItem is Marca marca)
            {
                CargarModelos(marca.Id);
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
    }
}
