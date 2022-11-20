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
    public partial class frmDecimalABinario : Form
    {
        public frmDecimalABinario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int decimaln = Convert.ToInt32(this.txtDecimal.Text);

            CheckBox[] boxes = {chk16, chk15, chk14, chk13, chk12, chk11, chk10, chk9, chk8,
            chk7, chk6, chk5, chk4, chk3, chk2, chk1};
            int[] vector = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
            int i = 0;


            this.lblFueradeRango.Visible = false; // Ocultar mensaje de error
            if (decimaln > 65535 || decimaln <= 0)
            {
                this.lblFueradeRango.Visible = true;
                for (int k = 0; k < 16; k++)
                {
                    boxes[k].Checked = false; // Bucle para limpiar los checkboxes marcados
                }
            }
            else
            {
                while (decimaln > 0)
                {
                    int resto = decimaln % 2;
                    vector[i] = resto;


                    decimaln /= 2;
                    i++;
                }
                for (int j = 0; j < 16; j++)
                {
                    boxes[j].Checked = (vector[j] == 1) ? true : false; // Bucle para marcar los checkboxes según el binario que salga
                }
            }
        }
    }
}
