namespace RentaCar.Escritorio
{
    partial class FormCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            groupBox = new GroupBox();
            textBoxContrasenia = new TextBox();
            textBoxUsuario = new TextBox();
            labelUsuario = new Label();
            labelContrasenia = new Label();
            textBoxTel = new TextBox();
            textBoxEmail = new TextBox();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            labelEmail = new Label();
            textBoxDNI = new TextBox();
            labelTelefono = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            labelDNI = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            dataGridView = new DataGridView();
            textBoxBuscador = new TextBox();
            labelBuscarPorDni = new Label();
            buttonRecargar = new Button();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            ColumnUsuario = new DataGridViewTextBoxColumn();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
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
            buttonEliminar.Location = new Point(250, 12);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 5;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += btnEliminar_Click;
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
            buttonEditar.Location = new Point(132, 12);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 4;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += btnEditar_Click;
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
            buttonNuevo.Location = new Point(12, 12);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
            buttonNuevo.TabIndex = 3;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += btnNuevo_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxContrasenia);
            groupBox.Controls.Add(textBoxUsuario);
            groupBox.Controls.Add(labelUsuario);
            groupBox.Controls.Add(labelContrasenia);
            groupBox.Controls.Add(textBoxTel);
            groupBox.Controls.Add(textBoxEmail);
            groupBox.Controls.Add(textBoxApellido);
            groupBox.Controls.Add(textBoxNombre);
            groupBox.Controls.Add(labelEmail);
            groupBox.Controls.Add(textBoxDNI);
            groupBox.Controls.Add(labelTelefono);
            groupBox.Controls.Add(labelApellido);
            groupBox.Controls.Add(labelNombre);
            groupBox.Controls.Add(labelDNI);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(12, 60);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 294);
            groupBox.TabIndex = 6;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Cliente";
            // 
            // textBoxContrasenia
            // 
            textBoxContrasenia.BackColor = Color.MidnightBlue;
            textBoxContrasenia.BorderStyle = BorderStyle.FixedSingle;
            textBoxContrasenia.Font = new Font("Verdana", 9F);
            textBoxContrasenia.ForeColor = SystemColors.ButtonFace;
            textBoxContrasenia.Location = new Point(120, 245);
            textBoxContrasenia.MaxLength = 20;
            textBoxContrasenia.Name = "textBoxContrasenia";
            textBoxContrasenia.PasswordChar = '*';
            textBoxContrasenia.ShortcutsEnabled = false;
            textBoxContrasenia.Size = new Size(121, 22);
            textBoxContrasenia.TabIndex = 24;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.MidnightBlue;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Font = new Font("Verdana", 9F);
            textBoxUsuario.ForeColor = SystemColors.ButtonFace;
            textBoxUsuario.Location = new Point(120, 210);
            textBoxUsuario.MaxLength = 50;
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.ShortcutsEnabled = false;
            textBoxUsuario.Size = new Size(121, 22);
            textBoxUsuario.TabIndex = 23;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 9F);
            labelUsuario.Location = new Point(20, 210);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(60, 14);
            labelUsuario.TabIndex = 22;
            labelUsuario.Text = "Usuario:";
            // 
            // labelContrasenia
            // 
            labelContrasenia.AutoSize = true;
            labelContrasenia.Font = new Font("Verdana", 9F);
            labelContrasenia.Location = new Point(19, 247);
            labelContrasenia.Name = "labelContrasenia";
            labelContrasenia.Size = new Size(86, 14);
            labelContrasenia.TabIndex = 21;
            labelContrasenia.Text = "Contraseña:";
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.MidnightBlue;
            textBoxTel.BorderStyle = BorderStyle.FixedSingle;
            textBoxTel.Font = new Font("Verdana", 9F);
            textBoxTel.ForeColor = SystemColors.ButtonFace;
            textBoxTel.Location = new Point(120, 166);
            textBoxTel.MaxLength = 20;
            textBoxTel.Name = "textBoxTel";
            textBoxTel.ShortcutsEnabled = false;
            textBoxTel.Size = new Size(121, 22);
            textBoxTel.TabIndex = 20;
            textBoxTel.KeyPress += textBoxTel_KeyPress;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.MidnightBlue;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Verdana", 9F);
            textBoxEmail.ForeColor = SystemColors.ButtonFace;
            textBoxEmail.Location = new Point(120, 131);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.ShortcutsEnabled = false;
            textBoxEmail.Size = new Size(121, 22);
            textBoxEmail.TabIndex = 19;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.MidnightBlue;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Font = new Font("Verdana", 9F);
            textBoxApellido.ForeColor = SystemColors.ButtonFace;
            textBoxApellido.Location = new Point(120, 93);
            textBoxApellido.MaxLength = 30;
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ShortcutsEnabled = false;
            textBoxApellido.Size = new Size(121, 22);
            textBoxApellido.TabIndex = 18;
            textBoxApellido.KeyPress += textBoxNombre_KeyPress;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.MidnightBlue;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Verdana", 9F);
            textBoxNombre.ForeColor = SystemColors.ButtonFace;
            textBoxNombre.Location = new Point(120, 61);
            textBoxNombre.MaxLength = 30;
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ShortcutsEnabled = false;
            textBoxNombre.Size = new Size(121, 22);
            textBoxNombre.TabIndex = 17;
            textBoxNombre.KeyPress += textBoxNombre_KeyPress;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 9F);
            labelEmail.Location = new Point(19, 133);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(50, 14);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "E-mail:";
            // 
            // textBoxDNI
            // 
            textBoxDNI.BackColor = Color.MidnightBlue;
            textBoxDNI.BorderStyle = BorderStyle.FixedSingle;
            textBoxDNI.Font = new Font("Verdana", 9F);
            textBoxDNI.ForeColor = SystemColors.ButtonFace;
            textBoxDNI.Location = new Point(120, 27);
            textBoxDNI.MaxLength = 8;
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.ShortcutsEnabled = false;
            textBoxDNI.Size = new Size(121, 22);
            textBoxDNI.TabIndex = 8;
            textBoxDNI.KeyPress += textBoxDNI_KeyPress;
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Verdana", 9F);
            labelTelefono.Location = new Point(19, 168);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(65, 14);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Teléfono:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Verdana", 9F);
            labelApellido.Location = new Point(18, 95);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(61, 14);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Verdana", 9F);
            labelNombre.Location = new Point(19, 63);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(61, 14);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Font = new Font("Verdana", 9F);
            labelDNI.Location = new Point(19, 30);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(35, 14);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
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
            buttonCancelar.Location = new Point(219, 360);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += btnCancelar_Click;
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
            buttonGuardar.Location = new Point(19, 360);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += btnGuardar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.BackgroundColor = Color.MidnightBlue;
            dataGridView.BorderStyle = BorderStyle.Fixed3D;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnDNI, ColumnNombre, ColumnApellido, ColumnEmail, ColumnTelefono, ColumnUsuario });
            dataGridView.GridColor = Color.MidnightBlue;
            dataGridView.Location = new Point(356, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridView.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridView.Size = new Size(673, 322);
            dataGridView.TabIndex = 9;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = Color.MidnightBlue;
            textBoxBuscador.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscador.Font = new Font("Verdana", 9F);
            textBoxBuscador.ForeColor = SystemColors.ButtonFace;
            textBoxBuscador.Location = new Point(780, 19);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(121, 22);
            textBoxBuscador.TabIndex = 32;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // labelBuscarPorDni
            // 
            labelBuscarPorDni.AutoSize = true;
            labelBuscarPorDni.Font = new Font("Verdana", 9F);
            labelBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            labelBuscarPorDni.Location = new Point(720, 21);
            labelBuscarPorDni.Name = "labelBuscarPorDni";
            labelBuscarPorDni.Size = new Size(54, 14);
            labelBuscarPorDni.TabIndex = 33;
            labelBuscarPorDni.Text = "Buscar:";
            // 
            // buttonRecargar
            // 
            buttonRecargar.FlatStyle = FlatStyle.System;
            buttonRecargar.Font = new Font("Segoe UI", 16F);
            buttonRecargar.Location = new Point(356, 19);
            buttonRecargar.Name = "buttonRecargar";
            buttonRecargar.Size = new Size(34, 30);
            buttonRecargar.TabIndex = 41;
            buttonRecargar.Text = "↻";
            buttonRecargar.UseVisualStyleBackColor = true;
            buttonRecargar.Click += buttonRecargar_Click;
            // 
            // ColumnDNI
            // 
            ColumnDNI.DataPropertyName = "DNI";
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.Name = "ColumnDNI";
            ColumnDNI.ReadOnly = true;
            // 
            // ColumnNombre
            // 
            ColumnNombre.DataPropertyName = "Nombre";
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            ColumnNombre.ReadOnly = true;
            // 
            // ColumnApellido
            // 
            ColumnApellido.DataPropertyName = "Apellido";
            ColumnApellido.HeaderText = "Apellido";
            ColumnApellido.Name = "ColumnApellido";
            ColumnApellido.ReadOnly = true;
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "Email";
            ColumnEmail.HeaderText = "E-mail";
            ColumnEmail.Name = "ColumnEmail";
            ColumnEmail.ReadOnly = true;
            // 
            // ColumnTelefono
            // 
            ColumnTelefono.DataPropertyName = "Telefono";
            ColumnTelefono.HeaderText = "Teléfono";
            ColumnTelefono.Name = "ColumnTelefono";
            ColumnTelefono.ReadOnly = true;
            // 
            // ColumnUsuario
            // 
            ColumnUsuario.DataPropertyName = "NombreUsuario";
            ColumnUsuario.HeaderText = "Usuario";
            ColumnUsuario.Name = "ColumnUsuario";
            ColumnUsuario.ReadOnly = true;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1057, 424);
            Controls.Add(buttonRecargar);
            Controls.Add(textBoxBuscador);
            Controls.Add(labelBuscarPorDni);
            Controls.Add(dataGridView);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCliente";
            Text = "Clientes";
            Load += FormCliente_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private GroupBox groupBox;
        private Label labelEmail;
        private TextBox textBoxDNI;
        private Label labelTelefono;
        private Label labelApellido;
        private Label labelNombre;
        private Label labelDNI;
        private TextBox textBoxTel;
        private TextBox textBoxEmail;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private DataGridView dataGridView;
        private TextBox textBoxBuscador;
        private Label labelBuscarPorDni;
        private Button buttonRecargar;
        private TextBox textBoxContrasenia;
        private TextBox textBoxUsuario;
        private Label labelUsuario;
        private Label labelContrasenia;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn ColumnUsuario;
    }
}