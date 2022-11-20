using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioBucles
{
    public partial class frmBucleWhile : Form
    {
        public frmBucleWhile()
        {
            InitializeComponent();
        }

        private void frmBucleWhile_Click(object sender, EventArgs e)
        {

        }

        private void frmBucleWhile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(this.txtNumero.Text);

            int fact = 1;
            int i = 1;
            while (i <= n)
            {
                fact *= i;
                i++;
            }
            this.txtResultado.Text = fact.ToString();
        }
    }
}
