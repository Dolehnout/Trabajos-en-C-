namespace BuclesGonzálezAndrew
{
    partial class frmDecimalABinarioLST
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstBinario = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFueradeRango = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(255, 205);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserte Decimal:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(387, 366);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(93, 44);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(267, 366);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(93, 44);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstBinario
            // 
            this.lstBinario.FormattingEnabled = true;
            this.lstBinario.Location = new System.Drawing.Point(497, 132);
            this.lstBinario.Name = "lstBinario";
            this.lstBinario.Size = new System.Drawing.Size(243, 186);
            this.lstBinario.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(576, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Binario:";
            // 
            // lblFueradeRango
            // 
            this.lblFueradeRango.AutoSize = true;
            this.lblFueradeRango.ForeColor = System.Drawing.Color.Red;
            this.lblFueradeRango.Location = new System.Drawing.Point(545, 116);
            this.lblFueradeRango.Name = "lblFueradeRango";
            this.lblFueradeRango.Size = new System.Drawing.Size(159, 13);
            this.lblFueradeRango.TabIndex = 18;
            this.lblFueradeRango.Text = "Decimal fuera de rango 0-65535";
            this.lblFueradeRango.Visible = false;
            // 
            // frmDecimalABinarioLST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFueradeRango);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label1);
            this.Name = "frmDecimalABinarioLST";
            this.Text = "frmDecimalABinarioLST";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstBinario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFueradeRango;
    }
}