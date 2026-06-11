namespace RentaCar.Escritorio
{
    partial class FormLogin : Form
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            buttonIngresar = new Button();
            labelUsuario = new Label();
            labelContra = new Label();
            textBoxUsuario = new TextBox();
            textBoxContrasena = new TextBox();
            groupBox = new GroupBox();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // buttonIngresar
            // 
            buttonIngresar.BackColor = Color.FromArgb(64, 64, 64);
            buttonIngresar.FlatAppearance.BorderColor = Color.MidnightBlue;
            buttonIngresar.FlatAppearance.MouseDownBackColor = Color.DimGray;
            buttonIngresar.FlatAppearance.MouseOverBackColor = Color.Gray;
            buttonIngresar.FlatStyle = FlatStyle.Flat;
            buttonIngresar.Font = new Font("Verdana", 9F);
            buttonIngresar.ForeColor = SystemColors.ButtonFace;
            buttonIngresar.Location = new Point(188, 239);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(77, 33);
            buttonIngresar.TabIndex = 0;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = false;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Verdana", 9F);
            labelUsuario.Location = new Point(34, 48);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(60, 14);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            // 
            // labelContra
            // 
            labelContra.AutoSize = true;
            labelContra.Font = new Font("Verdana", 9F);
            labelContra.Location = new Point(19, 101);
            labelContra.Name = "labelContra";
            labelContra.Size = new Size(86, 14);
            labelContra.TabIndex = 2;
            labelContra.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.MidnightBlue;
            textBoxUsuario.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsuario.Font = new Font("Verdana", 9F);
            textBoxUsuario.ForeColor = SystemColors.ButtonFace;
            textBoxUsuario.Location = new Point(144, 46);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(121, 22);
            textBoxUsuario.TabIndex = 3;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.BackColor = Color.MidnightBlue;
            textBoxContrasena.BorderStyle = BorderStyle.FixedSingle;
            textBoxContrasena.Font = new Font("Verdana", 9F);
            textBoxContrasena.ForeColor = SystemColors.ButtonFace;
            textBoxContrasena.Location = new Point(144, 99);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PasswordChar = '*';
            textBoxContrasena.Size = new Size(121, 22);
            textBoxContrasena.TabIndex = 4;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxContrasena);
            groupBox.Controls.Add(textBoxUsuario);
            groupBox.Controls.Add(labelContra);
            groupBox.Controls.Add(labelUsuario);
            groupBox.Font = new Font("Verdana", 9F, FontStyle.Bold);
            groupBox.ForeColor = SystemColors.ButtonFace;
            groupBox.Location = new Point(73, 49);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(315, 166);
            groupBox.TabIndex = 5;
            groupBox.TabStop = false;
            groupBox.Text = "Login";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(460, 304);
            Controls.Add(buttonIngresar);
            Controls.Add(groupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormLogin";
            Text = "Login";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonIngresar;
        private Label labelUsuario;
        private Label labelContra;
        private TextBox textBoxUsuario;
        private TextBox textBoxContrasena;
        private GroupBox groupBox;
    }
}