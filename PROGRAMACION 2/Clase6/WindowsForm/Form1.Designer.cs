namespace WindowsForm
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lvlNombre = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnAprobarMateria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaludar.Location = new System.Drawing.Point(84, 116);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(116, 69);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "&Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(15, 25);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(162, 20);
            this.textNombre.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(183, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lvlNombre
            // 
            this.lvlNombre.AutoSize = true;
            this.lvlNombre.Location = new System.Drawing.Point(12, 9);
            this.lvlNombre.Name = "lvlNombre";
            this.lvlNombre.Size = new System.Drawing.Size(44, 13);
            this.lvlNombre.TabIndex = 3;
            this.lvlNombre.Text = "Nombre";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(102, 220);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnAprobarMateria
            // 
            this.btnAprobarMateria.Location = new System.Drawing.Point(66, 71);
            this.btnAprobarMateria.Name = "btnAprobarMateria";
            this.btnAprobarMateria.Size = new System.Drawing.Size(155, 23);
            this.btnAprobarMateria.TabIndex = 5;
            this.btnAprobarMateria.Text = "Aprobar Materia";
            this.btnAprobarMateria.UseVisualStyleBackColor = true;
            this.btnAprobarMateria.Click += new System.EventHandler(this.btnAprobarMateria_Click);
            this.btnAprobarMateria.MouseHover += new System.EventHandler(this.btnAprobarMateria_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(298, 300);
            this.Controls.Add(this.btnAprobarMateria);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lvlNombre);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.btnSaludar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lvlNombre;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnAprobarMateria;
    }
}

