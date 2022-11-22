using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuclesGonzálezAndrew
{
    public partial class frmCambioTamaño : Form
    {
        public frmCambioTamaño()
        {
            InitializeComponent();
        }

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            string texto = this.txtTexto.Text;

            int tamaño = Convert.ToInt32(this.txtTamaño.Text);

            string fuente = cmbTipo.Text;


            lblResultado.Text = texto;
            lblResultado.Font = new Font($"{fuente}", tamaño);
            lblResultado.SendToBack();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
