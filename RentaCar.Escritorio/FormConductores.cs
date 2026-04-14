using RentaCar.Dominio;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
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
    public partial class FormConductores : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly ConductorRepositorio _repoConductores;

        public FormConductores()
        {
            _context = new RentaCarDBContext();
            _repoConductores = new ConductorRepositorio(_context);
            InitializeComponent();
        }

        private void FormConductores_Load(object sender, EventArgs e)
        {
            //BloquearCampos(false);
            CargarConductores();
        }
        private void BloquearCampos(bool estado)
        {

        }
        private void CargarConductores()
        {
            List<Conductor> conductores = _repoConductores.ObtenerTodos();

            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.DataSource = conductores;
        }
        private void LimpiarCampos()
        {
            textBoxDni.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePickerVencLic.Value = DateTime.Now;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            // BloquearCampos(true);
            LimpiarCampos();
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Conductor conductor = new Conductor()
            {
                Dni = int.Parse(textBoxDni.Text),
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
            };

            _repoConductores.Agregar(conductor);
            _context.SaveChanges();

            CargarConductores();
            LimpiarCampos();
            BloquearCampos(false);
        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
