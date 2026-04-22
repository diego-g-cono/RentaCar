using RentaCar.Dominio;
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
        private readonly AlquilerRepositorio _repoAlquileres;
        private bool modoEdicion = false;
        private bool autoCompletar = false;

        public FormDevoluciones()
        {
            _context = new RentaCarDBContext();
            _repoDevoluciones = new DevolucionRepositorio(_context);
            _repoAlquileres = new AlquilerRepositorio(_context);
            InitializeComponent();
        }
        private void FormDevoluciones_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            CargarDevoluciones();
            CargarAlquileres();
            CargarTanqueLleno();
            MessageBox.Show("entrando");
        }

        private void CargarDevoluciones()
        {
            var devoluciones = _repoDevoluciones.ObtenerTodos();
            dataGridViewDevoluciones.AutoGenerateColumns = false;
            dataGridViewDevoluciones.DataSource = devoluciones;
        }

        private void CargarAlquileres()
        {
            var alquileres = _repoAlquileres.ObtenerTodos();
            dataGridViewAlquileres.AutoGenerateColumns = false;
            dataGridViewAlquileres.DataSource = alquileres;
        }

        private void CargarTanqueLleno()
        {
            var opciones = new List<object>
            {
                new { Text = "Sí", Value = true },
                new { Text = "No", Value = false }
            };

            comboBoxTqueLleno.DataSource = opciones;
            comboBoxTqueLleno.DisplayMember = "Text";
            comboBoxTqueLleno.ValueMember = "Value";
            comboBoxTqueLleno.SelectedIndex = -1;
        }

        private void BloquearCampos(bool estado)
        {
            dtpFechaDevolucion.Enabled = estado;
            //textBoxAlquiler.Enabled = estado;
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
            modoEdicion = false;
            autoCompletar = true;
            BloquearCampos(true);
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna devolución.");
                return;
            }

            BloquearCampos(true);

            Devolucion devolucion = (Devolucion)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;
            dtpFechaDevolucion.Value = devolucion.Fecha.ToDateTime(new TimeOnly());
            textBoxAlquiler.Text = devolucion.AlquilerId.ToString();
            comboBoxTqueLleno.SelectedValue = devolucion.TanqueLleno;
            textBoxObservaciones.Text = devolucion.Observaciones;

            autoCompletar = true;
            modoEdicion = true;

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevoluciones.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna devolución.");
                return;
            }

            var confirm = MessageBox.Show("¿Estás seguro de eliminar esta devolución?", "Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            var devolucion = (Devolucion)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;
            _repoDevoluciones.Eliminar(devolucion.Id);

            CargarDevoluciones();
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAlquiler.Text))
            {
                MessageBox.Show("Debe seleccionar un alquiler.");
                return;
            }

            if (comboBoxTqueLleno.SelectedIndex == -1)
            {
                MessageBox.Show("Debe indicar si el tanque está lleno.");
                return;
            }

            if (comboBoxTqueLleno.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una opción válida para el tanque lleno.");
                return;
            }

            if (modoEdicion)
            {
                var devolucion = (Devolucion)dataGridViewDevoluciones.SelectedRows[0].DataBoundItem;
                devolucion.Fecha = DateOnly.FromDateTime(dtpFechaDevolucion.Value);
                devolucion.AlquilerId = int.Parse(textBoxAlquiler.Text);
                devolucion.TanqueLleno = (bool)comboBoxTqueLleno.SelectedValue;
                devolucion.Observaciones = textBoxObservaciones.Text;
                _repoDevoluciones.Actualizar(devolucion);
                MessageBox.Show("Devolución actualizada correctamente.");

            }
            else
            {
                var devolucion = new Devolucion()
                {
                    Fecha = DateOnly.FromDateTime(dtpFechaDevolucion.Value),
                    AlquilerId = int.Parse(textBoxAlquiler.Text),
                    TanqueLleno = (bool)comboBoxTqueLleno.SelectedValue,
                    Observaciones = textBoxObservaciones.Text
                };
                _repoDevoluciones.Agregar(devolucion);
                MessageBox.Show("Devolución creada correctamente.");
            }

            _context.SaveChanges();

            CargarDevoluciones();
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            autoCompletar = false;
        }

        private void dataGridViewAlquileres_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && autoCompletar)
            {
                var alquiler = (Alquiler)dataGridViewAlquileres.Rows[e.RowIndex].DataBoundItem;
                textBoxAlquiler.Text = alquiler.Id.ToString();
            }
        }
    }
}
