using Microsoft.EntityFrameworkCore;
using RentaCar.Dominio;
using RentaCar.Escritorio.Servicios;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{
    public partial class FormCliente : Form
    {
        private readonly ClienteServicio _clienteServicio;

        private bool modoEdicion = false;
        public FormCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }
        private void FormCliente_Load(object sender, EventArgs e)
        { 
            CargarClientes();
            BloquearCampos(false);
        }
        private async void CargarClientes()
        {
            var clientes = await _clienteServicio.ObtenerTodos();
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
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite solo números y la tecla de borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetter(e.KeyChar) &&
                e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar email
            if (!EmailValido(textBoxEmail.Text))
            {
                MessageBox.Show("Ingrese un email válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cliente = new Cliente
            {
                Dni = int.Parse(textBoxDNI.Text),
                Nombre = textBoxNombre.Text,
                Apellido = textBoxApellido.Text,
                Email = textBoxEmail.Text,
                Telefono = textBoxTel.Text
            };
            if (modoEdicion)
            {
                await _clienteServicio.Actualizar(cliente);
                MessageBox.Show("Cliente actualizado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                await _clienteServicio.Agregar(cliente);
                MessageBox.Show("Cliente guardado correctamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LimpiarCampos();
            BloquearCampos(false);
            CargarClientes();
            
        }
        private bool EmailValido(string email)
        {
            try
            {
                var mail = new MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        private void LimpiarCampos()
        {
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxEmail.Clear();
            textBoxTel.Clear();
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
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            textBoxDNI.Text = dataGridView.CurrentRow.Cells["ColumnDNI"].Value.ToString();
            textBoxNombre.Text = dataGridView.CurrentRow.Cells["ColumnNombre"].Value.ToString();
            textBoxApellido.Text = dataGridView.CurrentRow.Cells["ColumnApellido"].Value.ToString();
            textBoxEmail.Text = dataGridView.CurrentRow.Cells["ColumnEmail"].Value.ToString();
            textBoxTel.Text = dataGridView.CurrentRow.Cells["ColumnTelefono"].Value.ToString();

            BloquearCampos(true);
            textBoxDNI.Enabled = false;
            modoEdicion = true;
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo para eliminar");
                return;
            }

            var dni = (int)dataGridView.CurrentRow.Cells["ColumnDNI"].Value;

            var resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar el cliente con DNI: {dni}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                await _clienteServicio.Eliminar(dni);

                MessageBox.Show("Cliente eliminado correctamente");

                CargarClientes();
                LimpiarCampos();
                BloquearCampos(false);
            }
        }
    }

}
