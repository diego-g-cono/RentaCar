namespace RentaCar.Escritorio
{
    partial class FormUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarios));
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBox = new GroupBox();
            comboBoxActivo = new ComboBox();
            comboBoxRol = new ComboBox();
            textBoxNombreUsuario = new TextBox();
            labelEmail = new Label();
            labelTelefono = new Label();
            labelApellido = new Label();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            dataGridViewUsuarios = new DataGridView();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnRol = new DataGridViewTextBoxColumn();
            ColumnActivo = new DataGridViewTextBoxColumn();
            usuarioBindingSource = new BindingSource(components);
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
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
            buttonCancelar.Location = new Point(265, 290);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 34;
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
            buttonGuardar.Location = new Point(27, 290);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 33;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(comboBoxActivo);
            groupBox.Controls.Add(comboBoxRol);
            groupBox.Controls.Add(textBoxNombreUsuario);
            groupBox.Controls.Add(labelEmail);
            groupBox.Controls.Add(labelTelefono);
            groupBox.Controls.Add(labelApellido);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(27, 86);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 177);
            groupBox.TabIndex = 32;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Usuario";
            // 
            // comboBoxActivo
            // 
            comboBoxActivo.BackColor = Color.MidnightBlue;
            comboBoxActivo.ForeColor = SystemColors.ButtonFace;
            comboBoxActivo.FormattingEnabled = true;
            comboBoxActivo.Items.AddRange(new object[] { "Si", "No" });
            comboBoxActivo.Location = new Point(162, 131);
            comboBoxActivo.Name = "comboBoxActivo";
            comboBoxActivo.Size = new Size(121, 22);
            comboBoxActivo.TabIndex = 29;
            // 
            // comboBoxRol
            // 
            comboBoxRol.BackColor = Color.MidnightBlue;
            comboBoxRol.ForeColor = SystemColors.ButtonFace;
            comboBoxRol.FormattingEnabled = true;
            comboBoxRol.Items.AddRange(new object[] { "Admin", "User" });
            comboBoxRol.Location = new Point(162, 81);
            comboBoxRol.Name = "comboBoxRol";
            comboBoxRol.Size = new Size(121, 22);
            comboBoxRol.TabIndex = 28;
            // 
            // textBoxNombreUsuario
            // 
            textBoxNombreUsuario.BackColor = Color.MidnightBlue;
            textBoxNombreUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombreUsuario.Font = new Font("Verdana", 9F);
            textBoxNombreUsuario.ForeColor = SystemColors.ButtonFace;
            textBoxNombreUsuario.Location = new Point(162, 35);
            textBoxNombreUsuario.Name = "textBoxNombreUsuario";
            textBoxNombreUsuario.Size = new Size(121, 22);
            textBoxNombreUsuario.TabIndex = 18;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 9F);
            labelEmail.Location = new Point(24, 84);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(31, 14);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Rol:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Verdana", 9F);
            labelTelefono.Location = new Point(24, 131);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(49, 14);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Activo:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Verdana", 9F);
            labelApellido.Location = new Point(24, 37);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(132, 14);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Nombre de usuario:";
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
            buttonEliminar.Location = new Point(265, 21);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 31;
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
            buttonEditar.Location = new Point(145, 21);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 30;
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
            buttonNuevo.Location = new Point(27, 21);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
            buttonNuevo.TabIndex = 29;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = Color.MidnightBlue;
            dataGridViewUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Columns.AddRange(new DataGridViewColumn[] { ColumnNombre, ColumnRol, ColumnActivo });
            dataGridViewUsuarios.GridColor = Color.MidnightBlue;
            dataGridViewUsuarios.Location = new Point(395, 64);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewUsuarios.Size = new Size(548, 242);
            dataGridViewUsuarios.TabIndex = 35;
            // 
            // ColumnNombre
            // 
            ColumnNombre.DataPropertyName = "NombreUsuario";
            ColumnNombre.HeaderText = "Nombre de Usuario";
            ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnRol
            // 
            ColumnRol.DataPropertyName = "RolId";
            ColumnRol.HeaderText = "Rol";
            ColumnRol.Name = "ColumnRol";
            // 
            // ColumnActivo
            // 
            ColumnActivo.DataPropertyName = "Activo";
            ColumnActivo.HeaderText = "Activo";
            ColumnActivo.Name = "ColumnActivo";
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(Dominio.Usuario);
            // 
            // FormUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1010, 375);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUsuarios";
            Text = "Usuarios";
            Load += FormUsuarios_Load_1;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardar;
        private GroupBox groupBox;
        private TextBox textBoxNombreUsuario;
        private Label labelEmail;
        private Label labelTelefono;
        private Label labelApellido;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private DataGridView dataGridViewUsuarios;
        private BindingSource usuarioBindingSource;
        private ComboBox comboBoxRol;
        private ComboBox comboBoxActivo;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnRol;
        private DataGridViewTextBoxColumn ColumnActivo;
    }
}