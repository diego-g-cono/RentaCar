using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmVehiculos : Form
    {
        private int filaEnEdicion = -1;
        public FrmVehiculos()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            using (var db = new RentaCarDBContext())
            {
                var marcas = db.marcas
                               .OrderBy(m => m.nombre)
                               .Select(m => new { id_marca = m.id_marca, nombre = m.nombre })
                               .ToList();

                cmbBoxMarca.DataSource = marcas;
                cmbBoxMarca.DisplayMember = "nombre";
                cmbBoxMarca.ValueMember = "id_marca";
            }
            cmbBoxMarca.SelectedIndex = -1;

            numBoxAnio.Minimum = 1950;
            numBoxAnio.Maximum = DateTime.Now.Year + 1;
            numBoxAnio.Value = DateTime.Now.Year - 5;
            numBoxAnio.ResetText();

            using (var db = new RentaCarDBContext())
            {
                var listaColores = db.colores
                                     .OrderBy(c => c.nombre)
                                     .ToList();

                cmbBoxColor.DataSource = listaColores;
                cmbBoxColor.DisplayMember = "nombre";
                cmbBoxColor.ValueMember = "id_color";
                cmbBoxColor.SelectedIndex = -1;
            }

            using (var db = new RentaCarDBContext())
            {
                var listaCombustibles = db.combustibles
                                       .OrderBy(c => c.nombre)
                                       .ToList();

                cmbBoxCombustible.DataSource = listaCombustibles;
                cmbBoxCombustible.DisplayMember = "nombre";
                cmbBoxCombustible.ValueMember = "id_combustible";
                cmbBoxCombustible.SelectedIndex = -1;
            }

            numBoxKm.ThousandsSeparator = true;

            using (var db = new RentaCarDBContext())
            {
                var estadosVehiculo = db.estados
                    .Where(e => e.categoria == "vehiculo")
                    .OrderBy(e => e.nombre)
                    .ToList();

                cmbBoxEstado.DataSource = estadosVehiculo;
                cmbBoxEstado.DisplayMember = "nombre";
                cmbBoxEstado.ValueMember = "id_estado";
                cmbBoxEstado.SelectedIndex = -1;
            }

            cmbBoxMarca.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxMarca.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbBoxModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxModelo.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbBoxColor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxColor.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbBoxCombustible.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxCombustible.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbBoxEstado.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbBoxEstado.AutoCompleteSource = AutoCompleteSource.ListItems;

            CargarVehiculos();
        }

        private void cmbBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxMarca.SelectedItem == null)
            {
                cmbBoxModelo.DataSource = null;
                return;
            }

            if (cmbBoxMarca.SelectedValue is int id_marca)
            {
                using (var db = new RentaCarDBContext())
                {
                    var lista = db.modelos
                                  .Where(m => m.id_marca == id_marca)
                                  .OrderBy(m => m.nombre)
                                  .ToList();

                    cmbBoxModelo.DataSource = lista;
                    cmbBoxModelo.DisplayMember = "nombre";
                    cmbBoxModelo.ValueMember = "id_modelo";
                    cmbBoxModelo.SelectedIndex = -1;
                }
            }
        }
        private void HabilitarCampos(bool activo)
        {
            foreach (Control ctrl in grBoxVehi.Controls)
            {
                if (ctrl is TextBox || ctrl is NumericUpDown || ctrl is ComboBox)
                    ctrl.Enabled = activo;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            HabilitarCampos(true);
            LimpiarFormulario();
            filaEnEdicion = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxPatente.Text))
            {
                MessageBox.Show("La patente es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBoxPatente.Focus();
                return;
            }

            if (cmbBoxMarca.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar una marca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBoxMarca.DroppedDown = true;
                return;
            }

            if (cmbBoxModelo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un modelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBoxModelo.DroppedDown = true;
                return;
            }
            if (cmbBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBoxEstado.DroppedDown = true;
                return;
            }
            if (filaEnEdicion == -1)
            {
                
                using (var db = new RentaCarDBContext())
                {
                    string patente = txtBoxPatente.Text.Trim().ToUpper();
                    string nuevoEstado = cmbBoxEstado.SelectedItem?.ToString();

                    if (!Regex.IsMatch(patente, @"^[A-Z]{2}[0-9]{3}[A-Z]{2}$"))
                    {
                        MessageBox.Show("La patente debe tener el formato AA000AA (2 letras, 3 números, 2 letras).");
                        return;
                    }
                    bool existe = db.vehiculos.Any(v => v.Patente == patente);
                    if (existe)
                    {
                        MessageBox.Show("Ya existe un vehículo con esa patente.");
                        return;
                    }
                    var vehiculo = new Vehiculo(
                        patente: txtBoxPatente.Text.Trim().ToUpper(),
                        tipo_combustible: cmbBoxCombustible.SelectedItem?.ToString(),
                        kilometraje: (int?)numBoxKm.Value,
                        estado: cmbBoxEstado.SelectedItem?.ToString(),
                        marca: cmbBoxMarca.SelectedItem?.ToString(),
                        modelo: cmbBoxModelo.SelectedItem?.ToString(),
                        anio: (int?)numBoxAnio.Value,
                        color: cmbBoxColor.SelectedItem?.ToString()
                    );

                    db.vehiculos.Add(vehiculo);
                    db.SaveChanges();
                    var lista = db.vehiculos.ToList();
                    dataGridViewVehiculos.AutoGenerateColumns = false;
                    dataGridViewVehiculos.DataSource = lista;
                }

                MessageBox.Show("Vehículo guardado correctamente");

                LimpiarFormulario();
                HabilitarCampos(false);
            }
            else
            {
                using (var db = new RentaCarDBContext())
                {
                    string patenteOriginal = dataGridViewVehiculos.Rows[filaEnEdicion].Cells["ColumnaPatente"].Value?.ToString();

                    var vehiculo = db.vehiculos.FirstOrDefault(v => v.Patente == patenteOriginal);
                    string nuevoEstado = cmbBoxEstado.SelectedItem?.ToString();
                    if (vehiculo.EstadoVehiculo_id != nuevoEstado)
                    {
                        bool tieneReservasActivas = db.reservas.Any(r =>
                            r.vehiculo_patente == patenteOriginal &&
                            r.estado != "Cancelada"
                        );

                        if (tieneReservasActivas)
                        {
                            MessageBox.Show(
                                "No es posible modificar el estado porque el vehículo posee reservas activas.",
                                "Operación no permitida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }
                    if (vehiculo != null)
                    {
                        vehiculo.Patente = txtBoxPatente.Text.Trim();
                        vehiculo.Marca_id = cmbBoxMarca.SelectedItem?.ToString();
                        vehiculo.Modelo_id = cmbBoxModelo.SelectedItem?.ToString();
                        vehiculo.Anio = (int?)numBoxAnio.Value;
                        vehiculo.Color = cmbBoxColor.SelectedItem?.ToString();
                        vehiculo.Kilometraje = (int?)numBoxKm.Value;
                        vehiculo.EstadoVehiculo_id = cmbBoxEstado.SelectedItem?.ToString();
                        vehiculo.Tipo_combustible = cmbBoxCombustible.SelectedItem?.ToString();

                        db.SaveChanges();
                    }
                }

                var fila = dataGridViewVehiculos.Rows[filaEnEdicion];
                fila.Cells["ColumnaPatente"].Value = txtBoxPatente.Text;
                fila.Cells["ColumnaMarca"].Value = cmbBoxMarca.SelectedItem?.ToString();
                fila.Cells["ColumnaModelo"].Value = cmbBoxModelo.SelectedItem?.ToString();
                fila.Cells["ColumnaAnio"].Value = Convert.ToInt32(numBoxAnio.Value);
                fila.Cells["ColumnaColor"].Value = cmbBoxColor.SelectedItem?.ToString();
                fila.Cells["ColumnaKm"].Value = Convert.ToInt32(numBoxKm.Value);
                fila.Cells["ColumnaEstado"].Value = cmbBoxEstado.SelectedItem?.ToString();
                fila.Cells["ColumnaCombustible"].Value = cmbBoxCombustible.SelectedItem?.ToString();

                MessageBox.Show("Cambios actualizados correctamente");

                filaEnEdicion = -1;
                LimpiarFormulario();
                HabilitarCampos(false);
            }
        }
        private void CargarVehiculos()
        {
            using (var db = new RentaCarDBContext())
            {
                var lista = db.vehiculos.ToList();
                dataGridViewVehiculos.AutoGenerateColumns = false;
                dataGridViewVehiculos.DataSource = lista;
            }
        }

        private void btnActTable_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
        }

        private void LimpiarFormulario()
        {
            txtBoxPatente.Clear();
            numBoxKm.Value = 0;
            cmbBoxMarca.SelectedIndex = -1;
            cmbBoxModelo.SelectedIndex = -1;
            cmbBoxColor.SelectedIndex = -1;
            numBoxAnio.Value = DateTime.Now.Year - 5;
            numBoxAnio.ResetText();
            cmbBoxCombustible.SelectedIndex = -1;
            cmbBoxEstado.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un vehículo de la lista para editar");
                return;
            }

            filaEnEdicion = dataGridViewVehiculos.CurrentRow.Index;
            var fila = dataGridViewVehiculos.Rows[filaEnEdicion];


            txtBoxPatente.Text = fila.Cells["ColumnaPatente"].Value?.ToString();
            numBoxKm.Text = fila.Cells["ColumnaKm"].Value?.ToString();
            cmbBoxMarca.SelectedItem = fila.Cells["ColumnaMarca"].Value?.ToString();
            cmbBoxModelo.SelectedItem = fila.Cells["ColumnaModelo"].Value?.ToString();
            cmbBoxColor.SelectedItem = fila.Cells["ColumnaColor"].Value?.ToString();
            numBoxAnio.Value = Convert.ToInt32(fila.Cells["ColumnaAnio"].Value);
            cmbBoxCombustible.SelectedItem = fila.Cells["ColumnaCombustible"].Value?.ToString();
            cmbBoxEstado.SelectedItem = fila.Cells["ColumnaEstado"].Value?.ToString();

            HabilitarCampos(true);
            txtBoxPatente.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewVehiculos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un vehículo para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este vehículo?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.No)
                return;

            string patente = dataGridViewVehiculos.SelectedRows[0].Cells["ColumnaPatente"].Value.ToString();

            
            using (var db = new RentaCarDBContext())
            {
                var vehiculo = db.vehiculos.FirstOrDefault(v => v.Patente == patente);
                bool tieneReservasActivas = db.reservas.Any(r =>
                    r.vehiculo_patente == patente &&
                    r.estado != "Cancelada"
                );

                if (tieneReservasActivas)
                {
                    MessageBox.Show("No se puede eliminar el vehículo porque posee reservas activas.");
                    return;
                }

                if (vehiculo != null)
                {
                    vehiculo.EstadoVehiculo_id = "No disponible";
                    db.SaveChanges();
                }
            }

            dataGridViewVehiculos.SelectedRows[0].Cells["ColumnaEstado"].Value = "No disponible";

            MessageBox.Show("Vehículo eliminado correctamente");
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

            filaEnEdicion = -1;

            LimpiarFormulario();
            HabilitarCampos(false);
        }
        
    }
}
