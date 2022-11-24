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
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }
        int potencia(int b, int e)
        {
            int res = 1;
            int i = 0;
            do
            {
                res *= b;
                i++;
            } while (i < e);
            return res;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int b = Convert.ToInt32(this.txtBase.Text);
            int exp = Convert.ToInt32(this.txtExponente.Text);


            this.lblResultado.Text = $"El resultado es: {potencia(b, exp)}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
