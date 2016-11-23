namespace eje1
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
            this.textBoxIngrese1 = new System.Windows.Forms.TextBox();
            this.textBoxIngrese3 = new System.Windows.Forms.TextBox();
            this.textBoxIngrese2 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIngrese1
            // 
            this.textBoxIngrese1.Location = new System.Drawing.Point(41, 43);
            this.textBoxIngrese1.Name = "textBoxIngrese1";
            this.textBoxIngrese1.Size = new System.Drawing.Size(272, 20);
            this.textBoxIngrese1.TabIndex = 0;
            this.textBoxIngrese1.TextChanged += new System.EventHandler(this.textBoxIngrese1_TextChanged);
            // 
            // textBoxIngrese3
            // 
            this.textBoxIngrese3.Location = new System.Drawing.Point(41, 150);
            this.textBoxIngrese3.Name = "textBoxIngrese3";
            this.textBoxIngrese3.Size = new System.Drawing.Size(272, 20);
            this.textBoxIngrese3.TabIndex = 1;
            this.textBoxIngrese3.TextChanged += new System.EventHandler(this.textBoxIngrese3_TextChanged);
            // 
            // textBoxIngrese2
            // 
            this.textBoxIngrese2.Location = new System.Drawing.Point(41, 99);
            this.textBoxIngrese2.Name = "textBoxIngrese2";
            this.textBoxIngrese2.Size = new System.Drawing.Size(272, 20);
            this.textBoxIngrese2.TabIndex = 2;
            this.textBoxIngrese2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(41, 236);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(272, 23);
            this.btnPromedio.TabIndex = 3;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(41, 275);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(272, 23);
            this.btnPrecioFinal.TabIndex = 4;
            this.btnPrecioFinal.Text = "Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(41, 197);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(272, 23);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ingrese Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ingrese Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese Precio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 321);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.textBoxIngrese2);
            this.Controls.Add(this.textBoxIngrese3);
            this.Controls.Add(this.textBoxIngrese1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIngrese1;
        private System.Windows.Forms.TextBox textBoxIngrese3;
        private System.Windows.Forms.TextBox textBoxIngrese2;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

