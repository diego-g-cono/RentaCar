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
            grBoxReservas = new GroupBox();
            cmbBoxEstado = new ComboBox();
            labelEstado = new Label();
            numBoxSenia = new NumericUpDown();
            dateTimeFechaDevolucion = new DateTimePicker();
            dateTimeFechaRetiro = new DateTimePicker();
            txtBoxVehiculo = new TextBox();
            txtBoxCliente = new TextBox();
            labelSenia = new Label();
            labelFechaDevolucion = new Label();
            labelFechaRetiro = new Label();
            labelVehiculo = new Label();
            labelCliente = new Label();
            tabControlReservas = new TabControl();
            tabPageReservas = new TabPage();
            dataGridViewReservas = new DataGridView();
            ColumnaId = new DataGridViewTextBoxColumn();
            ColumnaCliente = new DataGridViewTextBoxColumn();
            ColumnaVehiculo = new DataGridViewTextBoxColumn();
            ColumnaFechaRetiro = new DataGridViewTextBoxColumn();
            ColumnaFechaDevolucion = new DataGridViewTextBoxColumn();
            ColumnaEstadoR = new DataGridViewTextBoxColumn();
            ColumnaSenia = new DataGridViewTextBoxColumn();
            tabPageClientes = new TabPage();
            dataGridViewClientes = new DataGridView();
            ColumnaDNI = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaUsuario = new DataGridViewTextBoxColumn();
            ColumnaContrasenia = new DataGridViewTextBoxColumn();
            tabPageVehiculos = new TabPage();
            dataGridViewVehiculos = new DataGridView();
            ColumnaPatente = new DataGridViewTextBoxColumn();
            ColumnaMarca = new DataGridViewTextBoxColumn();
            ColumnaModelo = new DataGridViewTextBoxColumn();
            ColumnaAnio = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaCombustible = new DataGridViewTextBoxColumn();
            ColumnaKm = new DataGridViewTextBoxColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            btnGuardar = new Button();
            btnCancelar = new Button();
            grBoxReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxSenia).BeginInit();
            tabControlReservas.SuspendLayout();
            tabPageReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            tabPageClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tabPageVehiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
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
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(144, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(275, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // grBoxReservas
            // 
            grBoxReservas.Controls.Add(cmbBoxEstado);
            grBoxReservas.Controls.Add(labelEstado);
            grBoxReservas.Controls.Add(numBoxSenia);
            grBoxReservas.Controls.Add(dateTimeFechaDevolucion);
            grBoxReservas.Controls.Add(dateTimeFechaRetiro);
            grBoxReservas.Controls.Add(txtBoxVehiculo);
            grBoxReservas.Controls.Add(txtBoxCliente);
            grBoxReservas.Controls.Add(labelSenia);
            grBoxReservas.Controls.Add(labelFechaDevolucion);
            grBoxReservas.Controls.Add(labelFechaRetiro);
            grBoxReservas.Controls.Add(labelVehiculo);
            grBoxReservas.Controls.Add(labelCliente);
            grBoxReservas.Location = new Point(12, 53);
            grBoxReservas.Name = "grBoxReservas";
            grBoxReservas.Size = new Size(338, 239);
            grBoxReservas.TabIndex = 3;
            grBoxReservas.TabStop = false;
            grBoxReservas.Text = "Datos Reserva";
            // 
            // cmbBoxEstado
            // 
            cmbBoxEstado.FormattingEnabled = true;
            cmbBoxEstado.Location = new Point(118, 197);
            cmbBoxEstado.Name = "cmbBoxEstado";
            cmbBoxEstado.Size = new Size(121, 23);
            cmbBoxEstado.TabIndex = 11;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(6, 200);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(45, 15);
            labelEstado.TabIndex = 10;
            labelEstado.Text = "Estado:";
            // 
            // numBoxSenia
            // 
            numBoxSenia.Location = new Point(118, 158);
            numBoxSenia.Name = "numBoxSenia";
            numBoxSenia.Size = new Size(120, 23);
            numBoxSenia.TabIndex = 9;
            // 
            // dateTimeFechaDevolucion
            // 
            dateTimeFechaDevolucion.Location = new Point(118, 125);
            dateTimeFechaDevolucion.Name = "dateTimeFechaDevolucion";
            dateTimeFechaDevolucion.Size = new Size(200, 23);
            dateTimeFechaDevolucion.TabIndex = 8;
            // 
            // dateTimeFechaRetiro
            // 
            dateTimeFechaRetiro.Location = new Point(118, 88);
            dateTimeFechaRetiro.Name = "dateTimeFechaRetiro";
            dateTimeFechaRetiro.Size = new Size(200, 23);
            dateTimeFechaRetiro.TabIndex = 7;
            dateTimeFechaRetiro.ValueChanged += dateTimeFechaRetiro_ValueChanged;
            // 
            // txtBoxVehiculo
            // 
            txtBoxVehiculo.Location = new Point(118, 51);
            txtBoxVehiculo.Name = "txtBoxVehiculo";
            txtBoxVehiculo.Size = new Size(100, 23);
            txtBoxVehiculo.TabIndex = 6;
            // 
            // txtBoxCliente
            // 
            txtBoxCliente.Location = new Point(118, 19);
            txtBoxCliente.Name = "txtBoxCliente";
            txtBoxCliente.Size = new Size(100, 23);
            txtBoxCliente.TabIndex = 5;
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
            // labelFechaDevolucion
            // 
            labelFechaDevolucion.AutoSize = true;
            labelFechaDevolucion.Location = new Point(6, 131);
            labelFechaDevolucion.Name = "labelFechaDevolucion";
            labelFechaDevolucion.Size = new Size(103, 15);
            labelFechaDevolucion.TabIndex = 3;
            labelFechaDevolucion.Text = "Fecha devolución:";
            // 
            // labelFechaRetiro
            // 
            labelFechaRetiro.AutoSize = true;
            labelFechaRetiro.Location = new Point(6, 94);
            labelFechaRetiro.Name = "labelFechaRetiro";
            labelFechaRetiro.Size = new Size(72, 15);
            labelFechaRetiro.TabIndex = 2;
            labelFechaRetiro.Text = "Fecha retiro:";
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
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(6, 22);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(47, 15);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente:";
            // 
            // tabControlReservas
            // 
            tabControlReservas.Controls.Add(tabPageReservas);
            tabControlReservas.Controls.Add(tabPageClientes);
            tabControlReservas.Controls.Add(tabPageVehiculos);
            tabControlReservas.Location = new Point(365, 53);
            tabControlReservas.Name = "tabControlReservas";
            tabControlReservas.SelectedIndex = 0;
            tabControlReservas.Size = new Size(856, 294);
            tabControlReservas.TabIndex = 4;
            tabControlReservas.Click += tabControlReservas_Click;
            // 
            // tabPageReservas
            // 
            tabPageReservas.Controls.Add(dataGridViewReservas);
            tabPageReservas.Location = new Point(4, 24);
            tabPageReservas.Name = "tabPageReservas";
            tabPageReservas.Padding = new Padding(3);
            tabPageReservas.Size = new Size(848, 266);
            tabPageReservas.TabIndex = 0;
            tabPageReservas.Text = "Reservas";
            tabPageReservas.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.AllowUserToAddRows = false;
            dataGridViewReservas.AllowUserToDeleteRows = false;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReservas.Columns.AddRange(new DataGridViewColumn[] { ColumnaId, ColumnaCliente, ColumnaVehiculo, ColumnaFechaRetiro, ColumnaFechaDevolucion, ColumnaEstadoR, ColumnaSenia });
            dataGridViewReservas.Location = new Point(0, 0);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewReservas.ReadOnly = true;
            dataGridViewReservas.Size = new Size(743, 263);
            dataGridViewReservas.TabIndex = 0;
            // 
            // ColumnaId
            // 
            ColumnaId.DataPropertyName = "IdReserva";
            ColumnaId.HeaderText = "ID";
            ColumnaId.Name = "ColumnaId";
            ColumnaId.ReadOnly = true;
            // 
            // ColumnaCliente
            // 
            ColumnaCliente.DataPropertyName = "ClienteDni";
            ColumnaCliente.HeaderText = "Cliente";
            ColumnaCliente.Name = "ColumnaCliente";
            ColumnaCliente.ReadOnly = true;
            // 
            // ColumnaVehiculo
            // 
            ColumnaVehiculo.DataPropertyName = "VehiculoPatente";
            ColumnaVehiculo.HeaderText = "Vehículo";
            ColumnaVehiculo.Name = "ColumnaVehiculo";
            ColumnaVehiculo.ReadOnly = true;
            // 
            // ColumnaFechaRetiro
            // 
            ColumnaFechaRetiro.DataPropertyName = "FechaInicio";
            ColumnaFechaRetiro.HeaderText = "Fecha Retiro";
            ColumnaFechaRetiro.Name = "ColumnaFechaRetiro";
            ColumnaFechaRetiro.ReadOnly = true;
            // 
            // ColumnaFechaDevolucion
            // 
            ColumnaFechaDevolucion.DataPropertyName = "FechaFin";
            ColumnaFechaDevolucion.HeaderText = "Fecha Devolución";
            ColumnaFechaDevolucion.Name = "ColumnaFechaDevolucion";
            ColumnaFechaDevolucion.ReadOnly = true;
            // 
            // ColumnaEstadoR
            // 
            ColumnaEstadoR.DataPropertyName = "Estado";
            ColumnaEstadoR.HeaderText = "Estado";
            ColumnaEstadoR.Name = "ColumnaEstadoR";
            ColumnaEstadoR.ReadOnly = true;
            // 
            // ColumnaSenia
            // 
            ColumnaSenia.DataPropertyName = "Senia";
            ColumnaSenia.HeaderText = "Seña";
            ColumnaSenia.Name = "ColumnaSenia";
            ColumnaSenia.ReadOnly = true;
            // 
            // tabPageClientes
            // 
            tabPageClientes.Controls.Add(dataGridViewClientes);
            tabPageClientes.Location = new Point(4, 24);
            tabPageClientes.Name = "tabPageClientes";
            tabPageClientes.Padding = new Padding(3);
            tabPageClientes.Size = new Size(848, 266);
            tabPageClientes.TabIndex = 1;
            tabPageClientes.Text = "Clientes";
            tabPageClientes.UseVisualStyleBackColor = true;
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
            dataGridViewClientes.CellDoubleClick += dataGridViewClientes_CellDoubleClick;
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
            // tabPageVehiculos
            // 
            tabPageVehiculos.Controls.Add(dataGridViewVehiculos);
            tabPageVehiculos.Location = new Point(4, 24);
            tabPageVehiculos.Name = "tabPageVehiculos";
            tabPageVehiculos.Padding = new Padding(3);
            tabPageVehiculos.Size = new Size(848, 266);
            tabPageVehiculos.TabIndex = 2;
            tabPageVehiculos.Text = "Vehículos";
            tabPageVehiculos.UseVisualStyleBackColor = true;
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
            dataGridViewVehiculos.Size = new Size(845, 262);
            dataGridViewVehiculos.TabIndex = 7;
            dataGridViewVehiculos.CellDoubleClick += dataGridViewVehiculos_CellDoubleClick;
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
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 315);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(275, 315);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 585);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(tabControlReservas);
            Controls.Add(grBoxReservas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "FrmReservas";
            Text = "Reservas";
            Load += FrmReservas_Load;
            grBoxReservas.ResumeLayout(false);
            grBoxReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxSenia).EndInit();
            tabControlReservas.ResumeLayout(false);
            tabPageReservas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            tabPageClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tabPageVehiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnModificar;
        private Button btnEliminar;
        private GroupBox grBoxReservas;
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
        private DataGridView dataGridViewReservas;
        private DataGridView dataGridViewVehiculos;
        private DataGridViewTextBoxColumn ColumnaPatente;
        private DataGridViewTextBoxColumn ColumnaMarca;
        private DataGridViewTextBoxColumn ColumnaModelo;
        private DataGridViewTextBoxColumn ColumnaAnio;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaCombustible;
        private DataGridViewTextBoxColumn ColumnaKm;
        private DataGridViewTextBoxColumn ColumnaEstado;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbBoxEstado;
        private Label labelEstado;
        private DataGridViewTextBoxColumn ColumnaId;
        private DataGridViewTextBoxColumn ColumnaCliente;
        private DataGridViewTextBoxColumn ColumnaVehiculo;
        private DataGridViewTextBoxColumn ColumnaFechaRetiro;
        private DataGridViewTextBoxColumn ColumnaFechaDevolucion;
        private DataGridViewTextBoxColumn ColumnaEstadoR;
        private DataGridViewTextBoxColumn ColumnaSenia;
    }
}