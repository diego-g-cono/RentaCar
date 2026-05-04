using RentaCar.Dtos.Usuarios;
using RentaCar.Escritorio.Servicios;

namespace RentaCar.Escritorio
{
    public partial class FormUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private bool modoEdicion = false;
        private readonly RolServicio _rolServicio = new RolServicio();

        public FormUsuarios()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
        }

        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            await CargarUsuarios();
            await CargarRoles();
        }

        private async Task CargarUsuarios()
        {
            var usuarios = await _usuarioServicio.ObtenerTodos();
            dataGridViewUsuarios.AutoGenerateColumns = false;
            dataGridViewUsuarios.DataSource = usuarios;
        }

        private async Task CargarRoles()
        {
            var roles = await _rolServicio.ObtenerTodos(); // o UsuarioServicio si viene ahí

            comboBoxRol.DataSource = roles;
            comboBoxRol.DisplayMember = "Nombre";
            comboBoxRol.ValueMember = "Id";
            comboBoxRol.SelectedIndex = -1;

            comboBoxActivo.DataSource = new[]
            {
                new { Texto = "Sí", Valor = true },
                new { Texto = "No", Valor = false }
            };

            comboBoxActivo.DisplayMember = "Texto";
            comboBoxActivo.ValueMember = "Valor";
            comboBoxActivo.SelectedIndex = -1;
        }

        private void BloquearCampos(bool estado)
        {
            textBoxNombreUsuario.Enabled = estado;
            comboBoxRol.Enabled = estado;
            comboBoxActivo.Enabled = estado;
        }

        private void LimpiarCampos()
        {
            textBoxNombreUsuario.Clear();
            comboBoxRol.SelectedIndex = -1;
            comboBoxActivo.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            modoEdicion = false;
            BloquearCampos(true);
            LimpiarCampos();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún usuario.");
                return;
            }

            var usuario = (UsuarioResponse)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;

            textBoxNombreUsuario.Text = usuario.NombreUsuario;
            comboBoxRol.SelectedValue = usuario.RolId;
            comboBoxActivo.SelectedValue = usuario.Activo;

            modoEdicion = true;
            BloquearCampos(true);
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNombreUsuario.Text))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.");
                return;
            }

            if (comboBoxRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.");
                return;
            }

            if (comboBoxActivo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar estado.");
                return;
            }

            try
            {
                if (modoEdicion)
                {
                    var usuarioSeleccionado = (UsuarioResponse)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;

                    var request = new UsuarioUpdateRequest
                    {
                        NombreUsuario = textBoxNombreUsuario.Text,
                        RolId = comboBoxRol.SelectedValue.ToString(),
                        Activo = (bool)comboBoxActivo.SelectedValue
                    };

                    await _usuarioServicio.Actualizar(usuarioSeleccionado.Id, request);

                    MessageBox.Show("Usuario actualizado correctamente.");
                }
                else
                {
                    var request = new UsuarioCreateRequest
                    {
                        NombreUsuario = textBoxNombreUsuario.Text,
                        RolId = comboBoxRol.SelectedValue.ToString(),
                        Activo = (bool)comboBoxActivo.SelectedValue
                    };

                    await _usuarioServicio.Agregar(request);

                    MessageBox.Show("Usuario creado correctamente.");
                }

                await CargarUsuarios();
                LimpiarCampos();
                BloquearCampos(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún usuario.");
                return;
            }

            var confirm = MessageBox.Show(
                "¿Eliminar usuario?",
                "Confirmar",
                MessageBoxButtons.YesNo
            );

            if (confirm != DialogResult.Yes)
                return;

            var usuario = (UsuarioResponse)dataGridViewUsuarios.SelectedRows[0].DataBoundItem;

            try
            {
                await _usuarioServicio.Eliminar(usuario.Id);

                await CargarUsuarios();
                LimpiarCampos();
                BloquearCampos(false);

                MessageBox.Show("Usuario eliminado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }
    }
}