namespace eje5
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
            this.txtBingreseNum = new System.Windows.Forms.TextBox();
            this.txtBIntentos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBingreseNum
            // 
            this.txtBingreseNum.Location = new System.Drawing.Point(24, 38);
            this.txtBingreseNum.Name = "txtBingreseNum";
            this.txtBingreseNum.Size = new System.Drawing.Size(291, 20);
            this.txtBingreseNum.TabIndex = 0;
            this.txtBingreseNum.TextChanged += new System.EventHandler(this.txtBingreseNum_TextChanged);
            // 
            // txtBIntentos
            // 
            this.txtBIntentos.Location = new System.Drawing.Point(24, 105);
            this.txtBIntentos.Name = "txtBIntentos";
            this.txtBIntentos.Size = new System.Drawing.Size(291, 20);
            this.txtBIntentos.TabIndex = 1;
            this.txtBIntentos.TextChanged += new System.EventHandler(this.txtBIntentos_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Intentos";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(24, 157);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(291, 64);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 64);
            this.button2.TabIndex = 5;
            this.button2.Text = "Comenzar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 322);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBIntentos);
            this.Controls.Add(this.txtBingreseNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBingreseNum;
        private System.Windows.Forms.TextBox txtBIntentos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button button2;
    }
}

