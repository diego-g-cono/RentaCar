namespace Escritorio
{
    partial class FrmClientes
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
            btnEditar = new Button();
            btnEliminar = new Button();
            groupBoxClientes = new GroupBox();
            dateTimePickerFdN = new DateTimePicker();
            labelEmail = new Label();
            txtBoxEmail = new TextBox();
            txtBoxDireccion = new TextBox();
            labelDireccion = new Label();
            labelFdN = new Label();
            txtBoxDNI = new TextBox();
            txtBoxNombre = new TextBox();
            txtBoxApellido = new TextBox();
            txtBoxUsuario = new TextBox();
            txtBoxContrasenia = new TextBox();
            labelContraseña = new Label();
            labelUsuario = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            labelDNI = new Label();
            btnGuardar = new Button();
            dataGridViewClientes = new DataGridView();
            btnCancelar = new Button();
            ColumnaDNI = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaUsuario = new DataGridViewTextBoxColumn();
            ColumnaFechaDeNacimiento = new DataGridViewTextBoxColumn();
            ColumnaDireccion = new DataGridViewTextBoxColumn();
            ColumnaEmail = new DataGridViewTextBoxColumn();
            groupBoxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(111, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(211, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // groupBoxClientes
            // 
            groupBoxClientes.Controls.Add(dateTimePickerFdN);
            groupBoxClientes.Controls.Add(labelEmail);
            groupBoxClientes.Controls.Add(txtBoxEmail);
            groupBoxClientes.Controls.Add(txtBoxDireccion);
            groupBoxClientes.Controls.Add(labelDireccion);
            groupBoxClientes.Controls.Add(labelFdN);
            groupBoxClientes.Controls.Add(txtBoxDNI);
            groupBoxClientes.Controls.Add(txtBoxNombre);
            groupBoxClientes.Controls.Add(txtBoxApellido);
            groupBoxClientes.Controls.Add(txtBoxUsuario);
            groupBoxClientes.Controls.Add(txtBoxContrasenia);
            groupBoxClientes.Controls.Add(labelContraseña);
            groupBoxClientes.Controls.Add(labelUsuario);
            groupBoxClientes.Controls.Add(labelApellido);
            groupBoxClientes.Controls.Add(labelNombre);
            groupBoxClientes.Controls.Add(labelDNI);
            groupBoxClientes.Location = new Point(12, 49);
            groupBoxClientes.Name = "groupBoxClientes";
            groupBoxClientes.Size = new Size(350, 251);
            groupBoxClientes.TabIndex = 3;
            groupBoxClientes.TabStop = false;
            groupBoxClientes.Text = "Datos Cliente";
            // 
            // dateTimePickerFdN
            // 
            dateTimePickerFdN.Location = new Point(140, 110);
            dateTimePickerFdN.Name = "dateTimePickerFdN";
            dateTimePickerFdN.Size = new Size(200, 23);
            dateTimePickerFdN.TabIndex = 16;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(6, 171);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email:";
            // 
            // txtBoxEmail
            // 
            txtBoxEmail.Location = new Point(140, 168);
            txtBoxEmail.Name = "txtBoxEmail";
            txtBoxEmail.Size = new Size(100, 23);
            txtBoxEmail.TabIndex = 14;
            // 
            // txtBoxDireccion
            // 
            txtBoxDireccion.Location = new Point(140, 139);
            txtBoxDireccion.Name = "txtBoxDireccion";
            txtBoxDireccion.Size = new Size(100, 23);
            txtBoxDireccion.TabIndex = 13;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(6, 142);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(60, 15);
            labelDireccion.TabIndex = 12;
            labelDireccion.Text = "Dirección:";
            // 
            // labelFdN
            // 
            labelFdN.AutoSize = true;
            labelFdN.Location = new Point(6, 110);
            labelFdN.Name = "labelFdN";
            labelFdN.Size = new Size(122, 15);
            labelFdN.TabIndex = 10;
            labelFdN.Text = "Fecha de Nacimiento:";
            // 
            // txtBoxDNI
            // 
            txtBoxDNI.Location = new Point(140, 16);
            txtBoxDNI.Name = "txtBoxDNI";
            txtBoxDNI.Size = new Size(100, 23);
            txtBoxDNI.TabIndex = 9;
            txtBoxDNI.KeyPress += txtBoxDNI_KeyPress;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(140, 44);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(100, 23);
            txtBoxNombre.TabIndex = 8;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(140, 76);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(100, 23);
            txtBoxApellido.TabIndex = 7;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(140, 197);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(100, 23);
            txtBoxUsuario.TabIndex = 6;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(140, 226);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(100, 23);
            txtBoxContrasenia.TabIndex = 5;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(6, 229);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(70, 15);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(6, 200);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(6, 79);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(6, 47);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(6, 19);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(30, 15);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(13, 322);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnaDNI, ColumnaNombre, ColumnaApellido, ColumnaUsuario, ColumnaFechaDeNacimiento, ColumnaDireccion, ColumnaEmail });
            dataGridViewClientes.Location = new Point(368, 49);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(744, 287);
            dataGridViewClientes.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(211, 322);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
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
            // ColumnaFechaDeNacimiento
            // 
            ColumnaFechaDeNacimiento.DataPropertyName = "Fecha_Nacimiento";
            ColumnaFechaDeNacimiento.HeaderText = "Fecha de Nacimiento";
            ColumnaFechaDeNacimiento.Name = "ColumnaFechaDeNacimiento";
            ColumnaFechaDeNacimiento.ReadOnly = true;
            // 
            // ColumnaDireccion
            // 
            ColumnaDireccion.DataPropertyName = "Direccion";
            ColumnaDireccion.HeaderText = "Dirección";
            ColumnaDireccion.Name = "ColumnaDireccion";
            ColumnaDireccion.ReadOnly = true;
            // 
            // ColumnaEmail
            // 
            ColumnaEmail.DataPropertyName = "Email";
            ColumnaEmail.HeaderText = "Email";
            ColumnaEmail.Name = "ColumnaEmail";
            ColumnaEmail.ReadOnly = true;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 450);
            Controls.Add(btnCancelar);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnGuardar);
            Controls.Add(groupBoxClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Name = "FrmClientes";
            Text = "Clientes";
            Load += FrmClientes_Load;
            groupBoxClientes.ResumeLayout(false);
            groupBoxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private GroupBox groupBoxClientes;
        private Label labelApellido;
        private Label labelNombre;
        private Label labelDNI;
        private TextBox txtBoxDNI;
        private TextBox txtBoxNombre;
        private TextBox txtBoxApellido;
        private TextBox txtBoxUsuario;
        private TextBox txtBoxContrasenia;
        private Label labelContraseña;
        private Label labelUsuario;
        private Button btnGuardar;
        private DataGridView dataGridViewClientes;
        private Button btnCancelar;
        private Label labelFdN;
        private TextBox txtBoxDireccion;
        private Label labelDireccion;
        private Label labelEmail;
        private TextBox txtBoxEmail;
        private DateTimePicker dateTimePickerFdN;
        private DataGridViewTextBoxColumn ColumnaDNI;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaFechaDeNacimiento;
        private DataGridViewTextBoxColumn ColumnaDireccion;
        private DataGridViewTextBoxColumn ColumnaEmail;
    }
}