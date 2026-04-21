namespace RentaCar.Escritorio
{
    partial class FormDevoluciones
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
            dataGridViewDevoluciones = new DataGridView();
            fechaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            alquilerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tanqueLlenoDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            observacionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            devolucionBindingSource = new BindingSource(components);
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBox = new GroupBox();
            textBoxObservaciones = new TextBox();
            comboBoxTqueLleno = new ComboBox();
            dtpFechaDevolucion = new DateTimePicker();
            labelObservaciones = new Label();
            labelTqueLleno = new Label();
            labelFechaDevolucion = new Label();
            labelAlquiler = new Label();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            tabControlDevoluciones = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            textBoxAlquiler = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevoluciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)devolucionBindingSource).BeginInit();
            groupBox.SuspendLayout();
            tabControlDevoluciones.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDevoluciones
            // 
            dataGridViewDevoluciones.AutoGenerateColumns = false;
            dataGridViewDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevoluciones.Columns.AddRange(new DataGridViewColumn[] { fechaDataGridViewTextBoxColumn, alquilerIdDataGridViewTextBoxColumn, tanqueLlenoDataGridViewCheckBoxColumn, observacionesDataGridViewTextBoxColumn });
            dataGridViewDevoluciones.DataSource = devolucionBindingSource;
            dataGridViewDevoluciones.Location = new Point(0, 0);
            dataGridViewDevoluciones.Name = "dataGridViewDevoluciones";
            dataGridViewDevoluciones.Size = new Size(443, 305);
            dataGridViewDevoluciones.TabIndex = 0;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // alquilerIdDataGridViewTextBoxColumn
            // 
            alquilerIdDataGridViewTextBoxColumn.DataPropertyName = "AlquilerId";
            alquilerIdDataGridViewTextBoxColumn.HeaderText = "Alquiler";
            alquilerIdDataGridViewTextBoxColumn.Name = "alquilerIdDataGridViewTextBoxColumn";
            // 
            // tanqueLlenoDataGridViewCheckBoxColumn
            // 
            tanqueLlenoDataGridViewCheckBoxColumn.DataPropertyName = "TanqueLleno";
            tanqueLlenoDataGridViewCheckBoxColumn.HeaderText = "Tanque Lleno";
            tanqueLlenoDataGridViewCheckBoxColumn.Name = "tanqueLlenoDataGridViewCheckBoxColumn";
            // 
            // observacionesDataGridViewTextBoxColumn
            // 
            observacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones";
            observacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones";
            observacionesDataGridViewTextBoxColumn.Name = "observacionesDataGridViewTextBoxColumn";
            // 
            // devolucionBindingSource
            // 
            devolucionBindingSource.DataSource = typeof(Dominio.Devolucion);
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
            buttonCancelar.Location = new Point(308, 316);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 16;
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
            buttonGuardar.Location = new Point(15, 316);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 15;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxAlquiler);
            groupBox.Controls.Add(textBoxObservaciones);
            groupBox.Controls.Add(comboBoxTqueLleno);
            groupBox.Controls.Add(dtpFechaDevolucion);
            groupBox.Controls.Add(labelObservaciones);
            groupBox.Controls.Add(labelTqueLleno);
            groupBox.Controls.Add(labelFechaDevolucion);
            groupBox.Controls.Add(labelAlquiler);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(15, 78);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(370, 222);
            groupBox.TabIndex = 14;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Devolucion";
            // 
            // textBoxObservaciones
            // 
            textBoxObservaciones.BackColor = Color.MidnightBlue;
            textBoxObservaciones.BorderStyle = BorderStyle.FixedSingle;
            textBoxObservaciones.Font = new Font("Verdana", 9F);
            textBoxObservaciones.ForeColor = SystemColors.ButtonFace;
            textBoxObservaciones.Location = new Point(150, 179);
            textBoxObservaciones.Name = "textBoxObservaciones";
            textBoxObservaciones.Size = new Size(122, 22);
            textBoxObservaciones.TabIndex = 29;
            // 
            // comboBoxTqueLleno
            // 
            comboBoxTqueLleno.BackColor = Color.MidnightBlue;
            comboBoxTqueLleno.ForeColor = SystemColors.ButtonFace;
            comboBoxTqueLleno.FormattingEnabled = true;
            comboBoxTqueLleno.Location = new Point(151, 124);
            comboBoxTqueLleno.Name = "comboBoxTqueLleno";
            comboBoxTqueLleno.Size = new Size(121, 22);
            comboBoxTqueLleno.TabIndex = 28;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(151, 32);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(200, 22);
            dtpFechaDevolucion.TabIndex = 24;
            // 
            // labelObservaciones
            // 
            labelObservaciones.AutoSize = true;
            labelObservaciones.Font = new Font("Verdana", 9F);
            labelObservaciones.Location = new Point(19, 181);
            labelObservaciones.Name = "labelObservaciones";
            labelObservaciones.Size = new Size(105, 14);
            labelObservaciones.TabIndex = 22;
            labelObservaciones.Text = "Observaciones:";
            // 
            // labelTqueLleno
            // 
            labelTqueLleno.AutoSize = true;
            labelTqueLleno.Font = new Font("Verdana", 9F);
            labelTqueLleno.Location = new Point(19, 127);
            labelTqueLleno.Name = "labelTqueLleno";
            labelTqueLleno.Size = new Size(92, 14);
            labelTqueLleno.TabIndex = 21;
            labelTqueLleno.Text = "Tanque lleno:";
            // 
            // labelFechaDevolucion
            // 
            labelFechaDevolucion.AutoSize = true;
            labelFechaDevolucion.Font = new Font("Verdana", 9F);
            labelFechaDevolucion.Location = new Point(19, 38);
            labelFechaDevolucion.Name = "labelFechaDevolucion";
            labelFechaDevolucion.Size = new Size(121, 14);
            labelFechaDevolucion.TabIndex = 16;
            labelFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // labelAlquiler
            // 
            labelAlquiler.AutoSize = true;
            labelAlquiler.Font = new Font("Verdana", 9F);
            labelAlquiler.Location = new Point(19, 82);
            labelAlquiler.Name = "labelAlquiler";
            labelAlquiler.Size = new Size(58, 14);
            labelAlquiler.TabIndex = 3;
            labelAlquiler.Text = "Alquiler:";
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
            buttonEliminar.Location = new Point(308, 26);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 13;
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
            buttonEditar.Location = new Point(165, 26);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 12;
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
            buttonNuevo.Location = new Point(15, 26);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
            buttonNuevo.TabIndex = 11;
            buttonNuevo.Text = "Nueva";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // tabControlDevoluciones
            // 
            tabControlDevoluciones.Controls.Add(tabPage1);
            tabControlDevoluciones.Controls.Add(tabPage2);
            tabControlDevoluciones.Location = new Point(434, 16);
            tabControlDevoluciones.Name = "tabControlDevoluciones";
            tabControlDevoluciones.SelectedIndex = 0;
            tabControlDevoluciones.Size = new Size(451, 333);
            tabControlDevoluciones.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridViewDevoluciones);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(443, 305);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Devoluciones";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(443, 305);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alquileres";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxAlquiler
            // 
            textBoxAlquiler.BackColor = Color.MidnightBlue;
            textBoxAlquiler.BorderStyle = BorderStyle.FixedSingle;
            textBoxAlquiler.Font = new Font("Verdana", 9F);
            textBoxAlquiler.ForeColor = SystemColors.ButtonFace;
            textBoxAlquiler.Location = new Point(151, 80);
            textBoxAlquiler.Name = "textBoxAlquiler";
            textBoxAlquiler.Size = new Size(122, 22);
            textBoxAlquiler.TabIndex = 30;
            // 
            // FormDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(919, 371);
            Controls.Add(tabControlDevoluciones);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Name = "FormDevoluciones";
            Text = "Devoluciones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevoluciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)devolucionBindingSource).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            tabControlDevoluciones.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDevoluciones;
        private DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn alquilerIdDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn tanqueLlenoDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn observacionesDataGridViewTextBoxColumn;
        private BindingSource devolucionBindingSource;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private GroupBox groupBox;
        private ComboBox comboBoxTqueLleno;
        private DateTimePicker dtpFechaDevolucion;
        private Label labelObservaciones;
        private Label labelTqueLleno;
        private Label labelFechaDevolucion;
        private Label labelAlquiler;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private TextBox textBoxObservaciones;
        private TabControl tabControlDevoluciones;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBoxAlquiler;
    }
}