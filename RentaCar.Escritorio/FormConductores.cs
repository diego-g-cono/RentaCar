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
        private bool modoEdicion = false;

        public FormConductores()
        {
            _context = new RentaCarDBContext();
            _repoConductores = new ConductorRepositorio(_context);
            InitializeComponent();
        }

        private void FormConductores_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            CargarConductores();
        }
        private void BloquearCampos(bool estado)
        {
            dateTimePickerVencLic.Enabled = estado;
            textBoxNombre.Enabled = estado;
            textBoxApellido.Enabled = estado;
            textBoxDni.Enabled = estado;
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
            BloquearCampos(true);
            LimpiarCampos();
            modoEdicion = false;
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDni.Text))
            {
                MessageBox.Show("El DNI es obligatorio.");
                return;
            }

            if (!int.TryParse(textBoxDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser numérico.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (dateTimePickerVencLic.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La licencia no puede estar vencida.");
                return;
            }
            /*
            Conductor conductor = new Conductor()
            {
                Dni = int.Parse(textBoxDni.Text),
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
            };

            var confirm = MessageBox.Show(
                $"¿Son correctos los datos?\n\n" +
                $"DNI: {conductor.Dni}\n" +
                $"Nombre: {conductor.Nombre}\n" +
                $"Apellido: {conductor.Apellido}\n" +
                $"Vencimiento Licencia: {conductor.FechaVencLic}",
                "Confirmar",
                MessageBoxButtons.YesNo
            );
            if (confirm != DialogResult.Yes)
                return;

            if (modoEdicion)
            {
                //_repoConductores.Actualizar(conductor);
                MessageBox.Show("arreglar actualizacion colisiona con el objeto ya creado.");
                MessageBox.Show("Conductor editado correctamente");
            }
            else
            {
                _repoConductores.Agregar(conductor);
                MessageBox.Show("Conductor agregado correctamente.");
            } */
            var confirm = MessageBox.Show(
                $"¿Son correctos los datos?\n\n" +
                $"DNI: {dni}\n" +
                $"Nombre: {textBoxNombre.Text}\n" +
                $"Apellido: {textBoxApellido.Text}\n" +
                $"Vencimiento Licencia: {dateTimePickerVencLic.Value.Date}",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes)
                return;

            Conductor conductor;

            if(modoEdicion)
            {
                conductor = (Conductor)dataGridViewConductores.SelectedRows[0].DataBoundItem;
                conductor.Nombre = textBoxNombre.Text;
                conductor.Apellido = textBoxApellido.Text;
                conductor.FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value);
                _repoConductores.Actualizar(conductor);
                MessageBox.Show("Conductor editado correctamente");

            }
            else
            {
                conductor = new Conductor()
                {
                    Dni = int.Parse(textBoxDni.Text),
                    Nombre = textBoxNombre.Text,
                    Apellido = textBoxApellido.Text,
                    FechaVencLic = DateOnly.FromDateTime(dateTimePickerVencLic.Value)
                };
                _repoConductores.Agregar(conductor);
                MessageBox.Show("Conductor agregado correctamente");

            }

               
                _context.SaveChanges();

                CargarConductores();
                LimpiarCampos();
                BloquearCampos(false);
        }




        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún conductor.");
                return;
            }

            Conductor conductorSeleccionado = (Conductor)dataGridViewConductores.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Eliminar a {conductorSeleccionado.Nombre} {conductorSeleccionado.Apellido}?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                _repoConductores.Eliminar(conductorSeleccionado.Dni);

                CargarConductores();
                LimpiarCampos();
                MessageBox.Show("Conductor eliminado correctamente.");
            }
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewConductores.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún conductor.");
                return;
            }
            BloquearCampos(true);

            Conductor conductor = (Conductor)dataGridViewConductores.SelectedRows[0].DataBoundItem;
            textBoxDni.Text = conductor.Dni.ToString();
            textBoxDni.Enabled = false; // DNI no se puede editar
            textBoxNombre.Text = conductor.Nombre;
            textBoxApellido.Text = conductor.Apellido;
            dateTimePickerVencLic.Value = conductor.FechaVencLic.ToDateTime(new TimeOnly());

            modoEdicion = true;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }
    }
}
