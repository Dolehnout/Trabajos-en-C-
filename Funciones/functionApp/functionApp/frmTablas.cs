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
    public partial class frmTablas : Form
    {
        public frmTablas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int t = Convert.ToInt32(this.txtTabla.Text);

            this.txtResultado.Text = functions.Varias.tablaMultiplicar(t);
        }
    }
}
