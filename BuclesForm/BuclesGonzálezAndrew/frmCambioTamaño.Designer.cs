namespace BuclesGonzálezAndrew
{
    partial class frmCambioTamaño
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnTamaño = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el texto de prueba";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(59, 122);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(269, 20);
            this.txtTexto.TabIndex = 1;
            // 
            // btnTamaño
            // 
            this.btnTamaño.Location = new System.Drawing.Point(636, 97);
            this.btnTamaño.Name = "btnTamaño";
            this.btnTamaño.Size = new System.Drawing.Size(101, 45);
            this.btnTamaño.TabIndex = 2;
            this.btnTamaño.Text = "Cambiar Tamaño";
            this.btnTamaño.UseVisualStyleBackColor = true;
            this.btnTamaño.Click += new System.EventHandler(this.btnTamaño_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese el tamaño del texto";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Location = new System.Drawing.Point(144, 220);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(102, 20);
            this.txtTamaño.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(636, 165);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(101, 45);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(385, 318);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Arial",
            "Times New Roman",
            "Calibri ",
            "Impact",
            ""});
            this.cmbTipo.Location = new System.Drawing.Point(441, 121);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 8;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(462, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fuente";
            // 
            // frmCambioTamaño
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTamaño);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "frmCambioTamaño";
            this.Text = "frmCambioTamaño";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnTamaño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
    }
}