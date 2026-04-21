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
    public partial class FormAlquileres : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly AlquilerRepositorio _repoAlquileres;
        private readonly VehiculoRepositorio _repoVehiculos;
        private readonly ClienteRepositorio _repoClientes;
        private readonly ConductorRepositorio _repoConductores;
        private readonly ReservaRepositorio _repoReserva;

        public FormAlquileres()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _repoAlquileres = new AlquilerRepositorio(_context);
            _repoVehiculos = new VehiculoRepositorio(_context);
            _repoClientes = new ClienteRepositorio(_context);
            _repoConductores = new ConductorRepositorio(_context);
            _repoReserva = new ReservaRepositorio(_context);

        }
        private void FormAlquileres_Load(object sender, EventArgs e)
        {
            CargarTablas();
        }

        private void CargarTablas()
        {
            dataGridViewVehiculos.AutoGenerateColumns = false;
            dataGridViewVehiculos.DataSource = _repoVehiculos.ObtenerTodos();

            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.DataSource = _repoClientes.ObtenerTodos();

            dataGridViewReserva.AutoGenerateColumns = false;
            dataGridViewReserva.DataSource = _repoReserva.ObtenerTodos();

            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = _repoConductores.ObtenerTodos();


        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

    }
}
