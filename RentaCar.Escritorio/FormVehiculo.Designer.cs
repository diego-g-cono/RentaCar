namespace RentaCar.Escritorio
{
    partial class FormVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVehiculo));
            dataGridView = new DataGridView();
            ColumnPatente = new DataGridViewTextBoxColumn();
            ColumnMarca = new DataGridViewTextBoxColumn();
            ColumnModelo = new DataGridViewTextBoxColumn();
            ColumnTipo = new DataGridViewTextBoxColumn();
            ColumnAnio = new DataGridViewTextBoxColumn();
            ColumnColor = new DataGridViewTextBoxColumn();
            ColumnCombustible = new DataGridViewTextBoxColumn();
            ColumnKm = new DataGridViewTextBoxColumn();
            ColumnEstado = new DataGridViewTextBoxColumn();
            buttonNuevo = new Button();
            buttonEditar = new Button();
            buttonEliminar = new Button();
            groupBox = new GroupBox();
            comboBoxTipo = new ComboBox();
            label7 = new Label();
            comboBoxEstado = new ComboBox();
            numericUpDownKm = new NumericUpDown();
            comboBoxCombustible = new ComboBox();
            numericUpDownAnio = new NumericUpDown();
            comboBoxColor = new ComboBox();
            comboBoxModelo = new ComboBox();
            comboBoxMarca = new ComboBox();
            textBoxPatente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            labelMarca = new Label();
            labelPatente = new Label();
            buttonGuardar = new Button();
            buttonCancelar = new Button();
            textBoxBuscador = new TextBox();
            labelBuscarPorDni = new Label();
            buttonRecargar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).BeginInit();
            SuspendLayout();
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
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ColumnPatente, ColumnMarca, ColumnModelo, ColumnTipo, ColumnAnio, ColumnColor, ColumnCombustible, ColumnKm, ColumnEstado });
            dataGridView.GridColor = Color.MidnightBlue;
            dataGridView.Location = new Point(401, 80);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
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
            dataGridView.Size = new Size(1186, 481);
            dataGridView.TabIndex = 6;
            // 
            // ColumnPatente
            // 
            ColumnPatente.DataPropertyName = "Patente";
            ColumnPatente.HeaderText = "Patente";
            ColumnPatente.MinimumWidth = 6;
            ColumnPatente.Name = "ColumnPatente";
            ColumnPatente.ReadOnly = true;
            ColumnPatente.Width = 125;
            // 
            // ColumnMarca
            // 
            ColumnMarca.DataPropertyName = "MarcaNombre";
            ColumnMarca.HeaderText = "Marca";
            ColumnMarca.MinimumWidth = 6;
            ColumnMarca.Name = "ColumnMarca";
            ColumnMarca.ReadOnly = true;
            ColumnMarca.Width = 125;
            // 
            // ColumnModelo
            // 
            ColumnModelo.DataPropertyName = "ModeloNombre";
            ColumnModelo.HeaderText = "Modelo";
            ColumnModelo.MinimumWidth = 6;
            ColumnModelo.Name = "ColumnModelo";
            ColumnModelo.ReadOnly = true;
            ColumnModelo.Width = 125;
            // 
            // ColumnTipo
            // 
            ColumnTipo.DataPropertyName = "TipoNombre";
            ColumnTipo.HeaderText = "Tipo";
            ColumnTipo.MinimumWidth = 6;
            ColumnTipo.Name = "ColumnTipo";
            ColumnTipo.ReadOnly = true;
            ColumnTipo.Width = 125;
            // 
            // ColumnAnio
            // 
            ColumnAnio.DataPropertyName = "Anio";
            ColumnAnio.HeaderText = "Año";
            ColumnAnio.MinimumWidth = 6;
            ColumnAnio.Name = "ColumnAnio";
            ColumnAnio.ReadOnly = true;
            ColumnAnio.Width = 125;
            // 
            // ColumnColor
            // 
            ColumnColor.DataPropertyName = "ColorNombre";
            ColumnColor.HeaderText = "Color";
            ColumnColor.MinimumWidth = 6;
            ColumnColor.Name = "ColumnColor";
            ColumnColor.ReadOnly = true;
            ColumnColor.Width = 125;
            // 
            // ColumnCombustible
            // 
            ColumnCombustible.DataPropertyName = "CombustibleNombre";
            ColumnCombustible.HeaderText = "Combustible";
            ColumnCombustible.MinimumWidth = 6;
            ColumnCombustible.Name = "ColumnCombustible";
            ColumnCombustible.ReadOnly = true;
            ColumnCombustible.Width = 125;
            // 
            // ColumnKm
            // 
            ColumnKm.DataPropertyName = "Kilometraje";
            ColumnKm.HeaderText = "Kilometraje";
            ColumnKm.MinimumWidth = 6;
            ColumnKm.Name = "ColumnKm";
            ColumnKm.ReadOnly = true;
            ColumnKm.Width = 125;
            // 
            // ColumnEstado
            // 
            ColumnEstado.DataPropertyName = "EstadoNombre";
            ColumnEstado.HeaderText = "Estado";
            ColumnEstado.MinimumWidth = 6;
            ColumnEstado.Name = "ColumnEstado";
            ColumnEstado.ReadOnly = true;
            ColumnEstado.Width = 125;
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
            buttonNuevo.Location = new Point(14, 16);
            buttonNuevo.Margin = new Padding(3, 4, 3, 4);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(88, 44);
            buttonNuevo.TabIndex = 0;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            buttonNuevo.Click += btnNuevo_Click;
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
            buttonEditar.Location = new Point(151, 16);
            buttonEditar.Margin = new Padding(3, 4, 3, 4);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(88, 44);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
            buttonEditar.Click += btnEditar_Click;
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
            buttonEliminar.Location = new Point(286, 16);
            buttonEliminar.Margin = new Padding(3, 4, 3, 4);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(88, 44);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            buttonEliminar.Click += btnEliminar_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(comboBoxTipo);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(comboBoxEstado);
            groupBox.Controls.Add(numericUpDownKm);
            groupBox.Controls.Add(comboBoxCombustible);
            groupBox.Controls.Add(numericUpDownAnio);
            groupBox.Controls.Add(comboBoxColor);
            groupBox.Controls.Add(comboBoxModelo);
            groupBox.Controls.Add(comboBoxMarca);
            groupBox.Controls.Add(textBoxPatente);
            groupBox.Controls.Add(label6);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(labelMarca);
            groupBox.Controls.Add(labelPatente);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(14, 80);
            groupBox.Margin = new Padding(3, 4, 3, 4);
            groupBox.Name = "groupBox";
            groupBox.Padding = new Padding(3, 4, 3, 4);
            groupBox.Size = new Size(360, 481);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "Datos Vehículo";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.BackColor = Color.MidnightBlue;
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FlatStyle = FlatStyle.Flat;
            comboBoxTipo.Font = new Font("Verdana", 9F);
            comboBoxTipo.ForeColor = SystemColors.ButtonFace;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(137, 173);
            comboBoxTipo.Margin = new Padding(3, 4, 3, 4);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(138, 26);
            comboBoxTipo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F);
            label7.Location = new Point(22, 177);
            label7.Name = "label7";
            label7.Size = new Size(46, 18);
            label7.TabIndex = 16;
            label7.Text = "Tipo:";
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.BackColor = Color.MidnightBlue;
            comboBoxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstado.FlatStyle = FlatStyle.Flat;
            comboBoxEstado.Font = new Font("Verdana", 9F);
            comboBoxEstado.ForeColor = SystemColors.ButtonFace;
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Location = new Point(137, 424);
            comboBoxEstado.Margin = new Padding(3, 4, 3, 4);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(138, 26);
            comboBoxEstado.TabIndex = 15;
            // 
            // numericUpDownKm
            // 
            numericUpDownKm.BackColor = Color.MidnightBlue;
            numericUpDownKm.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownKm.Font = new Font("Verdana", 9F);
            numericUpDownKm.ForeColor = SystemColors.ButtonFace;
            numericUpDownKm.Location = new Point(138, 375);
            numericUpDownKm.Margin = new Padding(3, 4, 3, 4);
            numericUpDownKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownKm.Name = "numericUpDownKm";
            numericUpDownKm.Size = new Size(137, 26);
            numericUpDownKm.TabIndex = 14;
            // 
            // comboBoxCombustible
            // 
            comboBoxCombustible.BackColor = Color.MidnightBlue;
            comboBoxCombustible.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCombustible.FlatStyle = FlatStyle.Flat;
            comboBoxCombustible.Font = new Font("Verdana", 9F);
            comboBoxCombustible.ForeColor = SystemColors.ButtonFace;
            comboBoxCombustible.FormattingEnabled = true;
            comboBoxCombustible.Location = new Point(137, 320);
            comboBoxCombustible.Margin = new Padding(3, 4, 3, 4);
            comboBoxCombustible.Name = "comboBoxCombustible";
            comboBoxCombustible.Size = new Size(138, 26);
            comboBoxCombustible.TabIndex = 13;
            // 
            // numericUpDownAnio
            // 
            numericUpDownAnio.BackColor = Color.MidnightBlue;
            numericUpDownAnio.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownAnio.Font = new Font("Verdana", 9F);
            numericUpDownAnio.ForeColor = SystemColors.ButtonFace;
            numericUpDownAnio.Location = new Point(138, 221);
            numericUpDownAnio.Margin = new Padding(3, 4, 3, 4);
            numericUpDownAnio.Maximum = new decimal(new int[] { 2026, 0, 0, 0 });
            numericUpDownAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDownAnio.Name = "numericUpDownAnio";
            numericUpDownAnio.Size = new Size(137, 26);
            numericUpDownAnio.TabIndex = 12;
            numericUpDownAnio.Value = new decimal(new int[] { 1950, 0, 0, 0 });
            // 
            // comboBoxColor
            // 
            comboBoxColor.BackColor = Color.MidnightBlue;
            comboBoxColor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxColor.FlatStyle = FlatStyle.Flat;
            comboBoxColor.Font = new Font("Verdana", 9F);
            comboBoxColor.ForeColor = SystemColors.ButtonFace;
            comboBoxColor.FormattingEnabled = true;
            comboBoxColor.Location = new Point(137, 269);
            comboBoxColor.Margin = new Padding(3, 4, 3, 4);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(138, 26);
            comboBoxColor.TabIndex = 11;
            // 
            // comboBoxModelo
            // 
            comboBoxModelo.BackColor = Color.MidnightBlue;
            comboBoxModelo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModelo.FlatStyle = FlatStyle.Flat;
            comboBoxModelo.Font = new Font("Verdana", 9F);
            comboBoxModelo.ForeColor = SystemColors.ButtonFace;
            comboBoxModelo.FormattingEnabled = true;
            comboBoxModelo.Location = new Point(137, 127);
            comboBoxModelo.Margin = new Padding(3, 4, 3, 4);
            comboBoxModelo.Name = "comboBoxModelo";
            comboBoxModelo.Size = new Size(138, 26);
            comboBoxModelo.TabIndex = 10;
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.BackColor = Color.MidnightBlue;
            comboBoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMarca.FlatStyle = FlatStyle.Flat;
            comboBoxMarca.Font = new Font("Verdana", 9F);
            comboBoxMarca.ForeColor = SystemColors.ButtonFace;
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(137, 80);
            comboBoxMarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(138, 26);
            comboBoxMarca.TabIndex = 9;
            comboBoxMarca.SelectedIndexChanged += comboBoxMarca_SelectedIndexChanged;
            // 
            // textBoxPatente
            // 
            textBoxPatente.BackColor = Color.MidnightBlue;
            textBoxPatente.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatente.Font = new Font("Verdana", 9F);
            textBoxPatente.ForeColor = SystemColors.ButtonFace;
            textBoxPatente.Location = new Point(137, 36);
            textBoxPatente.Margin = new Padding(3, 4, 3, 4);
            textBoxPatente.MaxLength = 7;
            textBoxPatente.Name = "textBoxPatente";
            textBoxPatente.Size = new Size(138, 26);
            textBoxPatente.TabIndex = 8;
            textBoxPatente.TextChanged += textBoxPatente_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F);
            label6.Location = new Point(22, 428);
            label6.Name = "label6";
            label6.Size = new Size(66, 18);
            label6.TabIndex = 7;
            label6.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(22, 377);
            label5.Name = "label5";
            label5.Size = new Size(100, 18);
            label5.TabIndex = 6;
            label5.Text = "Kilometraje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(21, 324);
            label4.Name = "label4";
            label4.Size = new Size(107, 18);
            label4.TabIndex = 5;
            label4.Text = "Combustible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(21, 273);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 4;
            label3.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(22, 224);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 3;
            label2.Text = "Año:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(21, 127);
            label1.Name = "label1";
            label1.Size = new Size(69, 18);
            label1.TabIndex = 2;
            label1.Text = "Modelo:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Verdana", 9F);
            labelMarca.Location = new Point(22, 84);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(60, 18);
            labelMarca.TabIndex = 1;
            labelMarca.Text = "Marca:";
            // 
            // labelPatente
            // 
            labelPatente.AutoSize = true;
            labelPatente.Font = new Font("Verdana", 9F);
            labelPatente.Location = new Point(22, 40);
            labelPatente.Name = "labelPatente";
            labelPatente.Size = new Size(72, 18);
            labelPatente.TabIndex = 0;
            labelPatente.Text = "Patente:";
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
            buttonGuardar.Location = new Point(14, 584);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(88, 44);
            buttonGuardar.TabIndex = 4;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            buttonGuardar.Click += btnGuardar_Click;
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
            buttonCancelar.Location = new Point(286, 584);
            buttonCancelar.Margin = new Padding(3, 4, 3, 4);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(88, 44);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            buttonCancelar.Click += btnCancelar_Click;
            // 
            // textBoxBuscador
            // 
            textBoxBuscador.BackColor = Color.MidnightBlue;
            textBoxBuscador.BorderStyle = BorderStyle.FixedSingle;
            textBoxBuscador.Font = new Font("Verdana", 9F);
            textBoxBuscador.ForeColor = SystemColors.ButtonFace;
            textBoxBuscador.Location = new Point(1328, 25);
            textBoxBuscador.Margin = new Padding(3, 4, 3, 4);
            textBoxBuscador.Name = "textBoxBuscador";
            textBoxBuscador.Size = new Size(138, 26);
            textBoxBuscador.TabIndex = 34;
            textBoxBuscador.TextChanged += textBoxBuscador_TextChanged;
            // 
            // labelBuscarPorDni
            // 
            labelBuscarPorDni.AutoSize = true;
            labelBuscarPorDni.Font = new Font("Verdana", 9F);
            labelBuscarPorDni.ForeColor = SystemColors.ButtonHighlight;
            labelBuscarPorDni.Location = new Point(1259, 28);
            labelBuscarPorDni.Name = "labelBuscarPorDni";
            labelBuscarPorDni.Size = new Size(65, 18);
            labelBuscarPorDni.TabIndex = 35;
            labelBuscarPorDni.Text = "Buscar:";
            // 
            // buttonRecargar
            // 
            buttonRecargar.FlatStyle = FlatStyle.System;
            buttonRecargar.Font = new Font("Segoe UI", 16F);
            buttonRecargar.Location = new Point(401, 20);
            buttonRecargar.Margin = new Padding(3, 4, 3, 4);
            buttonRecargar.Name = "buttonRecargar";
            buttonRecargar.Size = new Size(39, 40);
            buttonRecargar.TabIndex = 41;
            buttonRecargar.Text = "↻";
            buttonRecargar.UseVisualStyleBackColor = true;
            buttonRecargar.Click += buttonRecargar_Click;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1599, 705);
            Controls.Add(buttonRecargar);
            Controls.Add(textBoxBuscador);
            Controls.Add(labelBuscarPorDni);
            Controls.Add(dataGridView);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormVehiculo";
            Text = "Vehículos";
            Load += FormVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNuevo;
        private Button buttonEditar;
        private Button buttonEliminar;
        private GroupBox groupBox;
        private Label labelPatente;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label labelMarca;
        private Label label6;
        private Label label5;
        private ComboBox comboBoxColor;
        private ComboBox comboBoxModelo;
        private ComboBox comboBoxMarca;
        private TextBox textBoxPatente;
        private NumericUpDown numericUpDownAnio;
        private ComboBox comboBoxEstado;
        private NumericUpDown numericUpDownKm;
        private ComboBox comboBoxCombustible;
        private Button buttonGuardar;
        private Button buttonCancelar;
        private DataGridView dataGridView;
        private ComboBox comboBoxTipo;
        private Label label7;
        private DataGridViewTextBoxColumn ColumnPatente;
        private DataGridViewTextBoxColumn ColumnMarca;
        private DataGridViewTextBoxColumn ColumnModelo;
        private DataGridViewTextBoxColumn ColumnTipo;
        private DataGridViewTextBoxColumn ColumnAnio;
        private DataGridViewTextBoxColumn ColumnColor;
        private DataGridViewTextBoxColumn ColumnCombustible;
        private DataGridViewTextBoxColumn ColumnKm;
        private DataGridViewTextBoxColumn ColumnEstado;
        private TextBox textBoxBuscador;
        private Label labelBuscarPorDni;
        private Button buttonRecargar;
    }
}