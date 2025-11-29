namespace Escritorio
{
    partial class FrmReservas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnNuevo = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBoxReservas = new GroupBox();
            tabControlReservas = new TabControl();
            tabPageReservas = new TabPage();
            tabPageClientes = new TabPage();
            labelCliente = new Label();
            labelVehiculo = new Label();
            labelFechaRetiro = new Label();
            labelFechaDevolucion = new Label();
            labelSenia = new Label();
            txtBoxCliente = new TextBox();
            txtBoxVehiculo = new TextBox();
            dateTimeFechaRetiro = new DateTimePicker();
            dateTimeFechaDevolucion = new DateTimePicker();
            numBoxSenia = new NumericUpDown();
            tabPageVehiculos = new TabPage();
            dataGridViewClientes = new DataGridView();
            ColumnaDNI = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaUsuario = new DataGridViewTextBoxColumn();
            ColumnaContrasenia = new DataGridViewTextBoxColumn();
            dataGridViewVehiculos = new DataGridView();
            ColumnaPatente = new DataGridViewTextBoxColumn();
            ColumnaMarca = new DataGridViewTextBoxColumn();
            ColumnaModelo = new DataGridViewTextBoxColumn();
            ColumnaAnio = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaCombustible = new DataGridViewTextBoxColumn();
            ColumnaKm = new DataGridViewTextBoxColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            dataGridView1 = new DataGridView();
            groupBoxReservas.SuspendLayout();
            tabControlReservas.SuspendLayout();
            tabPageReservas.SuspendLayout();
            tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxSenia).BeginInit();
            tabPageVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nueva";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(115, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(214, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxReservas
            // 
            groupBoxReservas.Controls.Add(numBoxSenia);
            groupBoxReservas.Controls.Add(dateTimeFechaDevolucion);
            groupBoxReservas.Controls.Add(dateTimeFechaRetiro);
            groupBoxReservas.Controls.Add(txtBoxVehiculo);
            groupBoxReservas.Controls.Add(txtBoxCliente);
            groupBoxReservas.Controls.Add(labelSenia);
            groupBoxReservas.Controls.Add(labelFechaDevolucion);
            groupBoxReservas.Controls.Add(labelFechaRetiro);
            groupBoxReservas.Controls.Add(labelVehiculo);
            groupBoxReservas.Controls.Add(labelCliente);
            groupBoxReservas.Location = new Point(12, 53);
            groupBoxReservas.Name = "groupBoxReservas";
            groupBoxReservas.Size = new Size(338, 211);
            groupBoxReservas.TabIndex = 3;
            groupBoxReservas.TabStop = false;
            groupBoxReservas.Text = "Datos Reserva";
            // 
            // tabControlReservas
            // 
            tabControlReservas.Controls.Add(tabPageReservas);
            tabControlReservas.Controls.Add(tabPageClientes);
            tabControlReservas.Controls.Add(tabPageVehiculos);
            tabControlReservas.Location = new Point(365, 53);
            tabControlReservas.Name = "tabControlReservas";
            tabControlReservas.SelectedIndex = 0;
            tabControlReservas.Size = new Size(856, 295);
            tabControlReservas.TabIndex = 4;
            // 
            // tabPageReservas
            // 
            tabPageReservas.Controls.Add(dataGridView1);
            tabPageReservas.Location = new Point(4, 24);
            tabPageReservas.Name = "tabPageReservas";
            tabPageReservas.Padding = new Padding(3);
            tabPageReservas.Size = new Size(848, 267);
            tabPageReservas.TabIndex = 0;
            tabPageReservas.Text = "Reservas";
            tabPageReservas.UseVisualStyleBackColor = true;
            // 
            // tabPageClientes
            // 
            tabPageClientes.Controls.Add(dataGridViewClientes);
            tabPageClientes.Location = new Point(4, 24);
            tabPageClientes.Name = "tabPageClientes";
            tabPageClientes.Padding = new Padding(3);
            tabPageClientes.Size = new Size(848, 267);
            tabPageClientes.TabIndex = 1;
            tabPageClientes.Text = "Clientes";
            tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(6, 22);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(47, 15);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente:";
            // 
            // labelVehiculo
            // 
            labelVehiculo.AutoSize = true;
            labelVehiculo.Location = new Point(6, 54);
            labelVehiculo.Name = "labelVehiculo";
            labelVehiculo.Size = new Size(55, 15);
            labelVehiculo.TabIndex = 1;
            labelVehiculo.Text = "Vehículo:";
            // 
            // labelFechaRetiro
            // 
            labelFechaRetiro.AutoSize = true;
            labelFechaRetiro.Location = new Point(3, 94);
            labelFechaRetiro.Name = "labelFechaRetiro";
            labelFechaRetiro.Size = new Size(72, 15);
            labelFechaRetiro.TabIndex = 2;
            labelFechaRetiro.Text = "Fecha retiro:";
            // 
            // labelFechaDevolucion
            // 
            labelFechaDevolucion.AutoSize = true;
            labelFechaDevolucion.Location = new Point(6, 131);
            labelFechaDevolucion.Name = "labelFechaDevolucion";
            labelFechaDevolucion.Size = new Size(103, 15);
            labelFechaDevolucion.TabIndex = 3;
            labelFechaDevolucion.Text = "Fecha devolución:";
            // 
            // labelSenia
            // 
            labelSenia.AutoSize = true;
            labelSenia.Location = new Point(6, 160);
            labelSenia.Name = "labelSenia";
            labelSenia.Size = new Size(35, 15);
            labelSenia.TabIndex = 4;
            labelSenia.Text = "Seña:";
            // 
            // txtBoxCliente
            // 
            txtBoxCliente.Location = new Point(118, 19);
            txtBoxCliente.Name = "txtBoxCliente";
            txtBoxCliente.Size = new Size(100, 23);
            txtBoxCliente.TabIndex = 5;
            // 
            // txtBoxVehiculo
            // 
            txtBoxVehiculo.Location = new Point(118, 51);
            txtBoxVehiculo.Name = "txtBoxVehiculo";
            txtBoxVehiculo.Size = new Size(100, 23);
            txtBoxVehiculo.TabIndex = 6;
            // 
            // dateTimeFechaRetiro
            // 
            dateTimeFechaRetiro.Location = new Point(118, 88);
            dateTimeFechaRetiro.Name = "dateTimeFechaRetiro";
            dateTimeFechaRetiro.Size = new Size(200, 23);
            dateTimeFechaRetiro.TabIndex = 7;
            // 
            // dateTimeFechaDevolucion
            // 
            dateTimeFechaDevolucion.Location = new Point(118, 125);
            dateTimeFechaDevolucion.Name = "dateTimeFechaDevolucion";
            dateTimeFechaDevolucion.Size = new Size(200, 23);
            dateTimeFechaDevolucion.TabIndex = 8;
            // 
            // numBoxSenia
            // 
            numBoxSenia.Location = new Point(118, 158);
            numBoxSenia.Name = "numBoxSenia";
            numBoxSenia.Size = new Size(120, 23);
            numBoxSenia.TabIndex = 9;
            // 
            // tabPageVehiculos
            // 
            tabPageVehiculos.Controls.Add(dataGridViewVehiculos);
            tabPageVehiculos.Location = new Point(4, 24);
            tabPageVehiculos.Name = "tabPageVehiculos";
            tabPageVehiculos.Padding = new Padding(3);
            tabPageVehiculos.Size = new Size(848, 267);
            tabPageVehiculos.TabIndex = 2;
            tabPageVehiculos.Text = "Vehículos";
            tabPageVehiculos.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnaDNI, ColumnaNombre, ColumnaApellido, ColumnaUsuario, ColumnaContrasenia });
            dataGridViewClientes.Location = new Point(3, 1);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(838, 256);
            dataGridViewClientes.TabIndex = 6;
            // 
            // ColumnaDNI
            // 
            ColumnaDNI.DataPropertyName = "DNI";
            ColumnaDNI.HeaderText = "DNI";
            ColumnaDNI.Name = "ColumnaDNI";
            ColumnaDNI.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            ColumnaNombre.DataPropertyName = "Nombre";
            ColumnaNombre.HeaderText = "Nombre";
            ColumnaNombre.Name = "ColumnaNombre";
            ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaApellido
            // 
            ColumnaApellido.DataPropertyName = "Apellido";
            ColumnaApellido.HeaderText = "Apellido";
            ColumnaApellido.Name = "ColumnaApellido";
            ColumnaApellido.ReadOnly = true;
            // 
            // ColumnaUsuario
            // 
            ColumnaUsuario.DataPropertyName = "Usuario";
            ColumnaUsuario.HeaderText = "Usuario";
            ColumnaUsuario.Name = "ColumnaUsuario";
            ColumnaUsuario.ReadOnly = true;
            // 
            // ColumnaContrasenia
            // 
            ColumnaContrasenia.DataPropertyName = "ContraseñaHash";
            ColumnaContrasenia.HeaderText = "Contraseña";
            ColumnaContrasenia.Name = "ColumnaContrasenia";
            ColumnaContrasenia.ReadOnly = true;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.AllowUserToAddRows = false;
            dataGridViewVehiculos.AllowUserToDeleteRows = false;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Columns.AddRange(new DataGridViewColumn[] { ColumnaPatente, ColumnaMarca, ColumnaModelo, ColumnaAnio, ColumnaColor, ColumnaCombustible, ColumnaKm, ColumnaEstado });
            dataGridViewVehiculos.Location = new Point(0, 1);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.ReadOnly = true;
            dataGridViewVehiculos.Size = new Size(845, 260);
            dataGridViewVehiculos.TabIndex = 7;
            // 
            // ColumnaPatente
            // 
            ColumnaPatente.DataPropertyName = "Patente";
            ColumnaPatente.HeaderText = "Patente";
            ColumnaPatente.Name = "ColumnaPatente";
            ColumnaPatente.ReadOnly = true;
            // 
            // ColumnaMarca
            // 
            ColumnaMarca.DataPropertyName = "Marca";
            ColumnaMarca.HeaderText = "Marca";
            ColumnaMarca.Name = "ColumnaMarca";
            ColumnaMarca.ReadOnly = true;
            // 
            // ColumnaModelo
            // 
            ColumnaModelo.DataPropertyName = "Modelo";
            ColumnaModelo.HeaderText = "Modelo";
            ColumnaModelo.Name = "ColumnaModelo";
            ColumnaModelo.ReadOnly = true;
            // 
            // ColumnaAnio
            // 
            ColumnaAnio.DataPropertyName = "Anio";
            ColumnaAnio.HeaderText = "Año";
            ColumnaAnio.Name = "ColumnaAnio";
            ColumnaAnio.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.DataPropertyName = "Color";
            ColumnaColor.HeaderText = "Color";
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // ColumnaCombustible
            // 
            ColumnaCombustible.DataPropertyName = "TipoCombustible";
            ColumnaCombustible.HeaderText = "Combustible";
            ColumnaCombustible.Name = "ColumnaCombustible";
            ColumnaCombustible.ReadOnly = true;
            // 
            // ColumnaKm
            // 
            ColumnaKm.DataPropertyName = "Kilometraje";
            ColumnaKm.HeaderText = "Km";
            ColumnaKm.Name = "ColumnaKm";
            ColumnaKm.ReadOnly = true;
            // 
            // ColumnaEstado
            // 
            ColumnaEstado.DataPropertyName = "Estado";
            ColumnaEstado.HeaderText = "Estado";
            ColumnaEstado.Name = "ColumnaEstado";
            ColumnaEstado.ReadOnly = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(841, 260);
            dataGridView1.TabIndex = 0;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1309, 612);
            Controls.Add(tabControlReservas);
            Controls.Add(groupBoxReservas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "FrmReservas";
            Text = "Reservas";
            groupBoxReservas.ResumeLayout(false);
            groupBoxReservas.PerformLayout();
            tabControlReservas.ResumeLayout(false);
            tabPageReservas.ResumeLayout(false);
            tabPageClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numBoxSenia).EndInit();
            tabPageVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox groupBoxReservas;
        private TabControl tabControlReservas;
        private TabPage tabPageReservas;
        private TabPage tabPageClientes;
        private Label labelSenia;
        private Label labelFechaDevolucion;
        private Label labelFechaRetiro;
        private Label labelVehiculo;
        private Label labelCliente;
        private NumericUpDown numBoxSenia;
        private DateTimePicker dateTimeFechaDevolucion;
        private DateTimePicker dateTimeFechaRetiro;
        private TextBox txtBoxVehiculo;
        private TextBox txtBoxCliente;
        private TabPage tabPageVehiculos;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn ColumnaDNI;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaContrasenia;
        private DataGridView dataGridView1;
        private DataGridView dataGridViewVehiculos;
        private DataGridViewTextBoxColumn ColumnaPatente;
        private DataGridViewTextBoxColumn ColumnaMarca;
        private DataGridViewTextBoxColumn ColumnaModelo;
        private DataGridViewTextBoxColumn ColumnaAnio;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaCombustible;
        private DataGridViewTextBoxColumn ColumnaKm;
        private DataGridViewTextBoxColumn ColumnaEstado;
    }
}