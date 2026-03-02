using Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        private int filaEnEdicion = -1;
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            int dni = int.Parse(txtBoxDNI.Text);

            if (ExisteDni(dni))
            {
                MessageBox.Show("El DNI ya está registrado en la base de datos.");
                return;
            }

            if (ExisteUsuario(txtBoxUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario ya existe.");
                return;
            }
            using (var db = new RentaCarDBContext())
            {
                var cliente = new Cliente(
                    dni: int.Parse(txtBoxDNI.Text.Trim()),
                    nombre: txtBoxNombre.Text.Trim(),
                    apellido: txtBoxApellido.Text.Trim(),
                    direccion: txtBoxDireccion.Text.Trim(),
                    fecha_nacimiento: DateOnly.FromDateTime(dateTimePickerFdN.Value),
                    usuario: txtBoxUsuario.Text.Trim(),
                    contrasenia: txtBoxContrasenia.Text.Trim(),
                    email: txtBoxEmail.Text.Trim()
                );
                db.clientes.Add(cliente);
                db.SaveChanges();
            }

            MessageBox.Show("Cliente guardado correctamente");

            CargarCampos();
        }
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarCampos();
            HabilitarCampos(false);
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            foreach (Control ctrl in groupBoxClientes.Controls)
            {
                if (ctrl is TextBox)
                    ctrl.Text = string.Empty;
                else if (ctrl is NumericUpDown numCtrl)
                    numCtrl.Value = numCtrl.Minimum;
                else if (ctrl is ComboBox comboCtrl)
                    comboCtrl.SelectedIndex = -1;
            }
        }
        private void HabilitarCampos(bool activo)
        {
            foreach (Control ctrl in groupBoxClientes.Controls)
            {
                if (ctrl is TextBox || ctrl is NumericUpDown || ctrl is ComboBox)
                    ctrl.Enabled = activo;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimpiarCampos();
        }

        private void CargarCampos()
        {
            using (var db = new RentaCarDBContext())
            {
                var lista = db.clientes.ToList();
                dataGridViewClientes.AutoGenerateColumns = false;
                dataGridViewClientes.DataSource = lista;
            }
        }

        private void txtBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(txtBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(txtBoxUsuario.Text) ||
                string.IsNullOrWhiteSpace(txtBoxContrasenia.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return false;
            }

            return true;
        }

        private bool ExisteDni(int dni)
        {
            using (var db = new RentaCarDBContext())
            {
                return db.clientes.Any(c => c.dni == dni);
            }
        }

        private bool ExisteUsuario(string usuario)
        {
            using (var db = new RentaCarDBContext())
            {
                return db.clientes.Any(c => c.usuario == usuario);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea cancelar?\nSe perderán los cambios no guardados.",
                "Confirmar cancelación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
                return;

            LimpiarCampos();
            HabilitarCampos(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para modificar.");
                return;
            }

            filaEnEdicion = dataGridViewClientes.CurrentRow.Index;
            var fila = dataGridViewClientes.Rows[filaEnEdicion];


            txtBoxDNI.Text = fila.Cells["ColumnaDNI"].Value?.ToString();
            txtBoxNombre.Text = fila.Cells["ColumnaNombre"].Value?.ToString();
            txtBoxApellido.Text = fila.Cells["ColumnaApellido"].Value?.ToString();
            txtBoxDireccion.Text = fila.Cells["ColumnaDireccion"].Value?.ToString();

            DateOnly fechaNacimiento = (DateOnly)fila.Cells["ColumnaFechaDeNacimiento"].Value;
            dateTimePickerFdN.Value = fechaNacimiento.ToDateTime(TimeOnly.MinValue);

            txtBoxEmail.Text = fila.Cells["ColumnaEmail"].Value?.ToString();
            txtBoxUsuario.Text = fila.Cells["ColumnaUsuario"].Value?.ToString();

            HabilitarCampos(true);

            txtBoxDNI.Enabled = false;

            txtBoxContrasenia.Enabled = false;
        }
    }
}
