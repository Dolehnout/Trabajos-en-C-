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
    public partial class frmCuadrado : Form
    {
        public frmCuadrado()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calcula el cuadrado de un número entero.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        int cuadrado(int n)
        {
            return (n * n);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (this.txtNum.Text.Length == 0)
            {
                MessageBox.Show("Debes ingresar un número.");
                this.txtNum.Focus();
                return;
            }
            bool isN = Int32.TryParse(txtNum.Text, out int num);
            if (!isN)
            {
                MessageBox.Show("No se permiten letras");
                this.txtNum.Focus();
                return;
            }
            num = Convert.ToInt32(this.txtNum.Text);
            this.txtResultado.Text = cuadrado(num).ToString();

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }   
}
