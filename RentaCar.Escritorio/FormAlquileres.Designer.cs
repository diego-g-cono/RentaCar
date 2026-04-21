namespace RentaCar.Escritorio
{
    partial class FormAlquileres
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tabControlAlquileres = new TabControl();
            tabPage1 = new TabPage();
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
            tabPage2 = new TabPage();
            dataGridViewVehiculos = new DataGridView();
            ColumnPatente = new DataGridViewTextBoxColumn();
            ColumnMarca = new DataGridViewTextBoxColumn();
            ColumnModelo = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnAnio = new DataGridViewTextBoxColumn();
            ColumnColor = new DataGridViewTextBoxColumn();
            ColumnCombustible = new DataGridViewTextBoxColumn();
            ColumnKm = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            tabPage5 = new TabPage();
            dataGridViewClientes = new DataGridView();
            ColumnDNI = new DataGridViewTextBoxColumn();
            ColumnNombre = new DataGridViewTextBoxColumn();
            ColumnApellido = new DataGridViewTextBoxColumn();
            ColumnEmail = new DataGridViewTextBoxColumn();
            ColumnTelefono = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            dataGridViewConductores = new DataGridView();
            ColumnDniCond = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            dataGridViewReserva = new DataGridView();
            ColumnId = new DataGridViewTextBoxColumn();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnVehiculo = new DataGridViewTextBoxColumn();
            ColumnFechaRetiro = new DataGridViewTextBoxColumn();
            ColumnFechaDevolucion = new DataGridViewTextBoxColumn();
            ColumnPrecio = new DataGridViewTextBoxColumn();
            ColumnSenia = new DataGridViewTextBoxColumn();
            ColumnEstadoReserva = new DataGridViewTextBoxColumn();
            buttonEliminar = new Button();
            buttonEditar = new Button();
            buttonNuevo = new Button();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            groupBoxAlquileres = new GroupBox();
            comboBoxEstado = new ComboBox();
            labelEstado = new Label();
            textBoxReserva = new TextBox();
            textBoxDniCond = new TextBox();
            label1 = new Label();
            textBoxDniCliente = new TextBox();
            dtpFechaDevolucion = new DateTimePicker();
            labelFechaDevolucion = new Label();
            numericUpDownPrecio = new NumericUpDown();
            dtpFechaInicio = new DateTimePicker();
            labelIdReserva = new Label();
            labelDNICliente = new Label();
            textBoxVehiculo = new TextBox();
            labelPrecio = new Label();
            labelVehiculo = new Label();
            labelCliente = new Label();
            tabControlAlquileres.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConductores).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserva).BeginInit();
            groupBoxAlquileres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // tabControlAlquileres
            // 
            tabControlAlquileres.Controls.Add(tabPage1);
            tabControlAlquileres.Controls.Add(tabPage2);
            tabControlAlquileres.Controls.Add(tabPage5);
            tabControlAlquileres.Controls.Add(tabPage3);
            tabControlAlquileres.Controls.Add(tabPage4);
            tabControlAlquileres.Location = new Point(398, 50);
            tabControlAlquileres.Name = "tabControlAlquileres";
            tabControlAlquileres.SelectedIndex = 0;
            tabControlAlquileres.Size = new Size(950, 339);
            tabControlAlquileres.TabIndex = 18;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.MidnightBlue;
            tabPage1.Controls.Add(dataGridViewAlquileres);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 311);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Alquileres";
            // 
            // dataGridViewAlquileres
            // 
            dataGridViewAlquileres.AllowUserToOrderColumns = true;
            dataGridViewAlquileres.BackgroundColor = Color.MidnightBlue;
            dataGridViewAlquileres.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewAlquileres.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewAlquileres.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewAlquileres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewAlquileres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAlquileres.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn6, DniConductor, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12 });
            dataGridViewAlquileres.GridColor = Color.MidnightBlue;
            dataGridViewAlquileres.Location = new Point(0, 0);
            dataGridViewAlquileres.Name = "dataGridViewAlquileres";
            dataGridViewAlquileres.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewAlquileres.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewAlquileres.Size = new Size(950, 315);
            dataGridViewAlquileres.TabIndex = 13;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridViewVehiculos);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Vehiculos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.AllowUserToOrderColumns = true;
            dataGridViewVehiculos.BackgroundColor = Color.MidnightBlue;
            dataGridViewVehiculos.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewVehiculos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewVehiculos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewVehiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Columns.AddRange(new DataGridViewColumn[] { ColumnPatente, ColumnMarca, ColumnModelo, ColumnTipo, ColumnAnio, ColumnColor, ColumnCombustible, ColumnKm, ColumnEstado });
            dataGridViewVehiculos.GridColor = Color.MidnightBlue;
            dataGridViewVehiculos.Location = new Point(-2, -1);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle4.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle4.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewVehiculos.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewVehiculos.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewVehiculos.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculos.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewVehiculos.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewVehiculos.Size = new Size(950, 313);
            dataGridViewVehiculos.TabIndex = 8;
            dataGridViewVehiculos.CellClick += dataGridViewVehiculos_CellClick;
            // 
            // ColumnPatente
            // 
            ColumnPatente.DataPropertyName = "Patente";
            ColumnPatente.HeaderText = "Patente";
            ColumnPatente.Name = "ColumnPatente";
            ColumnPatente.ReadOnly = true;
            // 
            // ColumnMarca
            // 
            ColumnMarca.DataPropertyName = "Marca";
            ColumnMarca.HeaderText = "Marca";
            ColumnMarca.Name = "ColumnMarca";
            ColumnMarca.ReadOnly = true;
            // 
            // ColumnModelo
            // 
            ColumnModelo.DataPropertyName = "Modelo";
            ColumnModelo.HeaderText = "Modelo";
            ColumnModelo.Name = "ColumnModelo";
            ColumnModelo.ReadOnly = true;
            // 
            // ColumnTipo
            // 
            ColumnTipo.DataPropertyName = "Tipo";
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.ReadOnly = true;
            // 
            // ColumnAnio
            // 
            ColumnAnio.DataPropertyName = "Anio";
            ColumnAnio.HeaderText = "Año";
            ColumnAnio.Name = "ColumnAnio";
            ColumnAnio.ReadOnly = true;
            // 
            // ColumnColor
            // 
            ColumnColor.DataPropertyName = "Color";
            ColumnColor.HeaderText = "Color";
            ColumnColor.Name = "ColumnColor";
            ColumnColor.ReadOnly = true;
            // 
            // ColumnCombustible
            // 
            ColumnCombustible.DataPropertyName = "Combustible";
            ColumnCombustible.HeaderText = "Combustible";
            ColumnCombustible.Name = "ColumnCombustible";
            ColumnCombustible.ReadOnly = true;
            // 
            // ColumnKm
            // 
            ColumnKm.DataPropertyName = "Kilometraje";
            ColumnKm.HeaderText = "Kilometraje";
            ColumnKm.Name = "ColumnKm";
            ColumnKm.ReadOnly = true;
            // 
            // ColumnEstado
            // 
            ColumnEstado.DataPropertyName = "Estado";
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.ReadOnly = true;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.MidnightBlue;
            tabPage5.Controls.Add(dataGridViewClientes);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(942, 311);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Clientes";
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToOrderColumns = true;
            dataGridViewClientes.BackgroundColor = Color.MidnightBlue;
            dataGridViewClientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewClientes.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle5.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle5.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColumnDNI, ColumnNombre, ColumnApellido, ColumnEmail, ColumnTelefono });
            dataGridViewClientes.GridColor = Color.MidnightBlue;
            dataGridViewClientes.Location = new Point(-4, 0);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewCellStyle6.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle6.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewClientes.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewClientes.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewClientes.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewClientes.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewClientes.Size = new Size(543, 278);
            dataGridViewClientes.TabIndex = 11;
            dataGridViewClientes.CellClick += dataGridViewClientes_CellClick;
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
            // tabPage3
            // 
            tabPage3.BackColor = Color.MidnightBlue;
            tabPage3.Controls.Add(dataGridViewConductores);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(942, 311);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Conductores";
            // 
            // dataGridViewConductores
            // 
            dataGridViewConductores.AllowUserToOrderColumns = true;
            dataGridViewConductores.BackgroundColor = Color.MidnightBlue;
            dataGridViewConductores.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewConductores.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewConductores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle7.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle7.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridViewConductores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewConductores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConductores.Columns.AddRange(new DataGridViewColumn[] { ColumnDniCond, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewConductores.GridColor = Color.MidnightBlue;
            dataGridViewConductores.Location = new Point(0, 3);
            dataGridViewConductores.Name = "dataGridViewConductores";
            dataGridViewConductores.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle8.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle8.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewConductores.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewConductores.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewConductores.Size = new Size(444, 255);
            dataGridViewConductores.TabIndex = 31;
            dataGridViewConductores.CellClick += dataGridViewConductores_CellClick;
            // 
            // ColumnDniCond
            // 
            ColumnDniCond.DataPropertyName = "DNI";
            ColumnDniCond.HeaderText = "DNI";
            ColumnDniCond.Name = "ColumnDniCond";
            ColumnDniCond.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "fechaVencLic";
            dataGridViewTextBoxColumn2.HeaderText = "Vence Lic.";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Apellido";
            dataGridViewTextBoxColumn4.HeaderText = "Apellido";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.MidnightBlue;
            tabPage4.Controls.Add(dataGridViewReserva);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(942, 311);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reservas";
            // 
            // dataGridViewReserva
            // 
            dataGridViewReserva.AllowUserToOrderColumns = true;
            dataGridViewReserva.BackgroundColor = Color.MidnightBlue;
            dataGridViewReserva.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewReserva.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewReserva.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle9.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle9.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewReserva.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewReserva.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReserva.Columns.AddRange(new DataGridViewColumn[] { ColumnId, ColumnCliente, ColumnVehiculo, ColumnFechaRetiro, ColumnFechaDevolucion, ColumnPrecio, ColumnSenia, ColumnEstadoReserva });
            dataGridViewReserva.GridColor = Color.MidnightBlue;
            dataGridViewReserva.Location = new Point(3, 3);
            dataGridViewReserva.Name = "dataGridViewReserva";
            dataGridViewReserva.ReadOnly = true;
            dataGridViewCellStyle10.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle10.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle10.SelectionBackColor = Color.RoyalBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.BackColor = Color.MidnightBlue;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewReserva.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.RoyalBlue;
            dataGridViewReserva.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.ButtonFace;
            dataGridViewReserva.Size = new Size(843, 305);
            dataGridViewReserva.TabIndex = 12;
            dataGridViewReserva.CellClick += dataGridViewReserva_CellClick;
            // 
            // ColumnId
            // 
            ColumnId.DataPropertyName = "Id";
            ColumnId.HeaderText = "ID";
            ColumnId.Name = "ColumnId";
            ColumnId.ReadOnly = true;
            // 
            // ColumnCliente
            // 
            ColumnCliente.DataPropertyName = "ClienteDni";
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            ColumnCliente.ReadOnly = true;
            // 
            // ColumnVehiculo
            // 
            ColumnVehiculo.DataPropertyName = "VehiculoPatente";
            ColumnVehiculo.HeaderText = "Vehículo";
            ColumnVehiculo.Name = "ColumnVehiculo";
            ColumnVehiculo.ReadOnly = true;
            // 
            // ColumnFechaRetiro
            // 
            ColumnFechaRetiro.DataPropertyName = "FechaInicio";
            ColumnFechaRetiro.HeaderText = "Fecha Retiro";
            ColumnFechaRetiro.Name = "ColumnFechaRetiro";
            ColumnFechaRetiro.ReadOnly = true;
            // 
            // ColumnFechaDevolucion
            // 
            ColumnFechaDevolucion.DataPropertyName = "FechaFin";
            ColumnFechaDevolucion.HeaderText = "Fecha Devolución";
            ColumnFechaDevolucion.Name = "ColumnFechaDevolucion";
            ColumnFechaDevolucion.ReadOnly = true;
            // 
            // ColumnPrecio
            // 
            ColumnPrecio.DataPropertyName = "Precio";
            ColumnPrecio.HeaderText = "Precio";
            ColumnPrecio.Name = "ColumnPrecio";
            ColumnPrecio.ReadOnly = true;
            // 
            // ColumnSenia
            // 
            ColumnSenia.DataPropertyName = "Senia";
            ColumnSenia.HeaderText = "Seña";
            ColumnSenia.Name = "ColumnSenia";
            ColumnSenia.ReadOnly = true;
            // 
            // ColumnEstadoReserva
            // 
            ColumnEstadoReserva.DataPropertyName = "Estado";
            ColumnEstadoReserva.HeaderText = "Estado";
            ColumnEstadoReserva.Name = "ColumnEstadoReserva";
            ColumnEstadoReserva.ReadOnly = true;
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
            buttonEliminar.Location = new Point(274, 12);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 21;
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
            buttonEditar.Location = new Point(170, 12);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 20;
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
            buttonNuevo.Location = new Point(71, 12);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(77, 33);
            buttonNuevo.TabIndex = 19;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += buttonNuevo_Click;
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
            buttonCancelar.Location = new Point(274, 375);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 23;
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
            buttonGuardar.Location = new Point(71, 375);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
            buttonGuardar.TabIndex = 22;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // groupBoxAlquileres
            // 
            groupBoxAlquileres.Controls.Add(comboBoxEstado);
            groupBoxAlquileres.Controls.Add(labelEstado);
            groupBoxAlquileres.Controls.Add(textBoxReserva);
            groupBoxAlquileres.Controls.Add(textBoxDniCond);
            groupBoxAlquileres.Controls.Add(label1);
            groupBoxAlquileres.Controls.Add(textBoxDniCliente);
            groupBoxAlquileres.Controls.Add(dtpFechaDevolucion);
            groupBoxAlquileres.Controls.Add(labelFechaDevolucion);
            groupBoxAlquileres.Controls.Add(numericUpDownPrecio);
            groupBoxAlquileres.Controls.Add(dtpFechaInicio);
            groupBoxAlquileres.Controls.Add(labelIdReserva);
            groupBoxAlquileres.Controls.Add(labelDNICliente);
            groupBoxAlquileres.Controls.Add(textBoxVehiculo);
            groupBoxAlquileres.Controls.Add(labelPrecio);
            groupBoxAlquileres.Controls.Add(labelVehiculo);
            groupBoxAlquileres.Controls.Add(labelCliente);
            groupBoxAlquileres.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBoxAlquileres.ForeColor = SystemColors.ButtonFace;
            groupBoxAlquileres.Location = new Point(12, 51);
            groupBoxAlquileres.Name = "groupBoxAlquileres";
            groupBoxAlquileres.Size = new Size(370, 318);
            groupBoxAlquileres.TabIndex = 24;
            groupBoxAlquileres.TabStop = false;
            groupBoxAlquileres.Text = "Datos Alquiler";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.MidnightBlue;
            comboBoxEstado.ForeColor = SystemColors.ButtonFace;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(149, 272);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 22);
            comboBoxEstado.TabIndex = 35;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Verdana", 9F);
            labelEstado.Location = new Point(22, 272);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(56, 14);
            labelEstado.TabIndex = 34;
            labelEstado.Text = "Estado:";
            // 
            // textBoxReserva
            // 
            textBoxReserva.BackColor = Color.MidnightBlue;
            textBoxReserva.BorderStyle = BorderStyle.FixedSingle;
            textBoxReserva.Font = new Font("Verdana", 9F);
            textBoxReserva.ForeColor = SystemColors.ButtonFace;
            textBoxReserva.Location = new Point(149, 233);
            textBoxReserva.Name = "textBoxReserva";
            textBoxReserva.ReadOnly = true;
            textBoxReserva.Size = new Size(121, 22);
            textBoxReserva.TabIndex = 33;
            // 
            // textBoxDniCond
            // 
            textBoxDniCond.BackColor = Color.MidnightBlue;
            textBoxDniCond.BorderStyle = BorderStyle.FixedSingle;
            textBoxDniCond.Font = new Font("Verdana", 9F);
            textBoxDniCond.ForeColor = SystemColors.ButtonFace;
            textBoxDniCond.Location = new Point(149, 192);
            textBoxDniCond.Name = "textBoxDniCond";
            textBoxDniCond.ReadOnly = true;
            textBoxDniCond.Size = new Size(121, 22);
            textBoxDniCond.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(19, 194);
            label1.Name = "label1";
            label1.Size = new Size(104, 14);
            label1.TabIndex = 31;
            label1.Text = "DNI Conductor:";
            // 
            // textBoxDniCliente
            // 
            textBoxDniCliente.BackColor = Color.MidnightBlue;
            textBoxDniCliente.BorderStyle = BorderStyle.FixedSingle;
            textBoxDniCliente.Font = new Font("Verdana", 9F);
            textBoxDniCliente.ForeColor = SystemColors.ButtonFace;
            textBoxDniCliente.Location = new Point(150, 157);
            textBoxDniCliente.Name = "textBoxDniCliente";
            textBoxDniCliente.ReadOnly = true;
            textBoxDniCliente.Size = new Size(120, 22);
            textBoxDniCliente.TabIndex = 30;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(150, 61);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(200, 22);
            dtpFechaDevolucion.TabIndex = 29;
            // 
            // labelFechaDevolucion
            // 
            labelFechaDevolucion.AutoSize = true;
            labelFechaDevolucion.Font = new Font("Verdana", 9F);
            labelFechaDevolucion.Location = new Point(19, 67);
            labelFechaDevolucion.Name = "labelFechaDevolucion";
            labelFechaDevolucion.Size = new Size(121, 14);
            labelFechaDevolucion.TabIndex = 28;
            labelFechaDevolucion.Text = "Fecha Devolución:";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.BackColor = Color.MidnightBlue;
            numericUpDownPrecio.ForeColor = SystemColors.ButtonFace;
            numericUpDownPrecio.Location = new Point(151, 126);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(121, 22);
            numericUpDownPrecio.TabIndex = 25;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(150, 24);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(200, 22);
            dtpFechaInicio.TabIndex = 23;
            // 
            // labelIdReserva
            // 
            labelIdReserva.AutoSize = true;
            labelIdReserva.Font = new Font("Verdana", 9F);
            labelIdReserva.Location = new Point(19, 235);
            labelIdReserva.Name = "labelIdReserva";
            labelIdReserva.Size = new Size(63, 14);
            labelIdReserva.TabIndex = 22;
            labelIdReserva.Text = "Reserva:";
            // 
            // labelDNICliente
            // 
            labelDNICliente.AutoSize = true;
            labelDNICliente.Font = new Font("Verdana", 9F);
            labelDNICliente.Location = new Point(19, 159);
            labelDNICliente.Name = "labelDNICliente";
            labelDNICliente.Size = new Size(83, 14);
            labelDNICliente.TabIndex = 21;
            labelDNICliente.Text = "DNI Cliente:";
            // 
            // textBoxVehiculo
            // 
            textBoxVehiculo.BackColor = Color.MidnightBlue;
            textBoxVehiculo.BorderStyle = BorderStyle.FixedSingle;
            textBoxVehiculo.Font = new Font("Verdana", 9F);
            textBoxVehiculo.ForeColor = SystemColors.ButtonFace;
            textBoxVehiculo.Location = new Point(151, 95);
            textBoxVehiculo.Name = "textBoxVehiculo";
            textBoxVehiculo.ReadOnly = true;
            textBoxVehiculo.Size = new Size(121, 22);
            textBoxVehiculo.TabIndex = 17;
            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Verdana", 9F);
            labelPrecio.Location = new Point(19, 126);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(50, 14);
            labelPrecio.TabIndex = 3;
            labelPrecio.Text = "Precio:";
            // 
            // labelVehiculo
            // 
            labelVehiculo.AutoSize = true;
            labelVehiculo.Font = new Font("Verdana", 9F);
            labelVehiculo.Location = new Point(19, 95);
            labelVehiculo.Name = "labelVehiculo";
            labelVehiculo.Size = new Size(117, 14);
            labelVehiculo.TabIndex = 1;
            labelVehiculo.Text = "Patente Vehiculo:";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Font = new Font("Verdana", 9F);
            labelCliente.Location = new Point(19, 30);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(86, 14);
            labelCliente.TabIndex = 0;
            labelCliente.Text = "Fecha Inicio:";
            // 
            // FormAlquileres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1387, 430);
            Controls.Add(groupBoxAlquileres);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Controls.Add(tabControlAlquileres);
            Name = "FormAlquileres";
            Text = "Alquileres";
            Load += FormAlquileres_Load;
            tabControlAlquileres.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAlquileres).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewConductores).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReserva).EndInit();
            groupBoxAlquileres.ResumeLayout(false);
            groupBoxAlquileres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlAlquileres;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridViewVehiculos;
        private DataGridViewTextBoxColumn ColumnPatente;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnAnio;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnCombustible;
        private DataGridViewTextBoxColumn ColumnKm;
        private DataGridViewTextBoxColumn ColumnEstado;
        private TabPage tabPage5;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn ColumnDNI;
        private DataGridViewTextBoxColumn ColumnNombre;
        private DataGridViewTextBoxColumn ColumnApellido;
        private DataGridViewTextBoxColumn ColumnEmail;
        private DataGridViewTextBoxColumn ColumnTelefono;
        private DataGridView dataGridViewReserva;
        private DataGridViewTextBoxColumn ColumnId;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnVehiculo;
        private DataGridViewTextBoxColumn ColumnFechaRetiro;
        private DataGridViewTextBoxColumn ColumnFechaDevolucion;
        private DataGridViewTextBoxColumn ColumnPrecio;
        private DataGridViewTextBoxColumn ColumnSenia;
        private DataGridViewTextBoxColumn ColumnEstadoReserva;
        private Button buttonEliminar;
        private Button buttonEditar;
        private Button buttonNuevo;
        private Button buttonCancelar;
        private Button buttonGuardar;
        private GroupBox groupBoxAlquileres;
        private NumericUpDown numericUpDownPrecio;
        private DateTimePicker dtpFechaInicio;
        private Label labelIdReserva;
        private Label labelDNICliente;
        private TextBox textBoxVehiculo;
        private Label labelPrecio;
        private Label labelVehiculo;
        private Label labelCliente;
        private DateTimePicker dtpFechaDevolucion;
        private Label labelFechaDevolucion;
        private TextBox textBoxDniCliente;
        private TextBox textBoxDniCond;
        private Label label1;
        private TextBox textBoxReserva;
        private ComboBox comboBoxEstado;
        private Label labelEstado;
        private DataGridView dataGridViewConductores;
        private DataGridView dataGridViewAlquileres;
        private DataGridViewTextBoxColumn ColumnDniCond;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DniConductor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}