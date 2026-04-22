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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            devolucionBindingSource = new BindingSource(components);
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBox = new GroupBox();
            textBoxAlquiler = new TextBox();
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
            dataGridViewDevoluciones = new DataGridView();
            fechaColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            dataGridViewAlquileres = new DataGridView();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            DniConductor = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)devolucionBindingSource).BeginInit();
            groupBox.SuspendLayout();
            tabControlDevoluciones.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevoluciones).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).BeginInit();
            SuspendLayout();
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
            // textBoxAlquiler
            // 
            textBoxAlquiler.BackColor = Color.MidnightBlue;
            textBoxAlquiler.BorderStyle = BorderStyle.FixedSingle;
            textBoxAlquiler.Font = new Font("Verdana", 9F);
            textBoxAlquiler.ForeColor = SystemColors.ButtonFace;
            textBoxAlquiler.Location = new Point(151, 80);
            textBoxAlquiler.Name = "textBoxAlquiler";
            textBoxAlquiler.ReadOnly = true;
            textBoxAlquiler.Size = new Size(122, 22);
            textBoxAlquiler.TabIndex = 30;
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
            tabControlDevoluciones.Size = new Size(951, 339);
            tabControlDevoluciones.TabIndex = 17;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MidnightBlue;
            tabPage1.Controls.Add(dataGridViewDevoluciones);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(943, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Devoluciones";
            // 
            // dataGridViewDevoluciones
            // 
            dataGridViewDevoluciones.AllowUserToOrderColumns = true;
            dataGridViewDevoluciones.BackgroundColor = Color.MidnightBlue;
            dataGridViewDevoluciones.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewDevoluciones.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewDevoluciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewDevoluciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevoluciones.Columns.AddRange(new DataGridViewColumn[] { fechaColumn, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewDevoluciones.GridColor = Color.MidnightBlue;
            dataGridViewDevoluciones.Location = new Point(0, 3);
            dataGridViewDevoluciones.Name = "dataGridViewDevoluciones";
            dataGridViewDevoluciones.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewDevoluciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewDevoluciones.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewDevoluciones.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewDevoluciones.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewDevoluciones.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewDevoluciones.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewDevoluciones.Size = new Size(444, 255);
            dataGridViewDevoluciones.TabIndex = 32;
            // 
            // fechaColumn
            // 
            fechaColumn.DataPropertyName = "fecha";
            fechaColumn.HeaderText = "Fecha";
            fechaColumn.Name = "fechaColumn";
            fechaColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "AlquilerId";
            dataGridViewTextBoxColumn2.HeaderText = "Alquiler";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "TanqueLleno";
            dataGridViewTextBoxColumn3.HeaderText = "Tanque Lleno";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Observaciones";
            dataGridViewTextBoxColumn4.HeaderText = "Observaciones";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewAlquileres);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(943, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Alquileres";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAlquileres
            // 
            dataGridViewAlquileres.AllowUserToOrderColumns = true;
            dataGridViewAlquileres.BackgroundColor = Color.MidnightBlue;
            dataGridViewAlquileres.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAlquileres.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewAlquileres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlquileres.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn6, DniConductor, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewAlquileres.GridColor = Color.MidnightBlue;
            dataGridViewAlquileres.Location = new Point(0, 0);
            dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            dataGridViewAlquileres.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.Size = new Size(950, 315);
            dataGridViewAlquileres.TabIndex = 14;
            dataGridViewAlquileres.CellClick += dataGridViewAlquileres_CellClick;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Id";
            dataGridViewTextBoxColumn5.HeaderText = "ID";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "FechaInicio";
            dataGridViewTextBoxColumn8.HeaderText = "Fecha Inicio";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "FechaFin";
            dataGridViewTextBoxColumn9.HeaderText = "Fecha Devolución";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "VehiculoPatente";
            dataGridViewTextBoxColumn7.HeaderText = "Vehículo";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Precio";
            dataGridViewTextBoxColumn10.HeaderText = "Precio";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "ClienteId";
            dataGridViewTextBoxColumn6.HeaderText = "Cliente";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DniConductor
            // 
            DniConductor.DataPropertyName = "ConductorId";
            DniConductor.HeaderText = "Conductor";
            DniConductor.Name = "DniConductor";
            DniConductor.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "ReservaId";
            dataGridViewTextBoxColumn11.HeaderText = "ID Reserva";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "EstadoId";
            dataGridViewTextBoxColumn12.HeaderText = "Estado";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // FormDevoluciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1396, 364);
            Controls.Add(tabControlDevoluciones);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Name = "FormDevoluciones";
            Text = "Devoluciones";
            Load += FormDevoluciones_Load;
            ((System.ComponentModel.ISupportInitialize)devolucionBindingSource).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            tabControlDevoluciones.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevoluciones).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).EndInit();
            ResumeLayout(false);
        }

        #endregion
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
        private DataGridView dataGridViewDevoluciones;
        private DataGridView dataGridViewAlquileres;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DniConductor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn fechaColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}