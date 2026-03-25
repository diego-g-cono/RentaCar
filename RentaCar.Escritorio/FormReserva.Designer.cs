namespace RentaCar.Escritorio
{
    partial class FormReserva
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            groupBox = new GroupBox();
            comboBoxEstado = new ComboBox();
            numericUpDownSenia = new NumericUpDown();
            numericUpDownPrecio = new NumericUpDown();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaRetiro = new DateTimePicker();
            labelEstado = new Label();
            labelSenia = new Label();
            textBoxVehiculo = new TextBox();
            labelFechaDevolucion = new Label();
            textBoxCliente = new TextBox();
            labelPrecio = new Label();
            labelFechaInicio = new Label();
            labelVehiculo = new Label();
            labelCliente = new Label();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            tabControl = new TabControl();
            tabPageReserva = new TabPage();
            dataGridViewReserva = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnVehiculo = new DataGridViewTextBoxColumn();
            ColumnFechaRetiro = new DataGridViewTextBoxColumn();
            ColumnFechaDevolucion = new DataGridViewTextBoxColumn();
            ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnSenia = new DataGridViewTextBoxColumn();
            ColumnEstadoReserva = new DataGridViewTextBoxColumn();
            tabPageCliente = new TabPage();
            dataGridViewCliente = new DataGridView();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            tabPageVehiculo = new TabPage();
            dataGridViewVehiculo = new DataGridView();
            ColumnPatente = new DataGridViewTextBoxColumn();
            ColumnMarca = new DataGridViewTextBoxColumn();
            ColumnModelo = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnAnio = new DataGridViewTextBoxColumn();
            ColumnColor = new DataGridViewTextBoxColumn();
            ColumnCombustible = new DataGridViewTextBoxColumn();
            ColumnKm = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSenia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            tabControl.SuspendLayout();
            tabPageReserva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserva).BeginInit();
            tabPageCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).BeginInit();
            tabPageVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculo).BeginInit();
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
            buttonEliminar.Location = new Point(305, 12);
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
            buttonEditar.Location = new Point(162, 12);
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
            buttonNuevo.Click += buttonNuevo_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(comboBoxEstado);
            groupBox.Controls.Add(numericUpDownSenia);
            groupBox.Controls.Add(numericUpDownPrecio);
            groupBox.Controls.Add(dtpFechaDevolucion);
            groupBox.Controls.Add(dtpFechaRetiro);
            groupBox.Controls.Add(labelEstado);
            groupBox.Controls.Add(labelSenia);
            groupBox.Controls.Add(textBoxVehiculo);
            groupBox.Controls.Add(labelFechaDevolucion);
            groupBox.Controls.Add(textBoxCliente);
            groupBox.Controls.Add(labelPrecio);
            groupBox.Controls.Add(labelFechaInicio);
            groupBox.Controls.Add(labelVehiculo);
            groupBox.Controls.Add(labelCliente);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(12, 64);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(370, 280);
            groupBox.TabIndex = 7;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Reserva";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.MidnightBlue;
            comboBoxEstado.ForeColor = SystemColors.ButtonFace;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(151, 235);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 22);
            comboBoxEstado.TabIndex = 27;
            // 
            // numericUpDownSenia
            // 
            numericUpDownSenia.BackColor = Color.MidnightBlue;
            numericUpDownSenia.ForeColor = SystemColors.ButtonFace;
            numericUpDownSenia.Location = new Point(151, 201);
            numericUpDownSenia.Name = "numericUpDownSenia";
            numericUpDownSenia.Size = new Size(120, 22);
            numericUpDownSenia.TabIndex = 26;
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.BackColor = Color.MidnightBlue;
            numericUpDownPrecio.ForeColor = SystemColors.ButtonFace;
            numericUpDownPrecio.Location = new Point(151, 166);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(120, 22);
            numericUpDownPrecio.TabIndex = 25;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(150, 131);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(200, 22);
            dtpFechaDevolucion.TabIndex = 24;
            // 
            // dtpFechaRetiro
            // 
            dtpFechaRetiro.Location = new Point(150, 96);
            dtpFechaRetiro.Name = "dtpFechaRetiro";
            dtpFechaRetiro.Size = new Size(200, 22);
            dtpFechaRetiro.TabIndex = 23;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Verdana", 9F);
            labelEstado.Location = new Point(19, 238);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(56, 14);
            labelEstado.TabIndex = 22;
            labelEstado.Text = "Estado:";
            // 
            // labelSenia
            // 
            labelSenia.AutoSize = true;
            labelSenia.Font = new Font("Verdana", 9F);
            labelSenia.Location = new Point(19, 203);
            labelSenia.Name = "labelSenia";
            labelSenia.Size = new Size(44, 14);
            labelSenia.TabIndex = 21;
            labelSenia.Text = "Seña:";
            // 
            // textBoxVehiculo
            // 
            textBoxVehiculo.BackColor = Color.MidnightBlue;
            textBoxVehiculo.BorderStyle = BorderStyle.FixedSingle;
            textBoxVehiculo.Font = new Font("Verdana", 9F);
            textBoxVehiculo.ForeColor = SystemColors.ButtonFace;
            textBoxVehiculo.Location = new Point(150, 62);
            textBoxVehiculo.Name = "textBoxVehiculo";
            textBoxVehiculo.Size = new Size(121, 22);
            textBoxVehiculo.TabIndex = 17;
            textBoxVehiculo.TextChanged += textBoxPatente_TextChanged;
            // 
            // labelFechaDevolucion
            // 
            labelFechaDevolucion.AutoSize = true;
            labelFechaDevolucion.Font = new Font("Verdana", 9F);
            labelFechaDevolucion.Location = new Point(19, 137);
            labelFechaDevolucion.Name = "labelFechaDevolucion";
            labelFechaDevolucion.Size = new Size(121, 14);
            labelFechaDevolucion.TabIndex = 16;
            labelFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // textBoxCliente
            // 
            textBoxCliente.BackColor = Color.MidnightBlue;
            textBoxCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxCliente.Font = new Font("Verdana", 9F);
            textBoxCliente.ForeColor = SystemColors.ButtonFace;
            textBoxCliente.Location = new Point(150, 28);
            textBoxCliente.Name = "textBoxCliente";
            textBoxCliente.Size = new Size(121, 22);
            textBoxCliente.TabIndex = 8;
            textBoxCliente.KeyPress += textBoxCliente_KeyPress;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Verdana", 9F);
            labelPrecio.Location = new Point(19, 168);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 14);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio:";
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Font = new Font("Verdana", 9F);
            labelFechaInicio.Location = new Point(19, 102);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(90, 14);
            labelFechaInicio.TabIndex = 2;
            labelFechaInicio.Text = "Fecha Retiro:";
            // 
            // labelVehiculo
            // 
            labelVehiculo.AutoSize = true;
            labelVehiculo.Font = new Font("Verdana", 9F);
            labelVehiculo.Location = new Point(19, 64);
            labelVehiculo.Name = "labelVehiculo";
            labelVehiculo.Size = new Size(117, 14);
            labelVehiculo.TabIndex = 1;
            labelVehiculo.Text = "Vehículo Patente:";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Verdana", 9F);
            labelCliente.Location = new Point(19, 30);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(83, 14);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Cliente DNI:";
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
            buttonCancelar.Location = new Point(305, 364);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 10;
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
            buttonGuardar.Location = new Point(12, 364);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 9;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageReserva);
            tabControl.Controls.Add(tabPageCliente);
            tabControl.Controls.Add(tabPageVehiculo);
            tabControl.Location = new Point(416, 64);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(954, 447);
            tabControl.TabIndex = 12;
            // 
            // tabPageReserva
            // 
            tabPageReserva.BackColor = Color.MidnightBlue;
            tabPageReserva.Controls.Add(dataGridViewReserva);
            tabPageReserva.Location = new Point(4, 24);
            tabPageReserva.Name = "tabPageReserva";
            tabPageReserva.Size = new Size(946, 419);
            tabPageReserva.TabIndex = 2;
            tabPageReserva.Text = "Reservas";
            // 
            // dataGridViewReserva
            // 
            dataGridViewReserva.AllowUserToOrderColumns = true;
            dataGridViewReserva.BackgroundColor = Color.MidnightBlue;
            dataGridViewReserva.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewReserva.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewReserva.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReserva.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCliente, ColumnVehiculo, ColumnFechaRetiro, ColumnFechaDevolucion, ColumnPrecio, ColumnSenia, ColumnEstadoReserva });
            dataGridViewReserva.GridColor = Color.MidnightBlue;
            dataGridViewReserva.Location = new Point(0, 0);
            dataGridViewReserva.Name = "dataGridViewReserva";
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewReserva.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.Size = new Size(846, 365);
            dataGridViewReserva.TabIndex = 11;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "Id";
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            // 
            // ColumnCliente
            // 
            ColumnCliente.DataPropertyName = "ClienteDni";
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            // 
            // ColumnVehiculo
            // 
            ColumnVehiculo.DataPropertyName = "VehiculoPatente";
            ColumnVehiculo.HeaderText = "Vehículo";
            ColumnVehiculo.Name = "ColumnVehiculo";
            // 
            // ColumnFechaRetiro
            // 
            ColumnFechaRetiro.DataPropertyName = "FechaInicio";
            ColumnFechaRetiro.HeaderText = "Fecha Retiro";
            ColumnFechaRetiro.Name = "ColumnFechaRetiro";
            // 
            // ColumnFechaDevolucion
            // 
            ColumnFechaDevolucion.DataPropertyName = "FechaFin";
            ColumnFechaDevolucion.HeaderText = "Fecha Devolución";
            ColumnFechaDevolucion.Name = "ColumnFechaDevolucion";
            // 
            // ColumnPrecio
            // 
            ColumnPrecio.DataPropertyName = "Precio";
            ColumnPrecio.HeaderText = "Precio";
            ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnSenia
            // 
            ColumnSenia.DataPropertyName = "Senia";
            ColumnSenia.HeaderText = "Seña";
            ColumnSenia.Name = "ColumnSenia";
            // 
            // ColumnEstadoReserva
            // 
            ColumnEstadoReserva.DataPropertyName = "Estado";
            ColumnEstadoReserva.HeaderText = "Estado";
            ColumnEstadoReserva.Name = "ColumnEstadoReserva";
            // 
            // tabPageCliente
            // 
            tabPageCliente.BackColor = Color.MidnightBlue;
            tabPageCliente.Controls.Add(dataGridViewCliente);
            tabPageCliente.ForeColor = Color.MidnightBlue;
            tabPageCliente.Location = new Point(4, 24);
            tabPageCliente.Name = "tabPageCliente";
            tabPageCliente.Padding = new Padding(3);
            tabPageCliente.Size = new Size(946, 419);
            tabPageCliente.TabIndex = 0;
            tabPageCliente.Text = "Clientes";
            // 
            // dataGridViewCliente
            // 
            dataGridViewCliente.AllowUserToOrderColumns = true;
            dataGridViewCliente.BackgroundColor = Color.MidnightBlue;
            dataGridViewCliente.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCliente.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCliente.Columns.AddRange(new DataGridViewColumn[] { ColumnDNI, ColumnNombre, ColumnApellido, ColumnEmail, ColumnTelefono });
            dataGridViewCliente.GridColor = Color.MidnightBlue;
            dataGridViewCliente.Location = new Point(0, 0);
            dataGridViewCliente.Name = "dataGridViewCliente";
            dataGridViewCellStyle4.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCliente.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewCliente.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCliente.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewCliente.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCliente.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewCliente.Size = new Size(543, 365);
            dataGridViewCliente.TabIndex = 10;
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
            // tabPageVehiculo
            // 
            tabPageVehiculo.BackColor = Color.MidnightBlue;
            tabPageVehiculo.Controls.Add(dataGridViewVehiculo);
            tabPageVehiculo.Location = new Point(4, 24);
            tabPageVehiculo.Name = "tabPageVehiculo";
            tabPageVehiculo.Padding = new Padding(3);
            tabPageVehiculo.Size = new Size(946, 419);
            tabPageVehiculo.TabIndex = 1;
            tabPageVehiculo.Text = "Vehículos";
            // 
            // dataGridViewVehiculo
            // 
            dataGridViewVehiculo.AllowUserToOrderColumns = true;
            dataGridViewVehiculo.BackgroundColor = Color.MidnightBlue;
            dataGridViewVehiculo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewVehiculo.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewVehiculo.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewVehiculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculo.Columns.AddRange(new DataGridViewColumn[] { ColumnPatente, ColumnMarca, ColumnModelo, ColumnTipo, ColumnAnio, ColumnColor, ColumnCombustible, ColumnKm, ColumnEstado });
            dataGridViewVehiculo.GridColor = Color.MidnightBlue;
            dataGridViewVehiculo.Location = new Point(0, 0);
            dataGridViewVehiculo.Name = "dataGridViewVehiculo";
            dataGridViewCellStyle6.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle6.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewVehiculo.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewVehiculo.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewVehiculo.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculo.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewVehiculo.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculo.Size = new Size(944, 361);
            dataGridViewVehiculo.TabIndex = 7;
            // 
            // ColumnPatente
            // 
            ColumnPatente.DataPropertyName = "Patente";
            ColumnPatente.HeaderText = "Patente";
            ColumnPatente.Name = "ColumnPatente";
            // 
            // ColumnMarca
            // 
            ColumnMarca.DataPropertyName = "Marca";
            ColumnMarca.HeaderText = "Marca";
            ColumnMarca.Name = "ColumnMarca";
            // 
            // ColumnModelo
            // 
            ColumnModelo.DataPropertyName = "Modelo";
            ColumnModelo.HeaderText = "Modelo";
            ColumnModelo.Name = "ColumnModelo";
            // 
            // ColumnTipo
            // 
            ColumnTipo.DataPropertyName = "Tipo";
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.Name = "ColumnTipo";
            // 
            // ColumnAnio
            // 
            ColumnAnio.DataPropertyName = "Anio";
            ColumnAnio.HeaderText = "Año";
            ColumnAnio.Name = "ColumnAnio";
            // 
            // ColumnColor
            // 
            ColumnColor.DataPropertyName = "Color";
            ColumnColor.HeaderText = "Color";
            ColumnColor.Name = "ColumnColor";
            // 
            // ColumnCombustible
            // 
            ColumnCombustible.DataPropertyName = "Combustible";
            ColumnCombustible.HeaderText = "Combustible";
            ColumnCombustible.Name = "ColumnCombustible";
            // 
            // ColumnKm
            // 
            ColumnKm.DataPropertyName = "Kilometraje";
            ColumnKm.HeaderText = "Kilometraje";
            ColumnKm.Name = "ColumnKm";
            // 
            // ColumnEstado
            // 
            ColumnEstado.DataPropertyName = "Estado";
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.Name = "ColumnEstado";
            // 
            // FormReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1432, 547);
            Controls.Add(tabControl);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormReserva";
            Text = "Reservas";
            Load += FormReserva_Load;
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSenia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            tabControl.ResumeLayout(false);
            tabPageReserva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserva).EndInit();
            tabPageCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCliente).EndInit();
            tabPageVehiculo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private GroupBox groupBox;
        private TextBox textBoxVehiculo;
        private Label labelFechaDevolucion;
        private TextBox textBoxCliente;
        private Label labelPrecio;
        private Label labelFechaInicio;
        private Label labelVehiculo;
        private Label labelCliente;
        private Label labelEstado;
        private Label labelSenia;
        private ComboBox comboBoxEstado;
        private NumericUpDown numericUpDownSenia;
        private NumericUpDown numericUpDownPrecio;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaRetiro;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private TabControl tabControl;
        private TabPage tabPageCliente;
        private TabPage tabPageVehiculo;
        private TabPage tabPageReserva;
        private DataGridView dataGridViewCliente;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private DataGridView dataGridViewVehiculo;
        private DataGridViewTextBoxColumn ColumnPatente;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnAnio;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnCombustible;
        private DataGridViewTextBoxColumn ColumnKm;
        private DataGridViewTextBoxColumn ColumnEstado;
        private DataGridView dataGridViewReserva;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnVehiculo;
        private DataGridViewTextBoxColumn ColumnFechaRetiro;
        private DataGridViewTextBoxColumn ColumnFechaDevolucion;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnSenia;
        private DataGridViewTextBoxColumn ColumnEstadoReserva;
    }
}