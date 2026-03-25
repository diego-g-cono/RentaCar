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
    public partial class FormReserva : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly ReservaRepositorio _repoReservas;
        private readonly ClienteRepositorio _repoClientes;
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly EstadoReservaRepositorio _repoEstadosReserva;
        public FormReserva()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _repoVehiculos = new VehiculoRepositorio(_context);
            _repoClientes = new ClienteRepositorio(_context);
            _repoReservas = new ReservaRepositorio(_context);
            _repoEstadosReserva = new EstadoReservaRepositorio(_context);
        }

        private void FormReserva_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            CargarVehiculos();
            CargarClientes();
            CargarReservas();
            CargarEstados();
        }

        private void BloquearCampos(bool estado)
        {
            textBoxCliente.Enabled = estado;
            textBoxVehiculo.Enabled = estado;
            dtpFechaRetiro.Enabled = estado;
            dtpFechaDevolucion.Enabled = estado;
            numericUpDownPrecio.Enabled = estado;
            numericUpDownSenia.Enabled = estado;
        }
        private void CargarVehiculos()
        {
            List<Vehiculo> vehiculos = _repoVehiculos.ObtenerTodos();
            dataGridViewVehiculo.AutoGenerateColumns = false;
            dataGridViewVehiculo.DataSource = vehiculos;
        }
        private void CargarClientes()
        {
            List<Cliente> clientes = _repoClientes.ObtenerTodos();
            dataGridViewCliente.AutoGenerateColumns = false;
            dataGridViewCliente.DataSource = clientes;
        }
        private void CargarReservas()
        {
            List<Reserva> reservas = _repoReservas.ObtenerTodos();
            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = reservas;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
        }

        private void CargarEstados()
        {
            var estados = _repoEstadosReserva.ObtenerTodos();

            comboBoxEstado.DataSource = estados;
            comboBoxEstado.DisplayMember = "Nombre";
            comboBoxEstado.ValueMember = "Id";
            comboBoxEstado.SelectedIndex = -1;
        }
        private void textBoxCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y tecla borrar
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }
        private void textBoxPatente_TextChanged(object sender, EventArgs e)
        {
            textBoxVehiculo.Text = textBoxVehiculo.Text.ToUpper();
            textBoxVehiculo.SelectionStart = textBoxVehiculo.Text.Length;
        }
    }
}
