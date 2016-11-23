namespace eje4
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
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.txtBcantidadLamparas = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(36, 151);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(210, 82);
            this.btnCalcularPrecio.TabIndex = 0;
            this.btnCalcularPrecio.Text = "Calcular Precio";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // txtBcantidadLamparas
            // 
            this.txtBcantidadLamparas.Location = new System.Drawing.Point(36, 49);
            this.txtBcantidadLamparas.Name = "txtBcantidadLamparas";
            this.txtBcantidadLamparas.Size = new System.Drawing.Size(210, 20);
            this.txtBcantidadLamparas.TabIndex = 1;
            this.txtBcantidadLamparas.TextChanged += new System.EventHandler(this.txtBcantidadLamparas_TextChanged);
            // 
            // cboMarca
            // 
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Items.AddRange(new object[] {
            "ArgentinaLuz",
            "FelipeLamparas",
            "JeLuz",
            "HazIluminacion",
            "Osram"});
            this.cboMarca.Location = new System.Drawing.Point(36, 97);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(210, 21);
            this.cboMarca.TabIndex = 2;
            this.cboMarca.SelectedIndexChanged += new System.EventHandler(this.comboBoxMarca_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de lamparas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtBcantidadLamparas);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.TextBox txtBcantidadLamparas;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

