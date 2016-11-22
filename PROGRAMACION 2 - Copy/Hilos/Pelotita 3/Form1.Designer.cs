namespace Pelotita_3
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnDestruir = new System.Windows.Forms.Button();
            this.btnRenaudar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPausarTodo = new System.Windows.Forms.Button();
            this.btnDestruirTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(1, 246);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(90, 73);
            this.btnCrear.TabIndex = 5;
            this.btnCrear.Text = "Crear Pelotita 3";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 235);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(97, 246);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(89, 34);
            this.btnPausar.TabIndex = 6;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(192, 246);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(89, 34);
            this.btnDestruir.TabIndex = 7;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // btnRenaudar
            // 
            this.btnRenaudar.Location = new System.Drawing.Point(287, 246);
            this.btnRenaudar.Name = "btnRenaudar";
            this.btnRenaudar.Size = new System.Drawing.Size(89, 73);
            this.btnRenaudar.TabIndex = 8;
            this.btnRenaudar.Text = "Renaudar";
            this.btnRenaudar.UseVisualStyleBackColor = true;
            this.btnRenaudar.Click += new System.EventHandler(this.btnRenaudar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPausarTodo
            // 
            this.btnPausarTodo.Location = new System.Drawing.Point(97, 285);
            this.btnPausarTodo.Name = "btnPausarTodo";
            this.btnPausarTodo.Size = new System.Drawing.Size(89, 34);
            this.btnPausarTodo.TabIndex = 10;
            this.btnPausarTodo.Text = "Pausar Todo";
            this.btnPausarTodo.UseVisualStyleBackColor = true;
            this.btnPausarTodo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDestruirTodo
            // 
            this.btnDestruirTodo.Location = new System.Drawing.Point(192, 285);
            this.btnDestruirTodo.Name = "btnDestruirTodo";
            this.btnDestruirTodo.Size = new System.Drawing.Size(89, 34);
            this.btnDestruirTodo.TabIndex = 11;
            this.btnDestruirTodo.Text = "DestruirTodo";
            this.btnDestruirTodo.UseVisualStyleBackColor = true;
            this.btnDestruirTodo.Click += new System.EventHandler(this.btnDestruirTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 319);
            this.Controls.Add(this.btnDestruirTodo);
            this.Controls.Add(this.btnPausarTodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRenaudar);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnDestruir;
        private System.Windows.Forms.Button btnRenaudar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPausarTodo;
        private System.Windows.Forms.Button btnDestruirTodo;
    }
}

