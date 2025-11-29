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
            btnModificar = new Button();
            btnEliminar = new Button();
            groupBoxClientes = new GroupBox();
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
            ColumnaDNI = new DataGridViewTextBoxColumn();
            ColumnaNombre = new DataGridViewTextBoxColumn();
            ColumnaApellido = new DataGridViewTextBoxColumn();
            ColumnaUsuario = new DataGridViewTextBoxColumn();
            ColumnaContrasenia = new DataGridViewTextBoxColumn();
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
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(111, 12);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
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
            groupBoxClientes.Size = new Size(274, 185);
            groupBoxClientes.TabIndex = 3;
            groupBoxClientes.TabStop = false;
            groupBoxClientes.Text = "Datos Cliente";
            // 
            // txtBoxDNI
            // 
            txtBoxDNI.Location = new Point(99, 16);
            txtBoxDNI.Name = "txtBoxDNI";
            txtBoxDNI.Size = new Size(100, 23);
            txtBoxDNI.TabIndex = 9;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(99, 45);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(100, 23);
            txtBoxNombre.TabIndex = 8;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(99, 76);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(100, 23);
            txtBoxApellido.TabIndex = 7;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(99, 105);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(100, 23);
            txtBoxUsuario.TabIndex = 6;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(99, 134);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(100, 23);
            txtBoxContrasenia.TabIndex = 5;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(6, 137);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(70, 15);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(6, 108);
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
            btnGuardar.Location = new Point(12, 252);
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
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnaDNI, ColumnaNombre, ColumnaApellido, ColumnaUsuario, ColumnaContrasenia });
            dataGridViewClientes.Location = new Point(332, 61);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.Size = new Size(544, 150);
            dataGridViewClientes.TabIndex = 5;
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
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1124, 450);
            Controls.Add(dataGridViewClientes);
            Controls.Add(btnGuardar);
            Controls.Add(groupBoxClientes);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Name = "FrmClientes";
            Text = "Clientes";
            groupBoxClientes.ResumeLayout(false);
            groupBoxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnModificar;
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
        private DataGridViewTextBoxColumn ColumnaDNI;
        private DataGridViewTextBoxColumn ColumnaNombre;
        private DataGridViewTextBoxColumn ColumnaApellido;
        private DataGridViewTextBoxColumn ColumnaUsuario;
        private DataGridViewTextBoxColumn ColumnaContrasenia;
    }
}