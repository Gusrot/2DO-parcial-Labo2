namespace eje8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.txtbGano = new System.Windows.Forms.TextBox();
            this.txtbEmpato = new System.Windows.Forms.TextBox();
            this.txtbPerdio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTijera
            // 
            this.btnTijera.Image = ((System.Drawing.Image)(resources.GetObject("btnTijera.Image")));
            this.btnTijera.Location = new System.Drawing.Point(308, 183);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(110, 106);
            this.btnTijera.TabIndex = 5;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPapel
            // 
            this.btnPapel.Image = ((System.Drawing.Image)(resources.GetObject("btnPapel.Image")));
            this.btnPapel.Location = new System.Drawing.Point(168, 183);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(109, 106);
            this.btnPapel.TabIndex = 4;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnPiedra
            // 
            this.btnPiedra.Image = ((System.Drawing.Image)(resources.GetObject("btnPiedra.Image")));
            this.btnPiedra.Location = new System.Drawing.Point(33, 183);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(101, 106);
            this.btnPiedra.TabIndex = 3;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // txtbGano
            // 
            this.txtbGano.Location = new System.Drawing.Point(33, 35);
            this.txtbGano.Name = "txtbGano";
            this.txtbGano.ReadOnly = true;
            this.txtbGano.Size = new System.Drawing.Size(385, 20);
            this.txtbGano.TabIndex = 6;
            this.txtbGano.TextChanged += new System.EventHandler(this.txtbGano_TextChanged);
            // 
            // txtbEmpato
            // 
            this.txtbEmpato.Location = new System.Drawing.Point(33, 83);
            this.txtbEmpato.Name = "txtbEmpato";
            this.txtbEmpato.ReadOnly = true;
            this.txtbEmpato.Size = new System.Drawing.Size(385, 20);
            this.txtbEmpato.TabIndex = 7;
            // 
            // txtbPerdio
            // 
            this.txtbPerdio.Location = new System.Drawing.Point(33, 128);
            this.txtbPerdio.Name = "txtbPerdio";
            this.txtbPerdio.ReadOnly = true;
            this.txtbPerdio.Size = new System.Drawing.Size(385, 20);
            this.txtbPerdio.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 318);
            this.Controls.Add(this.txtbPerdio);
            this.Controls.Add(this.txtbEmpato);
            this.Controls.Add(this.txtbGano);
            this.Controls.Add(this.btnTijera);
            this.Controls.Add(this.btnPapel);
            this.Controls.Add(this.btnPiedra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.TextBox txtbGano;
        private System.Windows.Forms.TextBox txtbEmpato;
        private System.Windows.Forms.TextBox txtbPerdio;
    }
}

