using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
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
    public partial class FormCliente : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly ClienteRepositorio _repoClientes;
        public FormCliente()
        {
            InitializeComponent();
            _context = new RentaCarDBContext();
            _repoClientes = new ClienteRepositorio(_context);
        }
        private void FormCliente_Load(object sender, EventArgs e)
        { 
            CargarClientes();
            BloquearCampos(false);
        }
        private void CargarClientes()
        {
            List<Cliente> clientes = _repoClientes.ObtenerTodos();
            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = clientes;
        }

        private void BloquearCampos(bool estado)
        {
            textBoxNombre.Enabled = estado;
            textBoxApellido.Enabled = estado;
            textBoxDNI.Enabled = estado;
            textBoxTel.Enabled = estado;
            textBoxEmail.Enabled = estado;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
        }
    }
}
