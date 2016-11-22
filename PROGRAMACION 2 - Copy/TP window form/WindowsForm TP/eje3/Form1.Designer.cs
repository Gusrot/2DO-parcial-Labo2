namespace eje3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtbIngresoTemperatura = new System.Windows.Forms.TextBox();
            this.btnCaF = new System.Windows.Forms.Button();
            this.btnFaC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese Temperatura";
            // 
            // txtbIngresoTemperatura
            // 
            this.txtbIngresoTemperatura.Location = new System.Drawing.Point(29, 66);
            this.txtbIngresoTemperatura.Name = "txtbIngresoTemperatura";
            this.txtbIngresoTemperatura.Size = new System.Drawing.Size(235, 20);
            this.txtbIngresoTemperatura.TabIndex = 1;
            this.txtbIngresoTemperatura.TextChanged += new System.EventHandler(this.txtbIngresoTemperatura_TextChanged);
            // 
            // btnCaF
            // 
            this.btnCaF.Location = new System.Drawing.Point(29, 101);
            this.btnCaF.Name = "btnCaF";
            this.btnCaF.Size = new System.Drawing.Size(235, 48);
            this.btnCaF.TabIndex = 2;
            this.btnCaF.Text = "De  Centígrados a Fahrenheit";
            this.btnCaF.UseVisualStyleBackColor = true;
            this.btnCaF.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFaC
            // 
            this.btnFaC.Location = new System.Drawing.Point(29, 169);
            this.btnFaC.Name = "btnFaC";
            this.btnFaC.Size = new System.Drawing.Size(235, 44);
            this.btnFaC.TabIndex = 3;
            this.btnFaC.Text = "De Fahrenheit a Centígrados";
            this.btnFaC.UseVisualStyleBackColor = true;
            this.btnFaC.Click += new System.EventHandler(this.btnFaC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 251);
            this.Controls.Add(this.btnFaC);
            this.Controls.Add(this.btnCaF);
            this.Controls.Add(this.txtbIngresoTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbIngresoTemperatura;
        private System.Windows.Forms.Button btnCaF;
        private System.Windows.Forms.Button btnFaC;
    }
}

