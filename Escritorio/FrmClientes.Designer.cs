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
            button2 = new Button();
            button3 = new Button();
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
            groupBoxClientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(34, 20);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(124, 20);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(220, 20);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
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
            groupBoxClientes.Location = new Point(34, 66);
            groupBoxClientes.Name = "groupBoxClientes";
            groupBoxClientes.Size = new Size(274, 208);
            groupBoxClientes.TabIndex = 3;
            groupBoxClientes.TabStop = false;
            groupBoxClientes.Text = "Datos Cliente";
            // 
            // txtBoxDNI
            // 
            txtBoxDNI.Location = new Point(99, 30);
            txtBoxDNI.Name = "txtBoxDNI";
            txtBoxDNI.Size = new Size(100, 23);
            txtBoxDNI.TabIndex = 9;
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(99, 59);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(100, 23);
            txtBoxNombre.TabIndex = 8;
            // 
            // txtBoxApellido
            // 
            txtBoxApellido.Location = new Point(99, 87);
            txtBoxApellido.Name = "txtBoxApellido";
            txtBoxApellido.Size = new Size(100, 23);
            txtBoxApellido.TabIndex = 7;
            // 
            // txtBoxUsuario
            // 
            txtBoxUsuario.Location = new Point(99, 117);
            txtBoxUsuario.Name = "txtBoxUsuario";
            txtBoxUsuario.Size = new Size(100, 23);
            txtBoxUsuario.TabIndex = 6;
            // 
            // txtBoxContrasenia
            // 
            txtBoxContrasenia.Location = new Point(99, 143);
            txtBoxContrasenia.Name = "txtBoxContrasenia";
            txtBoxContrasenia.Size = new Size(100, 23);
            txtBoxContrasenia.TabIndex = 5;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(16, 146);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(70, 15);
            labelContraseña.TabIndex = 4;
            labelContraseña.Text = "Contraseña:";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(16, 117);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(50, 15);
            labelUsuario.TabIndex = 3;
            labelUsuario.Text = "Usuario:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Location = new Point(14, 90);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(54, 15);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(14, 60);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(54, 15);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre:";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(14, 31);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(30, 15);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(42, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(groupBoxClientes);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnNuevo);
            Name = "FrmClientes";
            Text = "Clientes";
            groupBoxClientes.ResumeLayout(false);
            groupBoxClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button button2;
        private Button button3;
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
    }
}