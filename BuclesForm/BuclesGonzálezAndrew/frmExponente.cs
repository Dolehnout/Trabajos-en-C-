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
    public partial class frmPotencia : Form
    {
        public frmPotencia()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int exp = Convert.ToInt16(this.txtExponente.Text);
            int bas = Convert.ToInt16(this.txtBase.Text);
            double result = 1;
            int i = 0;
            do
            {
                result *= bas;
                i++;
            }
            while (exp > i);

            this.txtResultado.Text = result.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
