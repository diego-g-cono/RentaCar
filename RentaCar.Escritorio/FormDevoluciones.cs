using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{
    public partial class FormDevoluciones : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly DevolucionRepositorio _repoDevoluciones;
        public FormDevoluciones()
        {
            _context = new RentaCarDBContext();
            _repoDevoluciones = new DevolucionRepositorio(_context);
            InitializeComponent();
        }
        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            CargarDevoluciones();
            CargarAlquileres();
        }
        private void CargarDevoluciones()
        {
            var devoluciones = _repoDevoluciones.ObtenerTodos();
            dataGridViewDevoluciones.AutoGenerateColumns = false;
            dataGridViewDevoluciones.DataSource = devoluciones;
        }

        private void CargarAlquileres()
        {
            var alquileres = _context.Alquileres.ToList();
            dataGridViewAlquileres.AutoGenerateColumns = false;
            dataGridViewAlquileres.DataSource = alquileres;
        }

        private void BloquearCampos(bool estado)
        {
            dtpFechaDevolucion.Enabled = estado;
            textBoxAlquiler.Enabled = estado;
            comboBoxTqueLleno.Enabled = estado;
            textBoxObservaciones.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            dtpFechaDevolucion.Value = DateTime.Now;
            textBoxAlquiler.Text = "";
            comboBoxTqueLleno.SelectedIndex = -1;
            textBoxObservaciones.Text = "";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
