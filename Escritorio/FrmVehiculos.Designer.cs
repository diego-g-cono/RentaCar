namespace Escritorio
{
    partial class FrmVehiculos
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
            grBoxVehi = new GroupBox();
            numBoxKm = new NumericUpDown();
            label9 = new Label();
            cmbBoxEstado = new ComboBox();
            cmbBoxCombustible = new ComboBox();
            cmbBoxColor = new ComboBox();
            numBoxAnio = new NumericUpDown();
            cmbBoxModelo = new ComboBox();
            cmbBoxMarca = new ComboBox();
            txtBoxPatente = new TextBox();
            labelEstado = new Label();
            labelKm = new Label();
            labelCombustible = new Label();
            labelColor = new Label();
            labelAnio = new Label();
            labelModelo = new Label();
            labelMarca = new Label();
            labelPatente = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            dataGridViewVehiculos = new DataGridView();
            ColumnaPatente = new DataGridViewTextBoxColumn();
            ColumnaMarca = new DataGridViewTextBoxColumn();
            ColumnaModelo = new DataGridViewTextBoxColumn();
            ColumnaAnio = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            ColumnaCombustible = new DataGridViewTextBoxColumn();
            ColumnaKm = new DataGridViewTextBoxColumn();
            ColumnaEstado = new DataGridViewTextBoxColumn();
            btnActTable = new Button();
            grBoxVehi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBoxAnio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).BeginInit();
            SuspendLayout();
            // 
            // grBoxVehi
            // 
            grBoxVehi.Controls.Add(numBoxKm);
            grBoxVehi.Controls.Add(label9);
            grBoxVehi.Controls.Add(cmbBoxEstado);
            grBoxVehi.Controls.Add(cmbBoxCombustible);
            grBoxVehi.Controls.Add(cmbBoxColor);
            grBoxVehi.Controls.Add(numBoxAnio);
            grBoxVehi.Controls.Add(cmbBoxModelo);
            grBoxVehi.Controls.Add(cmbBoxMarca);
            grBoxVehi.Controls.Add(txtBoxPatente);
            grBoxVehi.Controls.Add(labelEstado);
            grBoxVehi.Controls.Add(labelKm);
            grBoxVehi.Controls.Add(labelCombustible);
            grBoxVehi.Controls.Add(labelColor);
            grBoxVehi.Controls.Add(labelAnio);
            grBoxVehi.Controls.Add(labelModelo);
            grBoxVehi.Controls.Add(labelMarca);
            grBoxVehi.Controls.Add(labelPatente);
            grBoxVehi.Location = new Point(12, 46);
            grBoxVehi.Name = "grBoxVehi";
            grBoxVehi.Size = new Size(303, 324);
            grBoxVehi.TabIndex = 0;
            grBoxVehi.TabStop = false;
            grBoxVehi.Text = "Datos Vehículo";
            // 
            // numBoxKm
            // 
            numBoxKm.Location = new Point(90, 235);
            numBoxKm.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numBoxKm.Name = "numBoxKm";
            numBoxKm.Size = new Size(120, 23);
            numBoxKm.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(219, 237);
            label9.Name = "label9";
            label9.Size = new Size(24, 15);
            label9.TabIndex = 16;
            label9.Text = "km";
            // 
            // cmbBoxEstado
            // 
            cmbBoxEstado.FormattingEnabled = true;
            cmbBoxEstado.Location = new Point(90, 266);
            cmbBoxEstado.Name = "cmbBoxEstado";
            cmbBoxEstado.Size = new Size(121, 23);
            cmbBoxEstado.TabIndex = 15;
            // 
            // cmbBoxCombustible
            // 
            cmbBoxCombustible.FormattingEnabled = true;
            cmbBoxCombustible.Location = new Point(90, 199);
            cmbBoxCombustible.Name = "cmbBoxCombustible";
            cmbBoxCombustible.Size = new Size(121, 23);
            cmbBoxCombustible.TabIndex = 13;
            // 
            // cmbBoxColor
            // 
            cmbBoxColor.FormattingEnabled = true;
            cmbBoxColor.Location = new Point(90, 165);
            cmbBoxColor.Name = "cmbBoxColor";
            cmbBoxColor.Size = new Size(121, 23);
            cmbBoxColor.TabIndex = 12;
            // 
            // numBoxAnio
            // 
            numBoxAnio.Location = new Point(91, 123);
            numBoxAnio.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numBoxAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numBoxAnio.Name = "numBoxAnio";
            numBoxAnio.Size = new Size(120, 23);
            numBoxAnio.TabIndex = 11;
            numBoxAnio.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // cmbBoxModelo
            // 
            cmbBoxModelo.FormattingEnabled = true;
            cmbBoxModelo.Location = new Point(90, 82);
            cmbBoxModelo.Name = "cmbBoxModelo";
            cmbBoxModelo.Size = new Size(121, 23);
            cmbBoxModelo.TabIndex = 10;
            // 
            // cmbBoxMarca
            // 
            cmbBoxMarca.FormattingEnabled = true;
            cmbBoxMarca.Items.AddRange(new object[] { "Toyota", "", "Ford", "", "Chevrolet", "", "Volkswagen", "", "Renault", "", "Peugeot", "", "Honda", "", "Nissan", "", "Fiat", "", "Hyundai", "", "Kia", "", "BMW", "", "Mercedes-Benz", "", "Audi", "", "Citroën" });
            cmbBoxMarca.Location = new Point(90, 47);
            cmbBoxMarca.Name = "cmbBoxMarca";
            cmbBoxMarca.Size = new Size(121, 23);
            cmbBoxMarca.TabIndex = 9;
            cmbBoxMarca.SelectedIndexChanged += cmbBoxMarca_SelectedIndexChanged;
            // 
            // txtBoxPatente
            // 
            txtBoxPatente.Location = new Point(91, 16);
            txtBoxPatente.Name = "txtBoxPatente";
            txtBoxPatente.Size = new Size(120, 23);
            txtBoxPatente.TabIndex = 8;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(6, 269);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(45, 15);
            labelEstado.TabIndex = 7;
            labelEstado.Text = "Estado:";
            // 
            // labelKm
            // 
            labelKm.AutoSize = true;
            labelKm.Location = new Point(6, 237);
            labelKm.Name = "labelKm";
            labelKm.Size = new Size(70, 15);
            labelKm.TabIndex = 6;
            labelKm.Text = "Kilometraje:";
            // 
            // labelCombustible
            // 
            labelCombustible.AutoSize = true;
            labelCombustible.Location = new Point(6, 202);
            labelCombustible.Name = "labelCombustible";
            labelCombustible.Size = new Size(78, 15);
            labelCombustible.TabIndex = 5;
            labelCombustible.Text = "Combustible:";
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Location = new Point(6, 168);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(39, 15);
            labelColor.TabIndex = 4;
            labelColor.Text = "Color:";
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Location = new Point(6, 125);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(32, 15);
            labelAnio.TabIndex = 3;
            labelAnio.Text = "Año:";
            // 
            // labelModelo
            // 
            labelModelo.AutoSize = true;
            labelModelo.Location = new Point(6, 85);
            labelModelo.Name = "labelModelo";
            labelModelo.Size = new Size(51, 15);
            labelModelo.TabIndex = 2;
            labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Location = new Point(6, 50);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(43, 15);
            labelMarca.TabIndex = 1;
            labelMarca.Text = "Marca:";
            // 
            // labelPatente
            // 
            labelPatente.AutoSize = true;
            labelPatente.Location = new Point(6, 19);
            labelPatente.Name = "labelPatente";
            labelPatente.Size = new Size(50, 15);
            labelPatente.TabIndex = 0;
            labelPatente.Text = "Patente:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(18, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(128, 12);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(240, 12);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(44, 376);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(199, 376);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGridViewVehiculos
            // 
            dataGridViewVehiculos.AllowUserToAddRows = false;
            dataGridViewVehiculos.AllowUserToDeleteRows = false;
            dataGridViewVehiculos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVehiculos.Columns.AddRange(new DataGridViewColumn[] { ColumnaPatente, ColumnaMarca, ColumnaModelo, ColumnaAnio, ColumnaColor, ColumnaCombustible, ColumnaKm, ColumnaEstado });
            dataGridViewVehiculos.Location = new Point(321, 46);
            dataGridViewVehiculos.Name = "dataGridViewVehiculos";
            dataGridViewVehiculos.ReadOnly = true;
            dataGridViewVehiculos.Size = new Size(843, 150);
            dataGridViewVehiculos.TabIndex = 6;
            // 
            // ColumnaPatente
            // 
            ColumnaPatente.DataPropertyName = "Patente";
            ColumnaPatente.HeaderText = "Patente";
            ColumnaPatente.Name = "ColumnaPatente";
            ColumnaPatente.ReadOnly = true;
            // 
            // ColumnaMarca
            // 
            ColumnaMarca.DataPropertyName = "Marca";
            ColumnaMarca.HeaderText = "Marca";
            ColumnaMarca.Name = "ColumnaMarca";
            ColumnaMarca.ReadOnly = true;
            // 
            // ColumnaModelo
            // 
            ColumnaModelo.DataPropertyName = "Modelo";
            ColumnaModelo.HeaderText = "Modelo";
            ColumnaModelo.Name = "ColumnaModelo";
            ColumnaModelo.ReadOnly = true;
            // 
            // ColumnaAnio
            // 
            ColumnaAnio.DataPropertyName = "Anio";
            ColumnaAnio.HeaderText = "Año";
            ColumnaAnio.Name = "ColumnaAnio";
            ColumnaAnio.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.DataPropertyName = "Color";
            ColumnaColor.HeaderText = "Color";
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // ColumnaCombustible
            // 
            ColumnaCombustible.DataPropertyName = "TipoCombustible";
            ColumnaCombustible.HeaderText = "Combustible";
            ColumnaCombustible.Name = "ColumnaCombustible";
            ColumnaCombustible.ReadOnly = true;
            // 
            // ColumnaKm
            // 
            ColumnaKm.DataPropertyName = "Kilometraje";
            ColumnaKm.HeaderText = "Km";
            ColumnaKm.Name = "ColumnaKm";
            ColumnaKm.ReadOnly = true;
            // 
            // ColumnaEstado
            // 
            ColumnaEstado.DataPropertyName = "Estado";
            ColumnaEstado.HeaderText = "Estado";
            ColumnaEstado.Name = "ColumnaEstado";
            ColumnaEstado.ReadOnly = true;
            // 
            // btnActTable
            // 
            btnActTable.Location = new Point(103, 415);
            btnActTable.Name = "btnActTable";
            btnActTable.Size = new Size(104, 23);
            btnActTable.TabIndex = 7;
            btnActTable.Text = "Actualizar Tabla";
            btnActTable.UseVisualStyleBackColor = true;
            btnActTable.Click += btnActTable_Click;
            // 
            // FrmVehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1203, 450);
            Controls.Add(btnActTable);
            Controls.Add(dataGridViewVehiculos);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(grBoxVehi);
            Name = "FrmVehiculos";
            Text = "Vehículos";
            Load += FrmVehiculos_Load;
            grBoxVehi.ResumeLayout(false);
            grBoxVehi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBoxKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBoxAnio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVehiculos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grBoxVehi;
        private Label labelModelo;
        private Label labelMarca;
        private Label labelPatente;
        private Label labelAnio;
        private Label labelCombustible;
        private Label labelColor;
        private Label labelKm;
        private Label labelEstado;
        private ComboBox cmbBoxMarca;
        private TextBox txtBoxPatente;
        private NumericUpDown numBoxAnio;
        private ComboBox cmbBoxModelo;
        private Label label9;
        private ComboBox cmbBoxEstado;
        private ComboBox cmbBoxCombustible;
        private ComboBox cmbBoxColor;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private DataGridView dataGridViewVehiculos;
        private NumericUpDown numBoxKm;
        private DataGridViewTextBoxColumn ColumnaPatente;
        private DataGridViewTextBoxColumn ColumnaMarca;
        private DataGridViewTextBoxColumn ColumnaModelo;
        private DataGridViewTextBoxColumn ColumnaAnio;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn ColumnaCombustible;
        private DataGridViewTextBoxColumn ColumnaKm;
        private DataGridViewTextBoxColumn ColumnaEstado;
        private Button btnActTable;
    }
}