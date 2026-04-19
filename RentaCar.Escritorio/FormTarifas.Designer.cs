namespace RentaCar.Escritorio
{
    partial class FormTarifas : Form
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
            components = new System.ComponentModel.Container();
            buttonNuevo = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            groupBox = new GroupBox();
            comboBoxVehiculo = new ComboBox();
            comboBoxEstado = new ComboBox();
            textBoxPrecioSemana = new TextBox();
            textBoxPrecioDia = new TextBox();
            labelEmail = new Label();
            labelTelefono = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            dataGridViewTarifas = new DataGridView();
            tarifaBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            precioDiaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            precioSemanaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            activaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            NombreVehiculo = new DataGridViewTextBoxColumn();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = Color.DarkCyan;
            buttonNuevo.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonNuevo.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            buttonNuevo.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonNuevo.FlatStyle = FlatStyle.Flat;
            buttonNuevo.Font = new Font("Verdana", 9F);
            buttonNuevo.ForeColor = SystemColors.ButtonFace;
            buttonNuevo.Location = new Point(24, 22);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
            buttonNuevo.TabIndex = 4;
            buttonNuevo.Text = "Nueva";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.BackColor = Color.DarkMagenta;
            buttonEditar.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonEditar.FlatAppearance.MouseDownBackColor = Color.DarkViolet;
            buttonEditar.FlatAppearance.MouseOverBackColor = Color.Indigo;
            buttonEditar.FlatStyle = FlatStyle.Flat;
            buttonEditar.Font = new Font("Verdana", 9F);
            buttonEditar.ForeColor = SystemColors.ButtonFace;
            buttonEditar.Location = new Point(120, 22);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 5;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Red;
            buttonEliminar.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonEliminar.FlatAppearance.MouseDownBackColor = Color.DarkRed;
            buttonEliminar.FlatAppearance.MouseOverBackColor = Color.Brown;
            buttonEliminar.FlatStyle = FlatStyle.Flat;
            buttonEliminar.Font = new Font("Verdana", 9F);
            buttonEliminar.ForeColor = SystemColors.ButtonFace;
            buttonEliminar.Location = new Point(220, 22);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 6;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(comboBoxVehiculo);
            groupBox.Controls.Add(comboBoxEstado);
            groupBox.Controls.Add(textBoxPrecioSemana);
            groupBox.Controls.Add(textBoxPrecioDia);
            groupBox.Controls.Add(labelEmail);
            groupBox.Controls.Add(labelTelefono);
            groupBox.Controls.Add(labelApellido);
            groupBox.Controls.Add(labelNombre);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(12, 90);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 187);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Tarifa";
            // 
            // comboBoxVehiculo
            // 
            comboBoxVehiculo.BackColor = Color.MidnightBlue;
            comboBoxVehiculo.ForeColor = SystemColors.ButtonFace;
            comboBoxVehiculo.FormattingEnabled = true;
            comboBoxVehiculo.Location = new Point(129, 150);
            comboBoxVehiculo.Name = "comboBoxVehiculo";
            comboBoxVehiculo.Size = new Size(121, 22);
            comboBoxVehiculo.TabIndex = 29;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.MidnightBlue;
            comboBoxEstado.ForeColor = SystemColors.ButtonFace;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(129, 118);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 22);
            comboBoxEstado.TabIndex = 28;
            // 
            // textBoxPrecioSemana
            // 
            textBoxPrecioSemana.BackColor = Color.MidnightBlue;
            textBoxPrecioSemana.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrecioSemana.Font = new Font("Verdana", 9F);
            textBoxPrecioSemana.ForeColor = SystemColors.ButtonFace;
            textBoxPrecioSemana.Location = new Point(129, 76);
            textBoxPrecioSemana.Name = "textBoxPrecioSemana";
            textBoxPrecioSemana.Size = new Size(121, 22);
            textBoxPrecioSemana.TabIndex = 18;
            // 
            // textBoxPrecioDia
            // 
            textBoxPrecioDia.BackColor = Color.MidnightBlue;
            textBoxPrecioDia.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrecioDia.Font = new Font("Verdana", 9F);
            textBoxPrecioDia.ForeColor = SystemColors.ButtonFace;
            textBoxPrecioDia.Location = new Point(129, 34);
            textBoxPrecioDia.Name = "textBoxPrecioDia";
            textBoxPrecioDia.Size = new Size(121, 22);
            textBoxPrecioDia.TabIndex = 17;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 9F);
            labelEmail.Location = new Point(19, 118);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 14);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Activa:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Verdana", 9F);
            labelTelefono.Location = new Point(19, 153);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(63, 14);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Vehiculo:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Verdana", 9F);
            labelApellido.Location = new Point(18, 78);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(105, 14);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Precio Semana:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Verdana", 9F);
            labelNombre.Location = new Point(19, 36);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(74, 14);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Precio Dia:";
            // 
            // buttonCancelar
            // 
            buttonCancelar.BackColor = Color.FromArgb(64, 64, 64);
            buttonCancelar.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonCancelar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonCancelar.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonCancelar.FlatStyle = FlatStyle.Flat;
            buttonCancelar.Font = new Font("Verdana", 9F);
            buttonCancelar.ForeColor = SystemColors.ButtonFace;
            buttonCancelar.Location = new Point(250, 303);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 22;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.FromArgb(64, 64, 64);
            buttonGuardar.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonGuardar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonGuardar.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonGuardar.FlatStyle = FlatStyle.Flat;
            buttonGuardar.Font = new Font("Verdana", 9F);
            buttonGuardar.ForeColor = SystemColors.ButtonFace;
            buttonGuardar.Location = new Point(12, 303);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // dataGridViewTarifas
            // 
            dataGridViewTarifas.AutoGenerateColumns = false;
            dataGridViewTarifas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifas.Columns.AddRange(new DataGridViewColumn[] { Id, precioDiaDataGridViewTextBoxColumn, precioSemanaDataGridViewTextBoxColumn, activaDataGridViewCheckBoxColumn, NombreVehiculo });
            dataGridViewTarifas.DataSource = tarifaBindingSource;
            dataGridViewTarifas.Location = new Point(355, 59);
            dataGridViewTarifas.Name = "dataGridViewTarifas";
            dataGridViewTarifas.ReadOnly = true;
            dataGridViewTarifas.Size = new Size(544, 277);
            dataGridViewTarifas.TabIndex = 23;
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(Dominio.Tarifa);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // precioDiaDataGridViewTextBoxColumn
            // 
            precioDiaDataGridViewTextBoxColumn.DataPropertyName = "PrecioDia";
            precioDiaDataGridViewTextBoxColumn.HeaderText = "Precio Dia";
            precioDiaDataGridViewTextBoxColumn.Name = "precioDiaDataGridViewTextBoxColumn";
            precioDiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioSemanaDataGridViewTextBoxColumn
            // 
            precioSemanaDataGridViewTextBoxColumn.DataPropertyName = "PrecioSemana";
            precioSemanaDataGridViewTextBoxColumn.HeaderText = "Precio Semana";
            precioSemanaDataGridViewTextBoxColumn.Name = "precioSemanaDataGridViewTextBoxColumn";
            precioSemanaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activaDataGridViewCheckBoxColumn
            // 
            activaDataGridViewCheckBoxColumn.DataPropertyName = "Activa";
            activaDataGridViewCheckBoxColumn.HeaderText = "Activa";
            activaDataGridViewCheckBoxColumn.Name = "activaDataGridViewCheckBoxColumn";
            activaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // NombreVehiculo
            // 
            NombreVehiculo.DataPropertyName = "NombreVehiculo";
            NombreVehiculo.HeaderText = "Vehiculo";
            NombreVehiculo.Name = "NombreVehiculo";
            NombreVehiculo.ReadOnly = true;
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(939, 395);
            Controls.Add(dataGridViewTarifas);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Name = "FormTarifas";
            Text = "Tarifas";
            Load += FormTarifas_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonNuevo;
        private Button buttonEditar;
        private Button buttonEliminar;
        private GroupBox groupBox;
        private TextBox textBoxPrecioSemana;
        private TextBox textBoxPrecioDia;
        private Label labelEmail;
        private Label labelTelefono;
        private Label labelApellido;
        private Label labelNombre;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private ComboBox comboBoxEstado;
        private DataGridView dataGridViewTarifas;
        private BindingSource tarifaBindingSource;
        private ComboBox comboBoxVehiculo;
        private DataGridViewTextBoxColumn tipoVehiculoIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn precioDiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn precioSemanaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn NombreVehiculo;
    }
}