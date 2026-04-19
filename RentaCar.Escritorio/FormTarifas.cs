using RentaCar.Dominio;
using RentaCar.Infraestructura;
using RentaCar.Infraestructura.Data;
using RentaCar.Infraestructura.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Escritorio
{

    public partial class FormTarifas : Form
    {
        private readonly RentaCarDBContext _context;
        private readonly TarifaRepositorio _repoTarifas;
        private bool modoEdicion = false;
        public FormTarifas()
        {
            _context = new RentaCarDBContext();
            _repoTarifas = new TarifaRepositorio(_context);
            InitializeComponent();
        }
        private void FormTarifas_Load(object sender, EventArgs e)
        {
            BloquearCampos(false);
            CargarTarifas();
            CargarComboBox();
            var tarifas = _repoTarifas.ObtenerTodos();


        }

        private void CargarTarifas()
        {
            List<Tarifa> tarifas = _repoTarifas.ObtenerTodos();
            dataGridViewTarifas.AutoGenerateColumns = false;
            dataGridViewTarifas.DataSource = tarifas;
        }

        private void CargarComboBox()
        {
            var tiposVehiculo = _context.TiposVehiculos.ToList();
            comboBoxVehiculo.DataSource = tiposVehiculo;
            comboBoxVehiculo.DisplayMember = "Nombre";
            comboBoxVehiculo.ValueMember = "Id";

            comboBoxEstado.DataSource = new[]
            {
                new { Texto = "Si", Valor = true },
                new { Texto = "No", Valor = false }
            };

            comboBoxEstado.DisplayMember = "Texto";
            comboBoxEstado.ValueMember = "Valor";

            comboBoxEstado.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;
        }

        private void LimpiarCampos()
        {
            textBoxPrecioDia.Text = "";
            textBoxPrecioSemana.Text = "";
            comboBoxEstado.SelectedIndex = -1;
            comboBoxVehiculo.SelectedIndex = -1;
        }
        private void BloquearCampos(bool estado)
        {
            textBoxPrecioDia.Enabled = estado;
            textBoxPrecioSemana.Enabled = estado;
            comboBoxEstado.Enabled = estado;
            comboBoxVehiculo.Enabled = estado;
        }



        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            BloquearCampos(true);
            LimpiarCampos();
            modoEdicion = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTarifas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna tarifa.");
                return;
            }
            BloquearCampos(true);

            Tarifa tarifa = (Tarifa)dataGridViewTarifas.SelectedRows[0].DataBoundItem;
            textBoxPrecioDia.Text = tarifa.PrecioDia.ToString();
            textBoxPrecioSemana.Text = tarifa.PrecioSemana.ToString();
            comboBoxVehiculo.SelectedValue = tarifa.TipoVehiculoId;
            comboBoxEstado.SelectedValue = tarifa.Activa;

            modoEdicion = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPrecioDia.Text))
            {
                MessageBox.Show("El precio por día es obligatorio.");
                return;
            }

            if (!decimal.TryParse(textBoxPrecioDia.Text, out decimal precioDia))
            {
                MessageBox.Show("El precio por día debe ser numérico.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPrecioSemana.Text))
            {
                MessageBox.Show("El precio por semana es obligatorio.");
                return;
            }

            if (!decimal.TryParse(textBoxPrecioSemana.Text, out decimal precioSemana))
            {
                MessageBox.Show("El precio por semana debe ser numérico.");
                return;
            }

            if (comboBoxEstado.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estado.");
                return;
            }

            if (comboBoxVehiculo.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de vehículo.");
                return;
            }

            var confirm = MessageBox.Show("¿Confirma que desea guardar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;
            Tarifa tarifa;

            if (modoEdicion)
            {
                tarifa = (Tarifa)dataGridViewTarifas.SelectedRows[0].DataBoundItem;
                tarifa.PrecioDia = precioDia;
                tarifa.PrecioSemana = precioSemana;
                tarifa.Activa = (bool)comboBoxEstado.SelectedValue;
                tarifa.TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue;
                _repoTarifas.Actualizar(tarifa);
            }
            else
            {
                tarifa = new Tarifa()
                {
                    PrecioDia = precioDia,
                    PrecioSemana = precioSemana,
                    Activa = (bool)comboBoxEstado.SelectedValue,
                    TipoVehiculoId = (int)comboBoxVehiculo.SelectedValue
                };
                _repoTarifas.Agregar(tarifa);
            }
            _context.SaveChanges();

            CargarTarifas();
            CargarComboBox();
            LimpiarCampos();
            BloquearCampos(false);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            BloquearCampos(false);
            modoEdicion = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridViewTarifas.SelectedRows.Count == 0)
            {
                MessageBox.Show("No seleccionaste ninguna tarifa.");
                return;
            }

            Tarifa tarifa = (Tarifa)dataGridViewTarifas.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show("¿Confirma que desea eliminar esta tarifa?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                _repoTarifas.Eliminar(tarifa.Id);
                _context.SaveChanges();
                CargarTarifas();
                CargarComboBox();
                LimpiarCampos();
                BloquearCampos(false);
                MessageBox.Show("Tarifa eliminada correctamente.");
            }
        }
    }
}
