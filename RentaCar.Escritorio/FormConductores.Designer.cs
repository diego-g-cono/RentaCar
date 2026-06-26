namespace RentaCar.Escritorio
{
    partial class FormConductores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConductores));
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBoxConductores = new GroupBox();
            dateTimePickerVencLic = new DateTimePicker();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDni = new TextBox();
            labelNombreCond = new Label();
            labelApellidoCond = new Label();
            labelDni = new Label();
            labelVencLic = new Label();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            conductorBindingSource = new BindingSource(components);
            dataGridViewConductores = new DataGridView();
            ColumnDNI = new DataGridViewTextBoxColumn();
            fechaVencLic = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            labelBuscarPorDni = new Label();
            textBoxBuscador = new TextBox();
            buttonRecargar = new Button();
            groupBoxConductores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConductores).BeginInit();
            SuspendLayout();
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
            buttonCancelar.Location = new Point(298, 429);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 44);
            buttonCancelar.TabIndex = 28;
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
            buttonGuardar.Location = new Point(26, 429);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(88, 44);
            buttonGuardar.TabIndex = 27;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // groupBoxConductores
            // 
            groupBoxConductores.Controls.Add(dateTimePickerVencLic);
            groupBoxConductores.Controls.Add(textBoxApellido);
            groupBoxConductores.Controls.Add(textBoxNombre);
            groupBoxConductores.Controls.Add(textBoxDni);
            groupBoxConductores.Controls.Add(labelNombreCond);
            groupBoxConductores.Controls.Add(labelApellidoCond);
            groupBoxConductores.Controls.Add(labelDni);
            groupBoxConductores.Controls.Add(labelVencLic);
            groupBoxConductores.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBoxConductores.ForeColor = SystemColors.ButtonFace;
            groupBoxConductores.Location = new Point(26, 109);
            groupBoxConductores.Margin = new Padding(3, 4, 3, 4);
            groupBoxConductores.Name = "groupBoxConductores";
            groupBoxConductores.Padding = new Padding(3, 4, 3, 4);
            groupBoxConductores.Size = new Size(360, 288);
            groupBoxConductores.TabIndex = 26;
            groupBoxConductores.TabStop = false;
            groupBoxConductores.Text = "Conductor";
            // 
            // dateTimePickerVencLic
            // 
            dateTimePickerVencLic.Location = new Point(147, 39);
            dateTimePickerVencLic.Margin = new Padding(3, 4, 3, 4);
            dateTimePickerVencLic.Name = "dateTimePickerVencLic";
            dateTimePickerVencLic.Size = new Size(138, 26);
            dateTimePickerVencLic.TabIndex = 30;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.MidnightBlue;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Font = new Font("Verdana", 9F);
            textBoxApellido.ForeColor = SystemColors.ButtonFace;
            textBoxApellido.Location = new Point(147, 204);
            textBoxApellido.Margin = new Padding(3, 4, 3, 4);
            textBoxApellido.MaxLength = 30;
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ShortcutsEnabled = false;
            textBoxApellido.Size = new Size(138, 26);
            textBoxApellido.TabIndex = 20;
            textBoxApellido.KeyPress += textBoxApellido_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.MidnightBlue;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Verdana", 9F);
            textBoxNombre.ForeColor = SystemColors.ButtonFace;
            textBoxNombre.Location = new Point(147, 155);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.MaxLength = 30;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ShortcutsEnabled = false;
            textBoxNombre.Size = new Size(138, 26);
            textBoxNombre.TabIndex = 19;
            textBoxNombre.KeyPress += textBoxNombre_KeyPress;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = Color.MidnightBlue;
            textBoxDni.BorderStyle = BorderStyle.FixedSingle;
            textBoxDni.Font = new Font("Verdana", 9F);
            textBoxDni.ForeColor = SystemColors.ButtonFace;
            textBoxDni.Location = new Point(147, 101);
            textBoxDni.Margin = new Padding(3, 4, 3, 4);
            textBoxDni.MaxLength = 8;
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ShortcutsEnabled = false;
            textBoxDni.Size = new Size(138, 26);
            textBoxDni.TabIndex = 18;
            textBoxDni.KeyPress += textBoxDni_KeyPress;
            // 
            // labelNombreCond
            // 
            labelNombreCond.AutoSize = true;
            labelNombreCond.Font = new Font("Verdana", 9F);
            labelNombreCond.Location = new Point(22, 157);
            labelNombreCond.Name = "labelNombreCond";
            labelNombreCond.Size = new Size(75, 18);
            labelNombreCond.TabIndex = 16;
            labelNombreCond.Text = "Nombre:";
            // 
            // labelApellidoCond
            // 
            labelApellidoCond.AutoSize = true;
            labelApellidoCond.Font = new Font("Verdana", 9F);
            labelApellidoCond.Location = new Point(22, 207);
            labelApellidoCond.Name = "labelApellidoCond";
            labelApellidoCond.Size = new Size(71, 18);
            labelApellidoCond.TabIndex = 3;
            labelApellidoCond.Text = "Apellido:";
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Verdana", 9F);
            labelDni.Location = new Point(22, 104);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(42, 18);
            labelDni.TabIndex = 2;
            labelDni.Text = "DNI:";
            // 
            // labelVencLic
            // 
            labelVencLic.AutoSize = true;
            labelVencLic.Font = new Font("Verdana", 9F);
            labelVencLic.Location = new Point(22, 47);
            labelVencLic.Name = "labelVencLic";
            labelVencLic.Size = new Size(116, 18);
            labelVencLic.TabIndex = 1;
            labelVencLic.Text = "Vence licencia:";
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
            buttonEliminar.Location = new Point(298, 29);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 44);
            buttonEliminar.TabIndex = 25;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += buttonEliminar_Click;
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
            buttonEditar.Location = new Point(161, 29);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(88, 44);
            buttonEditar.TabIndex = 24;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += buttonEditar_Click;
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
            buttonNuevo.Location = new Point(26, 29);
            buttonNuevo.Margin = new Padding(3, 4, 3, 4);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(88, 44);
            buttonNuevo.TabIndex = 23;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // conductorBindingSource
            // 
            conductorBindingSource.DataSource = typeof(Dominio.Conductor);
            // 
            // dataGridViewConductores
            // 
            dataGridViewConductores.AllowUserToOrderColumns = true;
            dataGridViewConductores.BackgroundColor = Color.MidnightBlue;
            dataGridViewConductores.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewConductores.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewConductores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewConductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewConductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConductores.Columns.AddRange(new DataGridViewColumn[] { ColumnDNI, fechaVencLic, ColumnNombre, ColumnApellido });
            dataGridViewConductores.GridColor = Color.MidnightBlue;
            dataGridViewConductores.Location = new Point(461, 109);
            dataGridViewConductores.Margin = new Padding(3, 4, 3, 4);
            dataGridViewConductores.Name = "dataGridViewConductores";
            dataGridViewConductores.ReadOnly = true;
            dataGridViewConductores.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewConductores.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.Size = new Size(590, 340);
            dataGridViewConductores.TabIndex = 30;
            // 
            // ColumnDNI
            // 
            ColumnDNI.DataPropertyName = "DNI";
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.MinimumWidth = 6;
            ColumnDNI.Name = "ColumnDNI";
            ColumnDNI.ReadOnly = true;
            ColumnDNI.Width = 125;
            // 
            // fechaVencLic
            // 
            fechaVencLic.DataPropertyName = "fechaVencLic";
            fechaVencLic.HeaderText = "Vence Lic.";
            fechaVencLic.MinimumWidth = 6;
            fechaVencLic.Name = "fechaVencLic";
            fechaVencLic.ReadOnly = true;
            fechaVencLic.Width = 125;
            // 
            // ColumnNombre
            // 
            ColumnNombre.DataPropertyName = "Nombre";
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.MinimumWidth = 6;
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            ColumnNombre.Width = 125;
            // 
            // ColumnApellido
            // 
            ColumnApellido.DataPropertyName = "Apellido";
            ColumnApellido.HeaderText = "Apellido";
            ColumnApellido.MinimumWidth = 6;
            ColumnApellido.Name = "ColumnApellido";
            ColumnApellido.ReadOnly = true;
            ColumnApellido.Width = 125;
            // 
            // labelBuscarPorDni
            // 
            labelBuscarPorDni.AutoSize = true;
            labelBuscarPorDni.Font = new Font("Verdana", 9F);
            labelBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            labelBuscarPorDni.Location = new Point(761, 55);
            labelBuscarPorDni.Name = "labelBuscarPorDni";
            labelBuscarPorDni.Size = new Size(65, 18);
            labelBuscarPorDni.TabIndex = 31;
            labelBuscarPorDni.Text = "Buscar:";
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = Color.MidnightBlue;
            textBoxBuscador.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscador.Font = new Font("Verdana", 9F);
            textBoxBuscador.ForeColor = SystemColors.ButtonFace;
            textBoxBuscador.Location = new Point(830, 52);
            textBoxBuscador.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(138, 26);
            textBoxBuscador.TabIndex = 31;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // buttonRecargar
            // 
            buttonRecargar.FlatStyle = FlatStyle.System;
            buttonRecargar.Font = new Font("Segoe UI", 16F);
            buttonRecargar.Location = new Point(461, 55);
            buttonRecargar.Margin = new Padding(3, 4, 3, 4);
            buttonRecargar.Name = "buttonRecargar";
            buttonRecargar.Size = new Size(39, 40);
            buttonRecargar.TabIndex = 41;
            buttonRecargar.Text = "↻";
            buttonRecargar.UseVisualStyleBackColor = true;
            buttonRecargar.Click += buttonRecargar_Click;
            // 
            // FormConductores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1092, 489);
            Controls.Add(buttonRecargar);
            Controls.Add(textBoxBuscador);
            Controls.Add(labelBuscarPorDni);
            Controls.Add(dataGridViewConductores);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBoxConductores);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormConductores";
            Text = "Conductores     ";
            Load += FormConductores_Load;
            groupBoxConductores.ResumeLayout(false);
            groupBoxConductores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConductores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardar;
        private GroupBox groupBoxConductores;
        private TextBox textBoxDni;
        private Label labelNombreCond;
        private Label labelApellidoCond;
        private Label labelDni;
        private Label labelVencLic;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private BindingSource conductorBindingSource;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private DateTimePicker dateTimePickerVencLic;
        private DataGridView dataGridViewConductores;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn fechaVencLic;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private Label labelBuscarPorDni;
        private TextBox textBoxBuscador;
        private Button buttonRecargar;
    }
}