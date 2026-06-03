using RentaCar.Dtos.Clientes;
using RentaCar.Escritorio.Helpers;
using RentaCar.Escritorio.Servicios;
using System.Net.Mail;

namespace RentaCar.Escritorio
{
    public partial class FormCliente : Form
    {
        private readonly ClienteServicio _clienteServicio;

        private bool modoEdicion = false;

        private List<ClienteResponse> _clientes;

        public FormCliente()
        {
            InitializeComponent();
            _clienteServicio = new ClienteServicio();
        }

        private async void FormCliente_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            BloquearBotones(false);
            await CargarClientes();
        }

        private async Task CargarClientes()
        {
            try
            {
                _clientes = await _clienteServicio.ObtenerTodos();
                dataGridView.DataSource = _clientes;
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

        private void BloquearBotones(bool estado)
        {
            buttonGuardar.Enabled = estado;
            buttonCancelar.Enabled = estado;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            BloquearBotones(true);
            modoEdicion = false;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(textBoxDNI.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("DNI"));
            }

            if(!int.TryParse(textBoxDNI.Text, out _))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("DNI"));
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Nombre"));
                return;
            }

            if(string.IsNullOrWhiteSpace(textBoxApellido.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Apellido"));
                return;
            }

            if(string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Email"));
                return;
            }
            
            if (!EmailValido(textBoxEmail.Text))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("Email"));
                return;
            }

            if(string.IsNullOrWhiteSpace(textBoxTel.Text))
            {
                Dialogos.Error(Mensajes.CampoVacio("Telefono"));
                return;
            }

            if(!double.TryParse(textBoxTel.Text, out _))
            {
                Dialogos.Error(Mensajes.FormatoInvalido("Telefono"));
                return;
            }

            if(!Dialogos.Confirmar(Mensajes.ConfirmarGuardado("al cliente")))
            {
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

                    Dialogos.Info(Mensajes.ExitoEdicion("Cliente"));
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

                    Dialogos.Info(Mensajes.ExitoGuardado("Cliente"));
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
            if (dataGridView.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("Cliente"));
                return;
            }

            var dni = (int)dataGridView.SelectedRows[0].Cells["ColumnDNI"].Value;

            if(!Dialogos.Confirmar(Mensajes.ConfirmarEliminacion("al cliente " + dni)))
            {
                return;
            }

                try
                {
                    await _clienteServicio.Eliminar(dni);

                    Dialogos.Info(Mensajes.ExitoEliminacion("Cliente"));

                    CargarClientes();
                    LimpiarCampos();
                    BloquearCampos(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar:\n{ex.Message}");
                }
     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                Dialogos.Error(Mensajes.SeleccioneEntidad("cliente"));
                return;
            }

            textBoxDNI.Text = dataGridView.SelectedRows[0].Cells["ColumnDNI"].Value.ToString();
            textBoxNombre.Text = dataGridView.SelectedRows[0].Cells["ColumnNombre"].Value.ToString();
            textBoxApellido.Text = dataGridView.SelectedRows[0].Cells["ColumnApellido"].Value.ToString();
            textBoxEmail.Text = dataGridView.SelectedRows[0].Cells["ColumnEmail"].Value.ToString();
            textBoxTel.Text = dataGridView.SelectedRows[0].Cells["ColumnTelefono"].Value.ToString();

            BloquearCampos(true);
            BloquearBotones(true);
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
                if(!Dialogos.Confirmar(Mensajes.ConfirmarCancelacion()))
                {
                    return;
                }

                LimpiarCampos();
                BloquearCampos(false);
                BloquearBotones(false);
            
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

        private void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            if (string.IsNullOrWhiteSpace(busqueda))
            {
                dataGridView.DataSource = _clientes;
                return;
            }

            var filtrados = _clientes
                .Where(c => c.Dni.ToString().Contains(busqueda) ||
                            c.Nombre.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                            c.Apellido.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                            c.Email.Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .ToList();

            dataGridView.DataSource = filtrados;
        }
    }
}