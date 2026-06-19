using RentaCar.Dtos.Usuarios;
using RentaCar.Escritorio.Servicios;
using RentaCar.Escritorio.Helpers;

namespace RentaCar.Escritorio
{
    public partial class FormUsuarios : Form
    {
        private readonly UsuarioServicio _usuarioServicio;
        private readonly RolServicio _rolServicio;
        private List<UsuarioResponse> _usuarios = new();

        private bool modoEdicion = false;
        private BindingSource _bindingUsuarios = new BindingSource();

        public FormUsuarios()
        {
            InitializeComponent();
            _usuarioServicio = new UsuarioServicio();
            _rolServicio = new RolServicio();
        }

        private async void FormUsuarios_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            await CargarRoles();
            await CargarUsuarios();
        }


        private async Task CargarUsuarios()
        {
            try
            {
                _usuarios = await _usuarioServicio.ObtenerTodos();
                var roles = await _rolServicio.ObtenerTodos();

                var lista = _usuarios.Select(u => new
                {
                    u.Id,
                    u.NombreUsuario,
                    Rol = roles.FirstOrDefault(r => r.Id == u.RolId)?.Nombre ?? "Sin rol",
                    Activo = u.Activo ? "Sí" : "No"
                }).ToList();

                dataGridViewUsuarios.AutoGenerateColumns = true;
                dataGridViewUsuarios.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando usuarios: {ex.Message}");
            }
        }

        private async Task CargarRoles()
        {
            var roles = await _rolServicio.ObtenerTodos();

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
            textBoxContrasenia.Clear();
            comboBoxRol.SelectedIndex = -1;
            comboBoxActivo.SelectedIndex = -1;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            modoEdicion = false;
            BloquearCampos(true);
            LimpiarCampos();
        }

        private async void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ningún usuario.");
                return;
            }

            var id = (int)dataGridViewUsuarios.SelectedRows[0].Cells["IdColumn"].Value;

            var usuario = _usuarios.First(u => u.Id == id);

            textBoxNombreUsuario.Text = usuario.NombreUsuario;
            textBoxContrasenia.Text = "";
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

            if (comboBoxRol.SelectedValue == null || comboBoxActivo.SelectedValue == null)
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            try
            {
                if (modoEdicion)
                {
                    var id = (int)dataGridViewUsuarios.SelectedRows[0].Cells["IdColumn"].Value;

                    var request = new UsuarioUpdateRequest
                    {
                        NombreUsuario = textBoxNombreUsuario.Text,
                        RolId = (int)comboBoxRol.SelectedValue,
                        Activo = (bool)comboBoxActivo.SelectedValue,
                        Contrasenia = textBoxContrasenia.Text
                    };

                    await _usuarioServicio.Actualizar(id, request);
                    Dialogos.Info(Mensajes.ExitoEdicion("Usuario"));
                }
                else
                {
                    var request = new UsuarioCreateRequest
                    {
                        NombreUsuario = textBoxNombreUsuario.Text,
                        Contrasenia = textBoxContrasenia.Text,
                        RolId = comboBoxRol.SelectedValue == null
                            ? 3
                            : (int)comboBoxRol.SelectedValue,
                        Activo = (bool)comboBoxActivo.SelectedValue
                    };

                    await _usuarioServicio.Agregar(request);
                    Dialogos.Info(Mensajes.ExitoGuardado("Usuario"));
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

            var confirm = MessageBox.Show("¿Eliminar usuario?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                var id = (int)dataGridViewUsuarios.SelectedRows[0].Cells["IdColumn"].Value;

                await _usuarioServicio.Eliminar(id);

                await CargarUsuarios();
                LimpiarCampos();
                BloquearCampos(false);
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
        private async void textBoxBuscador_TextChanged(object sender, EventArgs e)
        {
            string busqueda = textBoxBuscador.Text.Trim();

            var roles = await _rolServicio.ObtenerTodos();

            if (string.IsNullOrEmpty(busqueda))
            {
                dataGridViewUsuarios.DataSource = _usuarios
                    .Select(u => new
                    {
                        u.Id,
                        u.NombreUsuario,
                        Rol = roles.FirstOrDefault(r => r.Id == u.RolId)?.Nombre ?? "Sin rol",
                        Activo = u.Activo ? "Sí" : "No"
                    })
                    .ToList();

                return;
            }

            var filtrados = _usuarios
                .Where(u =>
                    u.NombreUsuario.Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    (u.Activo ? "Sí" : "No").Contains(busqueda, StringComparison.OrdinalIgnoreCase) ||
                    (roles.FirstOrDefault(r => r.Id == u.RolId)?.Nombre ?? "")
                        .Contains(busqueda, StringComparison.OrdinalIgnoreCase))
                .Select(u => new
                {
                    u.Id,
                    u.NombreUsuario,
                    Rol = roles.FirstOrDefault(r => r.Id == u.RolId)?.Nombre ?? "Sin rol",
                    Activo = u.Activo ? "Sí" : "No"
                })
                .ToList();

            dataGridViewUsuarios.DataSource = filtrados;
        }

        private async void buttonRecargar_Click(object sender, EventArgs e)
        {
            await CargarRoles();
            await CargarUsuarios();
        }
    }
}