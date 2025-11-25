using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escritorio
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            using (var db = new RentaCarDBContext())
            {
                var cliente = new Cliente(
                    dni: int.Parse(txtBoxDNI.Text.Trim()),
                    nombre: txtBoxNombre.Text.Trim(),
                    apellido: txtBoxApellido.Text.Trim(),
                    usuario: txtBoxUsuario.Text.Trim(),
                    contraseña: txtBoxContrasenia.Text
                );

                db.Clientes.Add(cliente);
                db.SaveChanges();
            }

            MessageBox.Show("Cliente guardado correctamente");
        }
    }
}
