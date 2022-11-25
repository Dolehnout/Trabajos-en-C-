using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace functionApp
{
    public partial class UsuarioyClave : Form
    {
        public UsuarioyClave()
        {
            InitializeComponent();
        }
        int intentos = 5;
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;

            if (intentos <= 0) this.Close();
            if (!(functions.Varias.validaUsuario(usuario, clave)))
            {
                MessageBox.Show("Usuario o clave incorrectos.");
                intentos--;
                lblIntentos.Text = $"Te quedan {intentos} intentos.";
            }
            else
            {
                MessageBox.Show("Ingreso exitoso.");
                frmMenu Menu = new frmMenu();
                Menu.Show();
            }
            



        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
