namespace UI
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
            this.button1 = new System.Windows.Forms.Button();
            this.grbCarrera = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbAutos = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsbAutos = new System.Windows.Forms.ListBox();
            this.lsbResultado = new System.Windows.Forms.ListBox();
            this.btnCorrerTiempo = new System.Windows.Forms.Button();
            this.btnCorrerKm = new System.Windows.Forms.Button();
            this.grbCarrera.SuspendLayout();
            this.grbAutos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear carrera";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grbCarrera
            // 
            this.grbCarrera.Controls.Add(this.lblLugar);
            this.grbCarrera.Controls.Add(this.lblFecha);
            this.grbCarrera.Controls.Add(this.txtFecha);
            this.grbCarrera.Controls.Add(this.txtLugar);
            this.grbCarrera.Controls.Add(this.lblNombre);
            this.grbCarrera.Controls.Add(this.txtNombre);
            this.grbCarrera.Controls.Add(this.button1);
            this.grbCarrera.Location = new System.Drawing.Point(27, 12);
            this.grbCarrera.Name = "grbCarrera";
            this.grbCarrera.Size = new System.Drawing.Size(489, 132);
            this.grbCarrera.TabIndex = 1;
            this.grbCarrera.TabStop = false;
            this.grbCarrera.Text = "Carrera";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(342, 23);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 6;
            this.lblLugar.Text = "Lugar";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(171, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(168, 41);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(137, 20);
            this.txtFecha.TabIndex = 3;
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(339, 41);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(137, 20);
            this.txtLugar.TabIndex = 5;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(137, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // grbAutos
            // 
            this.grbAutos.Controls.Add(this.cmbFabricante);
            this.grbAutos.Controls.Add(this.lblFabricante);
            this.grbAutos.Controls.Add(this.lblNombrePiloto);
            this.grbAutos.Controls.Add(this.txtNombrePiloto);
            this.grbAutos.Controls.Add(this.btnAgregarAuto);
            this.grbAutos.Location = new System.Drawing.Point(27, 150);
            this.grbAutos.Name = "grbAutos";
            this.grbAutos.Size = new System.Drawing.Size(259, 118);
            this.grbAutos.TabIndex = 2;
            this.grbAutos.TabStop = false;
            this.grbAutos.Text = "Autos";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.AutoCompleteCustomSource.AddRange(new string[] {
            "Fiat",
            "Renault",
            "Peugeot",
            "Honda",
            "Torino"});
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(132, 39);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(106, 21);
            this.cmbFabricante.TabIndex = 5;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(135, 23);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 4;
            this.lblFabricante.Text = "Fabricante";
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(11, 23);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(89, 13);
            this.lblNombrePiloto.TabIndex = 3;
            this.lblNombrePiloto.Text = "Nombre del piloto";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(14, 39);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePiloto.TabIndex = 1;
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(14, 74);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(100, 23);
            this.btnAgregarAuto.TabIndex = 0;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsbAutos);
            this.groupBox3.Location = new System.Drawing.Point(330, 150);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 127);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de autos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCorrerKm);
            this.groupBox4.Controls.Add(this.btnCorrerTiempo);
            this.groupBox4.Controls.Add(this.lsbResultado);
            this.groupBox4.Location = new System.Drawing.Point(27, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(489, 112);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Resultado";
            // 
            // lsbAutos
            // 
            this.lsbAutos.FormattingEnabled = true;
            this.lsbAutos.Location = new System.Drawing.Point(13, 19);
            this.lsbAutos.Name = "lsbAutos";
            this.lsbAutos.Size = new System.Drawing.Size(167, 95);
            this.lsbAutos.TabIndex = 0;
            this.lsbAutos.SelectedIndexChanged += new System.EventHandler(this.lsbAutos_SelectedIndexChanged);
            // 
            // lsbResultado
            // 
            this.lsbResultado.FormattingEnabled = true;
            this.lsbResultado.Location = new System.Drawing.Point(203, 20);
            this.lsbResultado.Name = "lsbResultado";
            this.lsbResultado.Size = new System.Drawing.Size(280, 82);
            this.lsbResultado.TabIndex = 0;
            this.lsbResultado.SelectedIndexChanged += new System.EventHandler(this.lsbResultado_SelectedIndexChanged);
            // 
            // btnCorrerTiempo
            // 
            this.btnCorrerTiempo.Location = new System.Drawing.Point(14, 29);
            this.btnCorrerTiempo.Name = "btnCorrerTiempo";
            this.btnCorrerTiempo.Size = new System.Drawing.Size(178, 23);
            this.btnCorrerTiempo.TabIndex = 1;
            this.btnCorrerTiempo.Text = "Correr carrera por Tiempo";
            this.btnCorrerTiempo.UseVisualStyleBackColor = true;
            this.btnCorrerTiempo.Click += new System.EventHandler(this.btnCorrerTiempo_Click);
            // 
            // btnCorrerKm
            // 
            this.btnCorrerKm.Location = new System.Drawing.Point(14, 74);
            this.btnCorrerKm.Name = "btnCorrerKm";
            this.btnCorrerKm.Size = new System.Drawing.Size(178, 23);
            this.btnCorrerKm.TabIndex = 2;
            this.btnCorrerKm.Text = "Correr carrera por Kilometro";
            this.btnCorrerKm.UseVisualStyleBackColor = true;
            this.btnCorrerKm.Click += new System.EventHandler(this.btnCorrerKm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 424);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbAutos);
            this.Controls.Add(this.grbCarrera);
            this.Name = "Form1";
            this.Text = "Carrera";
            this.grbCarrera.ResumeLayout(false);
            this.grbCarrera.PerformLayout();
            this.grbAutos.ResumeLayout(false);
            this.grbAutos.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbCarrera;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbAutos;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lsbAutos;
        private System.Windows.Forms.Button btnCorrerKm;
        private System.Windows.Forms.Button btnCorrerTiempo;
        private System.Windows.Forms.ListBox lsbResultado;
    }
}

