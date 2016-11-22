namespace FerreteFacturacion
{
    partial class Form1
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
            this.lnlIngreseNumero = new System.Windows.Forms.Label();
            this.lvlIngreseNumero2 = new System.Windows.Forms.Label();
            this.btnSumar = new System.Windows.Forms.Button();
            this.txtIngreseNum1 = new System.Windows.Forms.TextBox();
            this.txtIngreseNum2 = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnlIngreseNumero
            // 
            this.lnlIngreseNumero.AutoSize = true;
            this.lnlIngreseNumero.Location = new System.Drawing.Point(97, 19);
            this.lnlIngreseNumero.Name = "lnlIngreseNumero";
            this.lnlIngreseNumero.Size = new System.Drawing.Size(80, 13);
            this.lnlIngreseNumero.TabIndex = 0;
            this.lnlIngreseNumero.Text = "Ingrese numero";
            // 
            // lvlIngreseNumero2
            // 
            this.lvlIngreseNumero2.AutoSize = true;
            this.lvlIngreseNumero2.Location = new System.Drawing.Point(94, 68);
            this.lvlIngreseNumero2.Name = "lvlIngreseNumero2";
            this.lvlIngreseNumero2.Size = new System.Drawing.Size(83, 13);
            this.lvlIngreseNumero2.TabIndex = 1;
            this.lvlIngreseNumero2.Text = "Ingrese numero ";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(68, 140);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(141, 39);
            this.btnSumar.TabIndex = 2;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // txtIngreseNum1
            // 
            this.txtIngreseNum1.Location = new System.Drawing.Point(87, 35);
            this.txtIngreseNum1.Name = "txtIngreseNum1";
            this.txtIngreseNum1.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseNum1.TabIndex = 4;
            this.txtIngreseNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIngreseNum2
            // 
            this.txtIngreseNum2.Location = new System.Drawing.Point(87, 84);
            this.txtIngreseNum2.Name = "txtIngreseNum2";
            this.txtIngreseNum2.Size = new System.Drawing.Size(100, 20);
            this.txtIngreseNum2.TabIndex = 5;
            this.txtIngreseNum2.TextChanged += new System.EventHandler(this.txtIngreseNum2_TextChanged);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(68, 186);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(141, 41);
            this.btnPromedio.TabIndex = 6;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.Location = new System.Drawing.Point(68, 243);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(141, 35);
            this.btnPrecioFinal.TabIndex = 7;
            this.btnPrecioFinal.Text = "Precio Final";
            this.btnPrecioFinal.UseVisualStyleBackColor = true;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.btnPrecioFinal);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtIngreseNum2);
            this.Controls.Add(this.txtIngreseNum1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.lvlIngreseNumero2);
            this.Controls.Add(this.lnlIngreseNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlIngreseNumero;
        private System.Windows.Forms.Label lvlIngreseNumero2;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.TextBox txtIngreseNum1;
        private System.Windows.Forms.TextBox txtIngreseNum2;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioFinal;
    }
}

