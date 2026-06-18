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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarifas));
            buttonNuevo = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            groupBox = new GroupBox();
            comboBoxVehiculo = new ComboBox();
            textBoxPrecioSemana = new TextBox();
            textBoxPrecioDia = new TextBox();
            labelTipoVehiculo = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            tarifaBindingSource = new BindingSource(components);
            dataGridViewTarifas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            PrecioDia = new DataGridViewTextBoxColumn();
            PrecioSemana = new DataGridViewTextBoxColumn();
            NombreVehiculo = new DataGridViewTextBoxColumn();
            textBoxBuscador = new TextBox();
            labelBuscarPorDni = new Label();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).BeginInit();
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
            buttonNuevo.Location = new Point(12, 22);
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
            buttonEditar.Location = new Point(131, 22);
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
            buttonEliminar.Location = new Point(250, 22);
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
            groupBox.Controls.Add(textBoxPrecioSemana);
            groupBox.Controls.Add(textBoxPrecioDia);
            groupBox.Controls.Add(labelTipoVehiculo);
            groupBox.Controls.Add(labelApellido);
            groupBox.Controls.Add(labelNombre);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(12, 76);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 169);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Tarifa";
            // 
            // comboBoxVehiculo
            // 
            comboBoxVehiculo.BackColor = Color.MidnightBlue;
            comboBoxVehiculo.ForeColor = SystemColors.ButtonFace;
            comboBoxVehiculo.FormattingEnabled = true;
            comboBoxVehiculo.Location = new Point(137, 120);
            comboBoxVehiculo.Name = "comboBoxVehiculo";
            comboBoxVehiculo.Size = new Size(121, 22);
            comboBoxVehiculo.TabIndex = 29;
            // 
            // textBoxPrecioSemana
            // 
            textBoxPrecioSemana.BackColor = Color.MidnightBlue;
            textBoxPrecioSemana.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrecioSemana.Font = new Font("Verdana", 9F);
            textBoxPrecioSemana.ForeColor = SystemColors.ButtonFace;
            textBoxPrecioSemana.Location = new Point(138, 76);
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
            textBoxPrecioDia.Location = new Point(138, 34);
            textBoxPrecioDia.Name = "textBoxPrecioDia";
            textBoxPrecioDia.Size = new Size(121, 22);
            textBoxPrecioDia.TabIndex = 17;
            // 
            // labelTipoVehiculo
            // 
            labelTipoVehiculo.AutoSize = true;
            labelTipoVehiculo.Font = new Font("Verdana", 9F);
            labelTipoVehiculo.Location = new Point(18, 123);
            labelTipoVehiculo.Name = "labelTipoVehiculo";
            labelTipoVehiculo.Size = new Size(113, 14);
            labelTipoVehiculo.TabIndex = 3;
            labelTipoVehiculo.Text = "Tipo de vehiculo:";
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
            buttonCancelar.Location = new Point(250, 264);
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
            buttonGuardar.Location = new Point(12, 264);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 21;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // tarifaBindingSource
            // 
            tarifaBindingSource.DataSource = typeof(Dominio.Tarifa);
            // 
            // dataGridViewTarifas
            // 
            dataGridViewTarifas.AllowUserToOrderColumns = true;
            dataGridViewTarifas.BackgroundColor = Color.MidnightBlue;
            dataGridViewTarifas.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewTarifas.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewTarifas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTarifas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTarifas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTarifas.Columns.AddRange(new DataGridViewColumn[] { Id, PrecioDia, PrecioSemana, NombreVehiculo });
            dataGridViewTarifas.GridColor = Color.MidnightBlue;
            dataGridViewTarifas.Location = new Point(406, 76);
            dataGridViewTarifas.Name = "dataGridViewTarifas";
            dataGridViewTarifas.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewTarifas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTarifas.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewTarifas.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewTarifas.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewTarifas.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewTarifas.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewTarifas.Size = new Size(445, 286);
            dataGridViewTarifas.TabIndex = 31;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // PrecioDia
            // 
            PrecioDia.DataPropertyName = "PrecioDia";
            PrecioDia.HeaderText = "Precio Dia";
            PrecioDia.Name = "PrecioDia";
            PrecioDia.ReadOnly = true;
            // 
            // PrecioSemana
            // 
            PrecioSemana.DataPropertyName = "PrecioSemana";
            PrecioSemana.HeaderText = "Precio Semana";
            PrecioSemana.Name = "PrecioSemana";
            PrecioSemana.ReadOnly = true;
            // 
            // NombreVehiculo
            // 
            NombreVehiculo.DataPropertyName = "TipoVehiculoNombre";
            NombreVehiculo.HeaderText = "Vehiculo";
            NombreVehiculo.Name = "NombreVehiculo";
            NombreVehiculo.ReadOnly = true;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = Color.MidnightBlue;
            textBoxBuscador.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscador.Font = new Font("Verdana", 9F);
            textBoxBuscador.ForeColor = SystemColors.ButtonFace;
            textBoxBuscador.Location = new Point(730, 29);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(121, 22);
            textBoxBuscador.TabIndex = 38;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // labelBuscarPorDni
            // 
            labelBuscarPorDni.AutoSize = true;
            labelBuscarPorDni.Font = new Font("Verdana", 9F);
            labelBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            labelBuscarPorDni.Location = new Point(670, 31);
            labelBuscarPorDni.Name = "labelBuscarPorDni";
            labelBuscarPorDni.Size = new Size(54, 14);
            labelBuscarPorDni.TabIndex = 39;
            labelBuscarPorDni.Text = "Buscar:";
            // 
            // FormTarifas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(951, 388);
            Controls.Add(textBoxBuscador);
            Controls.Add(labelBuscarPorDni);
            Controls.Add(dataGridViewTarifas);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTarifas";
            Text = "Tarifas";
            Load += FormTarifas_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tarifaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTarifas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNuevo;
        private Button buttonEditar;
        private Button buttonEliminar;
        private GroupBox groupBox;
        private TextBox textBoxPrecioSemana;
        private TextBox textBoxPrecioDia;
        private Label labelTipoVehiculo;
        private Label labelApellido;
        private Label labelNombre;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private BindingSource tarifaBindingSource;
        private ComboBox comboBoxVehiculo;
        private DataGridView dataGridViewTarifas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn PrecioDia;
        private DataGridViewTextBoxColumn PrecioSemana;
        private DataGridViewTextBoxColumn NombreVehiculo;
        private TextBox textBoxBuscador;
        private Label labelBuscarPorDni;
    }
}