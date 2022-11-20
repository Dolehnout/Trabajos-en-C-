using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuclesGonzálezAndrew
{
    public partial class frmDecimalABinarioLST : Form
    {
        public frmDecimalABinarioLST()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dec = Convert.ToInt32(this.txtDecimal.Text);
            int[] vector = new int[16];
            int i = 0;

            lblFueradeRango.Visible = false;
            lstBinario.Items.Clear();
            if (dec >= 0 && dec <= 65535)
            {
                while (dec > 0)
                {
                    int resto = dec % 2;
                    vector[i] = resto;


                    dec /= 2;
                    i++;

                    lstBinario.Items.Add(resto.ToString());
                    for (int j = 0; j < lstBinario.Items.Count / 2; j++)
                    {
                        var tmp = lstBinario.Items[j];
                        lstBinario.Items[j] = lstBinario.Items[lstBinario.Items.Count - j - 1];
                        lstBinario.Items[lstBinario.Items.Count - j - 1] = tmp;
                    }
                }
            }
            else
            {
                lblFueradeRango.Visible = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
