namespace eje6
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBIntentos = new System.Windows.Forms.TextBox();
            this.txtBingreseNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 64);
            this.button2.TabIndex = 11;
            this.button2.Text = "Comenzar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(54, 167);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(291, 64);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Intentos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ingrese Numero";
            // 
            // txtBIntentos
            // 
            this.txtBIntentos.Location = new System.Drawing.Point(54, 115);
            this.txtBIntentos.Name = "txtBIntentos";
            this.txtBIntentos.Size = new System.Drawing.Size(291, 20);
            this.txtBIntentos.TabIndex = 7;
            this.txtBIntentos.TextChanged += new System.EventHandler(this.txtBIntentos_TextChanged);
            // 
            // txtBingreseNum
            // 
            this.txtBingreseNum.Location = new System.Drawing.Point(54, 48);
            this.txtBingreseNum.Name = "txtBingreseNum";
            this.txtBingreseNum.Size = new System.Drawing.Size(291, 20);
            this.txtBingreseNum.TabIndex = 6;
            this.txtBingreseNum.TextChanged += new System.EventHandler(this.txtBingreseNum_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 363);
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

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBIntentos;
        private System.Windows.Forms.TextBox txtBingreseNum;
    }
}

