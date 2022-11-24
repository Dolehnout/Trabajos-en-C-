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

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;
            if (functions.Varias.validaUsuario(usuario, clave))
            {
                MessageBox.Show("Ingreso exitoso.");
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.");
            }
        }
    }
}
