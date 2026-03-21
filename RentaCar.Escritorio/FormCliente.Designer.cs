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
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
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
            groupBox.Size = new Size(315, 206);
            groupBox.TabIndex = 6;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Cliente";
            // 
            // textBoxTel
            // 
            textBoxTel.BackColor = Color.MidnightBlue;
            textBoxTel.BorderStyle = BorderStyle.FixedSingle;
            textBoxTel.Font = new Font("Verdana", 9F);
            textBoxTel.ForeColor = SystemColors.ButtonFace;
            textBoxTel.Location = new Point(120, 166);
            textBoxTel.Name = "textBoxTel";
            textBoxTel.Size = new Size(121, 22);
            textBoxTel.TabIndex = 20;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.MidnightBlue;
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Verdana", 9F);
            textBoxEmail.ForeColor = SystemColors.ButtonFace;
            textBoxEmail.Location = new Point(120, 131);
            textBoxEmail.Name = "textBoxEmail";
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
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(121, 22);
            textBoxApellido.TabIndex = 18;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.MidnightBlue;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Verdana", 9F);
            textBoxNombre.ForeColor = SystemColors.ButtonFace;
            textBoxNombre.Location = new Point(120, 61);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 22);
            textBoxNombre.TabIndex = 17;
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
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(121, 22);
            textBoxDNI.TabIndex = 8;
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
            buttonCancelar.Location = new Point(250, 281);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 8;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
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
            buttonGuardar.Location = new Point(12, 281);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 7;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnDNI, ColumnNombre, ColumnApellido, ColumnEmail, ColumnTelefono });
            dataGridView.GridColor = Color.MidnightBlue;
            dataGridView.Location = new Point(356, 60);
            dataGridView.Name = "dataGridView";
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
            dataGridView.Size = new Size(545, 322);
            dataGridView.TabIndex = 9;
            // 
            // ColumnDNI
            // 
            ColumnDNI.DataPropertyName = "DNI";
            ColumnDNI.HeaderText = "DNI";
            ColumnDNI.Name = "ColumnDNI";
            // 
            // ColumnNombre
            // 
            ColumnNombre.DataPropertyName = "Nombre";
            ColumnNombre.HeaderText = "Nombre";
            ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            ColumnApellido.DataPropertyName = "Apellido";
            ColumnApellido.HeaderText = "Apellido";
            ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnEmail
            // 
            ColumnEmail.DataPropertyName = "Email";
            ColumnEmail.HeaderText = "E-mail";
            ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnTelefono
            // 
            ColumnTelefono.DataPropertyName = "Telefono";
            ColumnTelefono.HeaderText = "Teléfono";
            ColumnTelefono.Name = "ColumnTelefono";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1012, 424);
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
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTelefono;
    }
}