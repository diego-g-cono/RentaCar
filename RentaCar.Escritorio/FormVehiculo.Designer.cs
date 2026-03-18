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
            dataGridView.Location = new Point(351, 60);
            dataGridView.Name = "dataGridView";
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
            dataGridView.Size = new Size(944, 361);
            dataGridView.TabIndex = 6;
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
            buttonEditar.Location = new Point(132, 12);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(77, 33);
            buttonEditar.TabIndex = 1;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = false;
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
            buttonEliminar.Location = new Point(250, 12);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(77, 33);
            buttonEliminar.TabIndex = 2;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
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
            groupBox.Location = new Point(12, 60);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 361);
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
            comboBoxTipo.Location = new Point(120, 130);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 22);
            comboBoxTipo.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9F);
            label7.Location = new Point(19, 133);
            label7.Name = "label7";
            label7.Size = new Size(38, 14);
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
            comboBoxEstado.Location = new Point(120, 318);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(121, 22);
            comboBoxEstado.TabIndex = 15;
            // 
            // numericUpDownKm
            // 
            numericUpDownKm.BackColor = Color.MidnightBlue;
            numericUpDownKm.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownKm.Font = new Font("Verdana", 9F);
            numericUpDownKm.ForeColor = SystemColors.ButtonFace;
            numericUpDownKm.Location = new Point(121, 281);
            numericUpDownKm.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownKm.Name = "numericUpDownKm";
            numericUpDownKm.Size = new Size(120, 22);
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
            comboBoxCombustible.Location = new Point(120, 240);
            comboBoxCombustible.Name = "comboBoxCombustible";
            comboBoxCombustible.Size = new Size(121, 22);
            comboBoxCombustible.TabIndex = 13;
            // 
            // numericUpDownAnio
            // 
            numericUpDownAnio.BackColor = Color.MidnightBlue;
            numericUpDownAnio.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownAnio.Font = new Font("Verdana", 9F);
            numericUpDownAnio.ForeColor = SystemColors.ButtonFace;
            numericUpDownAnio.Location = new Point(121, 166);
            numericUpDownAnio.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDownAnio.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
            numericUpDownAnio.Name = "numericUpDownAnio";
            numericUpDownAnio.Size = new Size(120, 22);
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
            comboBoxColor.Location = new Point(120, 202);
            comboBoxColor.Name = "comboBoxColor";
            comboBoxColor.Size = new Size(121, 22);
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
            comboBoxModelo.Location = new Point(120, 95);
            comboBoxModelo.Name = "comboBoxModelo";
            comboBoxModelo.Size = new Size(121, 22);
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
            comboBoxMarca.Location = new Point(120, 60);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(121, 22);
            comboBoxMarca.TabIndex = 9;
            comboBoxMarca.SelectedIndexChanged += comboBoxMarca_SelectedIndexChanged;
            // 
            // textBoxPatente
            // 
            textBoxPatente.BackColor = Color.MidnightBlue;
            textBoxPatente.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatente.Font = new Font("Verdana", 9F);
            textBoxPatente.ForeColor = SystemColors.ButtonFace;
            textBoxPatente.Location = new Point(120, 27);
            textBoxPatente.Name = "textBoxPatente";
            textBoxPatente.Size = new Size(121, 22);
            textBoxPatente.TabIndex = 8;
            textBoxPatente.TextChanged += textBoxPatente_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9F);
            label6.Location = new Point(19, 321);
            label6.Name = "label6";
            label6.Size = new Size(56, 14);
            label6.TabIndex = 7;
            label6.Text = "Estado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9F);
            label5.Location = new Point(19, 283);
            label5.Name = "label5";
            label5.Size = new Size(83, 14);
            label5.TabIndex = 6;
            label5.Text = "Kilometraje:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 9F);
            label4.Location = new Point(18, 243);
            label4.Name = "label4";
            label4.Size = new Size(90, 14);
            label4.TabIndex = 5;
            label4.Text = "Combustible:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9F);
            label3.Location = new Point(18, 205);
            label3.Name = "label3";
            label3.Size = new Size(45, 14);
            label3.TabIndex = 4;
            label3.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9F);
            label2.Location = new Point(19, 168);
            label2.Name = "label2";
            label2.Size = new Size(36, 14);
            label2.TabIndex = 3;
            label2.Text = "Año:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9F);
            label1.Location = new Point(18, 95);
            label1.Name = "label1";
            label1.Size = new Size(57, 14);
            label1.TabIndex = 2;
            label1.Text = "Modelo:";
            // 
            // labelMarca
            // 
            labelMarca.AutoSize = true;
            labelMarca.Font = new Font("Verdana", 9F);
            labelMarca.Location = new Point(19, 63);
            labelMarca.Name = "labelMarca";
            labelMarca.Size = new Size(49, 14);
            labelMarca.TabIndex = 1;
            labelMarca.Text = "Marca:";
            // 
            // labelPatente
            // 
            labelPatente.AutoSize = true;
            labelPatente.Font = new Font("Verdana", 9F);
            labelPatente.Location = new Point(19, 30);
            labelPatente.Name = "labelPatente";
            labelPatente.Size = new Size(62, 14);
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
            buttonGuardar.Location = new Point(12, 438);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(77, 33);
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
            buttonCancelar.Location = new Point(250, 438);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(77, 33);
            buttonCancelar.TabIndex = 5;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = false;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1375, 529);
            Controls.Add(dataGridView);
            Controls.Add(buttonCancelar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBox);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonEditar);
            Controls.Add(buttonNuevo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormVehiculo";
            Text = "Vehículos";
            Load += FormVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownKm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAnio).EndInit();
            ResumeLayout(false);
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
    }
}