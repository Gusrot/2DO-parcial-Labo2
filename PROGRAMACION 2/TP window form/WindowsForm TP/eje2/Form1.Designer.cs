namespace eje2
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRectanguloAlambre = new System.Windows.Forms.Button();
            this.btnMaterialesContrapiso = new System.Windows.Forms.Button();
            this.btnCirculoAlambre = new System.Windows.Forms.Button();
            this.txtBAnchoTerreno = new System.Windows.Forms.TextBox();
            this.txtBRadioTerreno = new System.Windows.Forms.TextBox();
            this.txtBLargoTerreno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Radio de terreno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ancho de terreno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Largo de terreno";
            // 
            // btnRectanguloAlambre
            // 
            this.btnRectanguloAlambre.Location = new System.Drawing.Point(37, 197);
            this.btnRectanguloAlambre.Name = "btnRectanguloAlambre";
            this.btnRectanguloAlambre.Size = new System.Drawing.Size(272, 23);
            this.btnRectanguloAlambre.TabIndex = 14;
            this.btnRectanguloAlambre.Text = "Rectangulo de alambre";
            this.btnRectanguloAlambre.UseVisualStyleBackColor = true;
            this.btnRectanguloAlambre.Click += new System.EventHandler(this.btnRectanguloAlambre_Click);
            // 
            // btnMaterialesContrapiso
            // 
            this.btnMaterialesContrapiso.Location = new System.Drawing.Point(37, 275);
            this.btnMaterialesContrapiso.Name = "btnMaterialesContrapiso";
            this.btnMaterialesContrapiso.Size = new System.Drawing.Size(272, 23);
            this.btnMaterialesContrapiso.TabIndex = 13;
            this.btnMaterialesContrapiso.Text = "Materiales contrapiso";
            this.btnMaterialesContrapiso.UseVisualStyleBackColor = true;
            this.btnMaterialesContrapiso.Click += new System.EventHandler(this.btnMaterialesContrapiso_Click);
            // 
            // btnCirculoAlambre
            // 
            this.btnCirculoAlambre.Location = new System.Drawing.Point(37, 236);
            this.btnCirculoAlambre.Name = "btnCirculoAlambre";
            this.btnCirculoAlambre.Size = new System.Drawing.Size(272, 23);
            this.btnCirculoAlambre.TabIndex = 12;
            this.btnCirculoAlambre.Text = "Circulo de alambre";
            this.btnCirculoAlambre.UseVisualStyleBackColor = true;
            this.btnCirculoAlambre.Click += new System.EventHandler(this.btnCirculoAlambre_Click);
            // 
            // txtBAnchoTerreno
            // 
            this.txtBAnchoTerreno.Location = new System.Drawing.Point(37, 99);
            this.txtBAnchoTerreno.Name = "txtBAnchoTerreno";
            this.txtBAnchoTerreno.Size = new System.Drawing.Size(272, 20);
            this.txtBAnchoTerreno.TabIndex = 11;
            this.txtBAnchoTerreno.TextChanged += new System.EventHandler(this.txtBAnchoTerreno_TextChanged);
            // 
            // txtBRadioTerreno
            // 
            this.txtBRadioTerreno.Location = new System.Drawing.Point(37, 150);
            this.txtBRadioTerreno.Name = "txtBRadioTerreno";
            this.txtBRadioTerreno.Size = new System.Drawing.Size(272, 20);
            this.txtBRadioTerreno.TabIndex = 10;
            this.txtBRadioTerreno.TextChanged += new System.EventHandler(this.txtBRadioTerreno_TextChanged);
            // 
            // txtBLargoTerreno
            // 
            this.txtBLargoTerreno.Location = new System.Drawing.Point(37, 43);
            this.txtBLargoTerreno.Name = "txtBLargoTerreno";
            this.txtBLargoTerreno.Size = new System.Drawing.Size(272, 20);
            this.txtBLargoTerreno.TabIndex = 9;
            this.txtBLargoTerreno.TextChanged += new System.EventHandler(this.txtBLargoTerreno_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 330);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRectanguloAlambre);
            this.Controls.Add(this.btnMaterialesContrapiso);
            this.Controls.Add(this.btnCirculoAlambre);
            this.Controls.Add(this.txtBAnchoTerreno);
            this.Controls.Add(this.txtBRadioTerreno);
            this.Controls.Add(this.txtBLargoTerreno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRectanguloAlambre;
        private System.Windows.Forms.Button btnMaterialesContrapiso;
        private System.Windows.Forms.Button btnCirculoAlambre;
        private System.Windows.Forms.TextBox txtBAnchoTerreno;
        private System.Windows.Forms.TextBox txtBRadioTerreno;
        private System.Windows.Forms.TextBox txtBLargoTerreno;
    }
}

