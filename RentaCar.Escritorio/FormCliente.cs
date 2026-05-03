using RentaCar.Dtos.Clientes;
using RentaCar.Escritorio.Servicios;
using System.Net.Mail;

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

        private async void FormCliente_Load(object sender, EventArgs e)
        {
            await CargarClientes();
            BloquearCampos(false);
        }

        private async Task CargarClientes()
        {
            try
            {
                var clientes = await _clienteServicio.ObtenerTodos();
                dataGridView.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes:\n{ex.Message}");
            }
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
            modoEdicion = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text) ||
                string.IsNullOrWhiteSpace(textBoxNombre.Text) ||
                string.IsNullOrWhiteSpace(textBoxApellido.Text) ||
                string.IsNullOrWhiteSpace(textBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(textBoxTel.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios");
                return;
            }

            if (!EmailValido(textBoxEmail.Text))
            {
                MessageBox.Show("Ingrese un email válido");
                return;
            }

            try
            {
                if (modoEdicion)
                {
                    var updateRequest = new ClienteUpdateRequest
                    {
                        Nombre = textBoxNombre.Text,
                        Apellido = textBoxApellido.Text,
                        Email = textBoxEmail.Text,
                        Telefono = textBoxTel.Text
                    };

                    int dni = int.Parse(textBoxDNI.Text);

                    await _clienteServicio.Actualizar(dni, updateRequest);

                    MessageBox.Show("Cliente actualizado correctamente");
                }
                else
                {
                    var createRequest = new ClienteCreateRequest
                    {
                        Dni = int.Parse(textBoxDNI.Text),
                        Nombre = textBoxNombre.Text,
                        Apellido = textBoxApellido.Text,
                        Email = textBoxEmail.Text,
                        Telefono = textBoxTel.Text
                    };

                    await _clienteServicio.Agregar(createRequest);

                    MessageBox.Show("Cliente creado correctamente");
                }

                LimpiarCampos();
                BloquearCampos(false);
                await CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}");
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            var dni = (int)dataGridView.CurrentRow.Cells["ColumnDNI"].Value;

            var resultado = MessageBox.Show(
                $"¿Eliminar cliente {dni}?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    await _clienteServicio.Eliminar(dni);

                    MessageBox.Show("Cliente eliminado correctamente");

                    CargarClientes();
                    LimpiarCampos();
                    BloquearCampos(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar:\n{ex.Message}");
                }
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
                "¿Cancelar operación?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (resultado == DialogResult.Yes)
            {
                LimpiarCampos();
                BloquearCampos(false);
            }
        }
        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
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
    }
}