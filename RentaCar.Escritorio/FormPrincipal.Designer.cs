namespace RentaCar.Escritorio
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            menuStrip1 = new MenuStrip();
            gestionarToolStripMenuItem = new ToolStripMenuItem();
            vehiculosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            reservasToolStripMenuItem = new ToolStripMenuItem();
            devolucionesToolStripMenuItem = new ToolStripMenuItem();
            alquilerToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            usuariosToolStripMenuItem = new ToolStripMenuItem();
            conductoresToolStripMenuItem = new ToolStripMenuItem();
            tarifasToolStripMenuItem = new ToolStripMenuItem();
            sesiónToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesiónToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gestionarToolStripMenuItem, sesiónToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(921, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip";
            // 
            // gestionarToolStripMenuItem
            // 
            gestionarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vehiculosToolStripMenuItem, clientesToolStripMenuItem, reservasToolStripMenuItem, devolucionesToolStripMenuItem, alquilerToolStripMenuItem, agregarToolStripMenuItem });
            gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            gestionarToolStripMenuItem.Size = new Size(69, 20);
            gestionarToolStripMenuItem.Text = "Gestionar";
            // 
            // vehiculosToolStripMenuItem
            // 
            vehiculosToolStripMenuItem.Name = "vehiculosToolStripMenuItem";
            vehiculosToolStripMenuItem.Size = new Size(172, 22);
            vehiculosToolStripMenuItem.Text = "Vehiculos";
            vehiculosToolStripMenuItem.Click += vehiculosToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(172, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // reservasToolStripMenuItem
            // 
            reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            reservasToolStripMenuItem.Size = new Size(172, 22);
            reservasToolStripMenuItem.Text = "Reservas";
            reservasToolStripMenuItem.Click += reservasToolStripMenuItem_Click;
            // 
            // devolucionesToolStripMenuItem
            // 
            devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            devolucionesToolStripMenuItem.Size = new Size(172, 22);
            devolucionesToolStripMenuItem.Text = "Devoluciones";
            devolucionesToolStripMenuItem.Click += devolucionesToolStripMenuItem_Click;
            // 
            // alquilerToolStripMenuItem
            // 
            alquilerToolStripMenuItem.Name = "alquilerToolStripMenuItem";
            alquilerToolStripMenuItem.Size = new Size(172, 22);
            alquilerToolStripMenuItem.Text = "Alquileres";
            alquilerToolStripMenuItem.Click += alquileresToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuariosToolStripMenuItem, conductoresToolStripMenuItem, tarifasToolStripMenuItem });
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(172, 22);
            agregarToolStripMenuItem.Text = "Agregar/Modificar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // usuariosToolStripMenuItem
            // 
            usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            usuariosToolStripMenuItem.Size = new Size(142, 22);
            usuariosToolStripMenuItem.Text = "Usuarios";
            usuariosToolStripMenuItem.Click += usuariosToolStripMenuItem_Click;
            // 
            // conductoresToolStripMenuItem
            // 
            conductoresToolStripMenuItem.Name = "conductoresToolStripMenuItem";
            conductoresToolStripMenuItem.Size = new Size(142, 22);
            conductoresToolStripMenuItem.Text = "Conductores";
            conductoresToolStripMenuItem.Click += conductoresToolStripMenuItem_Click;
            // 
            // tarifasToolStripMenuItem
            // 
            tarifasToolStripMenuItem.Name = "tarifasToolStripMenuItem";
            tarifasToolStripMenuItem.Size = new Size(142, 22);
            tarifasToolStripMenuItem.Text = "Tarifas";
            tarifasToolStripMenuItem.Click += tarifasToolStripMenuItem_Click;
            // 
            // sesiónToolStripMenuItem
            // 
            sesiónToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cerrarSesiónToolStripMenuItem });
            sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            sesiónToolStripMenuItem.Size = new Size(53, 20);
            sesiónToolStripMenuItem.Text = "Sesion";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            cerrarSesiónToolStripMenuItem.Size = new Size(180, 22);
            cerrarSesiónToolStripMenuItem.Text = "Cerrar sesion";
            cerrarSesiónToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(921, 492);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            RightToLeft = RightToLeft.No;
            Text = "RentaCar";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem gestionarToolStripMenuItem;
        private ToolStripMenuItem vehiculosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem reservasToolStripMenuItem;
        private ToolStripMenuItem devolucionesToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem usuariosToolStripMenuItem;
        private ToolStripMenuItem conductoresToolStripMenuItem;
        private ToolStripMenuItem alquilerToolStripMenuItem;
        private ToolStripMenuItem tarifasToolStripMenuItem;
        private ToolStripMenuItem sesiónToolStripMenuItem;
        private ToolStripMenuItem cerrarSesiónToolStripMenuItem;
    }
}
