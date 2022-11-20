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
    public partial class frmBinaryToDecimal : Form
    {
        public frmBinaryToDecimal()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] decimales = { 128, 64, 32, 16, 8, 4, 2, 1 };
            CheckBox[] boxes = { chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8 };
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                if (boxes[i-1].Checked)
                {
                    sum += decimales[i]; 
                }
                txtNum.Text = sum.ToString();
            }
        }
    }
}
