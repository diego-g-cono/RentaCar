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
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBoxConductores = new GroupBox();
            dateTimePickerVencLic = new DateTimePicker();
            textBoxApellido = new TextBox();
            textBoxNombre = new TextBox();
            textBoxDni = new TextBox();
            labelEmail = new Label();
            labelTelefono = new Label();
            labelApellido = new Label();
            labelNombre = new Label();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            conductorBindingSource = new BindingSource(components);
            dataGridViewConductores = new DataGridView();
            dniDataGridViewTextColumn = new DataGridViewTextBoxColumn();
            fechaVencLicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            apellidoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            buttonCancelar.Location = new Point(261, 304);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 28;
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
            buttonGuardar.Location = new Point(23, 304);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
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
            groupBoxConductores.Controls.Add(labelEmail);
            groupBoxConductores.Controls.Add(labelTelefono);
            groupBoxConductores.Controls.Add(labelApellido);
            groupBoxConductores.Controls.Add(labelNombre);
            groupBoxConductores.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBoxConductores.ForeColor = SystemColors.ButtonFace;
            groupBoxConductores.Location = new Point(23, 91);
            groupBoxConductores.Name = "groupBoxConductores";
            groupBoxConductores.Size = new Size(315, 207);
            groupBoxConductores.TabIndex = 26;
            groupBoxConductores.TabStop = false;
            groupBoxConductores.Text = "Conductor";
            // 
            // dateTimePickerVencLic
            // 
            dateTimePickerVencLic.Location = new Point(129, 29);
            dateTimePickerVencLic.Name = "dateTimePickerVencLic";
            dateTimePickerVencLic.Size = new Size(121, 22);
            dateTimePickerVencLic.TabIndex = 30;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = Color.MidnightBlue;
            textBoxApellido.BorderStyle = BorderStyle.FixedSingle;
            textBoxApellido.Font = new Font("Verdana", 9F);
            textBoxApellido.ForeColor = SystemColors.ButtonFace;
            textBoxApellido.Location = new Point(129, 153);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(121, 22);
            textBoxApellido.TabIndex = 20;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = Color.MidnightBlue;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Font = new Font("Verdana", 9F);
            textBoxNombre.ForeColor = SystemColors.ButtonFace;
            textBoxNombre.Location = new Point(129, 116);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(121, 22);
            textBoxNombre.TabIndex = 19;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = Color.MidnightBlue;
            textBoxDni.BorderStyle = BorderStyle.FixedSingle;
            textBoxDni.Font = new Font("Verdana", 9F);
            textBoxDni.ForeColor = SystemColors.ButtonFace;
            textBoxDni.Location = new Point(129, 76);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(121, 22);
            textBoxDni.TabIndex = 18;
            textBoxDni.TextChanged += textBoxApellido_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Verdana", 9F);
            labelEmail.Location = new Point(19, 118);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(61, 14);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Nombre:";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Font = new Font("Verdana", 9F);
            labelTelefono.Location = new Point(19, 155);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(61, 14);
            labelTelefono.TabIndex = 3;
            labelTelefono.Text = "Apellido:";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Verdana", 9F);
            labelApellido.Location = new Point(19, 78);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(35, 14);
            labelApellido.TabIndex = 2;
            labelApellido.Text = "DNI:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Verdana", 9F);
            labelNombre.Location = new Point(19, 35);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(98, 14);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Vence licencia:";
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
            buttonEliminar.Location = new Point(231, 44);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 25;
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
            buttonEditar.Location = new Point(131, 44);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 24;
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
            buttonNuevo.Location = new Point(35, 44);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
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
            dataGridViewConductores.AutoGenerateColumns = false;
            dataGridViewConductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConductores.Columns.AddRange(new DataGridViewColumn[] { dniDataGridViewTextColumn, fechaVencLicDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, apellidoDataGridViewTextBoxColumn });
            dataGridViewConductores.DataSource = conductorBindingSource;
            dataGridViewConductores.Location = new Point(388, 57);
            dataGridViewConductores.Name = "dataGridViewConductores";
            dataGridViewConductores.Size = new Size(444, 280);
            dataGridViewConductores.TabIndex = 29;
            // 
            // dniDataGridViewTextColumn
            // 
            dniDataGridViewTextColumn.DataPropertyName = "Dni";
            dniDataGridViewTextColumn.HeaderText = "Dni";
            dniDataGridViewTextColumn.Name = "dniDataGridViewTextColumn";
            // 
            // fechaVencLicDataGridViewTextBoxColumn
            // 
            fechaVencLicDataGridViewTextBoxColumn.DataPropertyName = "FechaVencLic";
            fechaVencLicDataGridViewTextBoxColumn.HeaderText = "Vence Lic.";
            fechaVencLicDataGridViewTextBoxColumn.Name = "fechaVencLicDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // FormConductores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(881, 390);
            Controls.Add(dataGridViewConductores);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBoxConductores);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Name = "FormConductores";
            Text = "Conductores";
            Load += FormConductores_Load;
            groupBoxConductores.ResumeLayout(false);
            groupBoxConductores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)conductorBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConductores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCancelar;
        private Button buttonGuardar;
        private GroupBox groupBoxConductores;
        private TextBox textBoxDni;
        private Label labelEmail;
        private Label labelTelefono;
        private Label labelApellido;
        private Label labelNombre;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private BindingSource conductorBindingSource;
        private TextBox textBoxApellido;
        private TextBox textBoxNombre;
        private DateTimePicker dateTimePickerVencLic;
        private DataGridView dataGridViewConductores;
        private DataGridViewTextBoxColumn dniDataGridViewTextColumn;
        private DataGridViewTextBoxColumn fechaVencLicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private Label ARREGLARERROR;
    }
}