using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Escritorio
{
    public partial class FrmVehiculos : Form
    {
        private Dictionary<string, List<string>> modelosPorMarca = new Dictionary<string, List<string>>()
        {
            { "Toyota", new List<string> { "Corolla", "Hilux", "Yaris", "Etios", "Camry", "RAV4", "SW4", "Prius", "Avanza", "Land Cruiser", "Tundra", "Tacoma", "Supra", "86", "Innova" } },
            { "Ford", new List<string> { "Focus", "Fiesta", "Ranger", "EcoSport", "Ka", "Mustang", "Explorer", "F-150", "Bronco", "Escape", "Edge", "Territory", "Mondeo", "Galaxy", "Transit" } },
            { "Chevrolet", new List<string> { "Onix", "Cruze", "S10", "Spin", "Tracker", "Prisma", "Silverado", "Camaro", "Montana", "Avalanche", "Trailblazer", "Equinox", "Celta", "Captiva", "Malibu" } },
            { "Volkswagen", new List<string> { "Gol", "Polo", "Amarok", "T-Cross", "Vento", "Golf", "Passat", "Tiguan", "Fox", "Saveiro", "Virtus", "Nivus", "Scirocco", "Beetle", "Touareg" } },
            { "Renault", new List<string> { "Clio", "Kangoo", "Sandero", "Duster", "Stepway", "Logan", "Megane", "Fluence", "Captur", "Oroch", "Talisman", "Symbol", "Laguna", "Scenic", "R19" } },
            { "Peugeot", new List<string> { "208", "2008", "308", "301", "3008", "Partner", "5008", "207", "206", "407", "508", "405", "Rifter", "108", "607" } },
            { "Honda", new List<string> { "Civic", "CR-V", "Fit", "Accord", "HR-V", "City", "Pilot", "Odyssey", "Passport", "Ridgeline", "Jazz", "Integra", "Prelude", "S2000", "Brio" } },
            { "Nissan", new List<string> { "Versa", "Sentra", "Frontier", "Kicks", "March", "X-Trail", "Murano", "Altima", "Pathfinder", "Patrol", "Titan", "Rogue", "Juke", "Maxima", "GT-R" } },
            { "Fiat", new List<string> { "Cronos", "Argo", "Toro", "Strada", "Uno", "Pulse", "Siena", "Punto", "Mobi", "Fiorino", "Palio", "Ducato", "Tipo", "147", "Idea" } },
            { "Hyundai", new List<string> { "Creta", "Tucson", "Santa Fe", "i20", "i30", "Accent", "Elantra", "Kona", "Sonata", "Palisade", "Venue", "Veracruz", "Terracan", "Genesis", "Staria" } },
            { "Kia", new List<string> { "Rio", "Cerato", "Sportage", "Sorento", "Picanto", "Seltos", "Optima", "Carens", "Soul", "Stonic", "Cadenza", "Mohave", "Niro", "Telluride", "Carnival" } },
            { "BMW", new List<string> { "Serie 1", "Serie 2", "Serie 3", "Serie 4", "Serie 5", "Serie 6", "Serie 7", "Serie 8", "X1", "X3", "X4", "X5", "X6", "X7", "Z4" } },
            { "Mercedes-Benz", new List<string> { "Clase A", "Clase B", "Clase C", "Clase E", "Clase S", "GLA", "GLB", "GLC", "GLE", "GLS", "CLA", "CLS", "Vito", "Sprinter", "AMG GT" } },
            { "Audi", new List<string> { "A1", "A3", "A4", "A5", "A6", "A7", "A8", "Q2", "Q3", "Q5", "Q7", "Q8", "TT", "R8", "Allroad" } },
            { "Citroën", new List<string> { "C3", "C4", "C5 Aircross", "C-Elysée", "Berlingo", "C3 Aircross", "C1", "C2", "C5", "DS3", "DS4", "DS5", "C6", "C8", "Ami" } }
        };
        private int filaEnEdicion = -1;
        public FrmVehiculos()
        {
            InitializeComponent();
            HabilitarCampos(false);
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            cmbBoxMarca.DataSource = modelosPorMarca.Keys.ToList();
            cmbBoxMarca.SelectedIndex = -1;

            numBoxAnio.Minimum = 1950;
            numBoxAnio.Maximum = DateTime.Now.Year + 1;
            numBoxAnio.Value = DateTime.Now.Year - 5;
            numBoxAnio.ResetText();

            cmbBoxColor.Items.AddRange(new string[]
            {
                "Blanco",
                "Negro",
                "Gris Plata",
                "Gris Oscuro",
                "Rojo",
                "Azul",
                "Azul Marino",
                "Bordo",
                "Verde",
                "Beige"
            });
            cmbBoxCombustible.Items.AddRange(new string[]
            {
                "Nafta",
                "Gas-Oil",
                "GNC",
                "Electrico"
            });

            numBoxKm.ThousandsSeparator = true;

            cmbBoxEstado.Items.AddRange(new string[]
            {
                "Disponible",
                "En reparación",
                "No disponible"
            });

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
            string marcaSeleccionada = cmbBoxMarca.SelectedItem.ToString();
            cmbBoxModelo.DataSource = modelosPorMarca[marcaSeleccionada];
            cmbBoxModelo.SelectedIndex = -1;
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
                    var vehiculo = new Vehiculo(
                        patente: txtBoxPatente.Text.Trim(),
                        tipoCombustible: cmbBoxCombustible.SelectedItem?.ToString(),
                        kilometraje: (int?)numBoxKm.Value,
                        estado: cmbBoxEstado.SelectedItem?.ToString(),
                        marca: cmbBoxMarca.SelectedItem?.ToString(),
                        modelo: cmbBoxModelo.SelectedItem?.ToString(),
                        anio: (int?)numBoxAnio.Value,
                        color: cmbBoxColor.SelectedItem?.ToString()
                    );

                    db.Vehiculos.Add(vehiculo);
                    db.SaveChanges();
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

                    var vehiculo = db.Vehiculos.FirstOrDefault(v => v.Patente == patenteOriginal);

                    if (vehiculo != null)
                    {
                        vehiculo.Patente = txtBoxPatente.Text.Trim();
                        vehiculo.Marca = cmbBoxMarca.SelectedItem?.ToString();
                        vehiculo.Modelo = cmbBoxModelo.SelectedItem?.ToString();
                        vehiculo.Anio = (int?)numBoxAnio.Value;
                        vehiculo.Color = cmbBoxColor.SelectedItem?.ToString();
                        vehiculo.Kilometraje = (int?)numBoxKm.Value;
                        vehiculo.Estado = cmbBoxEstado.SelectedItem?.ToString();
                        vehiculo.TipoCombustible = cmbBoxCombustible.SelectedItem?.ToString();

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
                var lista = db.Vehiculos.ToList();
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
                var vehiculo = db.Vehiculos.FirstOrDefault(v => v.Patente == patente);

                if (vehiculo != null)
                {
                    vehiculo.Estado = "No disponible";
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
