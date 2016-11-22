namespace tercerClaseUI
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
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.txtLugarCarrera = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtFechaCarrera = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombreCarrera = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricanteAuto = new System.Windows.Forms.Label();
            this.txtNombrePiloto = new System.Windows.Forms.TextBox();
            this.lblNombrePiloto = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.nmcCantidadKyT = new System.Windows.Forms.NumericUpDown();
            this.txtCorrerCarrera = new System.Windows.Forms.TextBox();
            this.btnCorrerCarrera = new System.Windows.Forms.Button();
            this.cmbTipoCarrera = new System.Windows.Forms.ComboBox();
            this.lblTipoResultado = new System.Windows.Forms.Label();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.lsbAutos = new System.Windows.Forms.ListBox();
            this.grbOrdenar = new System.Windows.Forms.GroupBox();
            this.cmbPorFoP = new System.Windows.Forms.ComboBox();
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.rbDes = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidadKyT)).BeginInit();
            this.gpbListado.SuspendLayout();
            this.grbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(334, 79);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(138, 36);
            this.btnCrearCarrera.TabIndex = 0;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.txtLugarCarrera);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtFechaCarrera);
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtNombreCarrera);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Location = new System.Drawing.Point(13, 13);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(500, 130);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // txtLugarCarrera
            // 
            this.txtLugarCarrera.Location = new System.Drawing.Point(334, 36);
            this.txtLugarCarrera.Name = "txtLugarCarrera";
            this.txtLugarCarrera.Size = new System.Drawing.Size(156, 20);
            this.txtLugarCarrera.TabIndex = 6;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(331, 20);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 5;
            this.lblLugar.Text = "Lugar:";
            // 
            // txtFechaCarrera
            // 
            this.txtFechaCarrera.Location = new System.Drawing.Point(172, 36);
            this.txtFechaCarrera.Name = "txtFechaCarrera";
            this.txtFechaCarrera.Size = new System.Drawing.Size(156, 20);
            this.txtFechaCarrera.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(169, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // txtNombreCarrera
            // 
            this.txtNombreCarrera.Location = new System.Drawing.Point(10, 36);
            this.txtNombreCarrera.Name = "txtNombreCarrera";
            this.txtNombreCarrera.Size = new System.Drawing.Size(156, 20);
            this.txtNombreCarrera.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.lblFabricanteAuto);
            this.gpbAutos.Controls.Add(this.txtNombrePiloto);
            this.gpbAutos.Controls.Add(this.lblNombrePiloto);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Enabled = false;
            this.gpbAutos.Location = new System.Drawing.Point(16, 149);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(258, 125);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            this.gpbAutos.Enter += new System.EventHandler(this.gpbAutos_Enter);
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(10, 88);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(124, 21);
            this.cmbFabricante.TabIndex = 4;
            // 
            // lblFabricanteAuto
            // 
            this.lblFabricanteAuto.AutoSize = true;
            this.lblFabricanteAuto.Location = new System.Drawing.Point(7, 72);
            this.lblFabricanteAuto.Name = "lblFabricanteAuto";
            this.lblFabricanteAuto.Size = new System.Drawing.Size(101, 13);
            this.lblFabricanteAuto.TabIndex = 3;
            this.lblFabricanteAuto.Text = "Fabricante del auto:";
            // 
            // txtNombrePiloto
            // 
            this.txtNombrePiloto.Location = new System.Drawing.Point(7, 37);
            this.txtNombrePiloto.Name = "txtNombrePiloto";
            this.txtNombrePiloto.Size = new System.Drawing.Size(127, 20);
            this.txtNombrePiloto.TabIndex = 2;
            // 
            // lblNombrePiloto
            // 
            this.lblNombrePiloto.AutoSize = true;
            this.lblNombrePiloto.Location = new System.Drawing.Point(7, 20);
            this.lblNombrePiloto.Name = "lblNombrePiloto";
            this.lblNombrePiloto.Size = new System.Drawing.Size(92, 13);
            this.lblNombrePiloto.TabIndex = 1;
            this.lblNombrePiloto.Text = "Nombre del piloto:";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(146, 58);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(95, 27);
            this.btnAgregarAuto.TabIndex = 0;
            this.btnAgregarAuto.Text = "Agregar auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.nmcCantidadKyT);
            this.gpbResultado.Controls.Add(this.txtCorrerCarrera);
            this.gpbResultado.Controls.Add(this.btnCorrerCarrera);
            this.gpbResultado.Controls.Add(this.cmbTipoCarrera);
            this.gpbResultado.Controls.Add(this.lblTipoResultado);
            this.gpbResultado.Enabled = false;
            this.gpbResultado.Location = new System.Drawing.Point(16, 353);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(497, 117);
            this.gpbResultado.TabIndex = 3;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Resultado";
            // 
            // nmcCantidadKyT
            // 
            this.nmcCantidadKyT.Location = new System.Drawing.Point(14, 62);
            this.nmcCantidadKyT.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nmcCantidadKyT.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcCantidadKyT.Name = "nmcCantidadKyT";
            this.nmcCantidadKyT.Size = new System.Drawing.Size(120, 20);
            this.nmcCantidadKyT.TabIndex = 5;
            this.nmcCantidadKyT.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmcCantidadKyT.ValueChanged += new System.EventHandler(this.nmcCantidadKyT_ValueChanged);
            // 
            // txtCorrerCarrera
            // 
            this.txtCorrerCarrera.Location = new System.Drawing.Point(169, 17);
            this.txtCorrerCarrera.Multiline = true;
            this.txtCorrerCarrera.Name = "txtCorrerCarrera";
            this.txtCorrerCarrera.Size = new System.Drawing.Size(318, 94);
            this.txtCorrerCarrera.TabIndex = 4;
            this.txtCorrerCarrera.TextChanged += new System.EventHandler(this.txtCorrerCarrera_TextChanged);
            // 
            // btnCorrerCarrera
            // 
            this.btnCorrerCarrera.Location = new System.Drawing.Point(27, 88);
            this.btnCorrerCarrera.Name = "btnCorrerCarrera";
            this.btnCorrerCarrera.Size = new System.Drawing.Size(92, 23);
            this.btnCorrerCarrera.TabIndex = 3;
            this.btnCorrerCarrera.Text = "Correr carrera";
            this.btnCorrerCarrera.UseVisualStyleBackColor = true;
            this.btnCorrerCarrera.Click += new System.EventHandler(this.btnCorrerCarrera_Click);
            // 
            // cmbTipoCarrera
            // 
            this.cmbTipoCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCarrera.FormattingEnabled = true;
            this.cmbTipoCarrera.Items.AddRange(new object[] {
            "Tiempo",
            "Kilometros"});
            this.cmbTipoCarrera.Location = new System.Drawing.Point(13, 36);
            this.cmbTipoCarrera.Name = "cmbTipoCarrera";
            this.cmbTipoCarrera.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoCarrera.TabIndex = 1;
            // 
            // lblTipoResultado
            // 
            this.lblTipoResultado.AutoSize = true;
            this.lblTipoResultado.Location = new System.Drawing.Point(10, 20);
            this.lblTipoResultado.Name = "lblTipoResultado";
            this.lblTipoResultado.Size = new System.Drawing.Size(131, 13);
            this.lblTipoResultado.TabIndex = 0;
            this.lblTipoResultado.Text = "Forma de correr la carrera:";
            // 
            // gpbListado
            // 
            this.gpbListado.Controls.Add(this.lsbAutos);
            this.gpbListado.Enabled = false;
            this.gpbListado.Location = new System.Drawing.Point(280, 149);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Size = new System.Drawing.Size(233, 198);
            this.gpbListado.TabIndex = 4;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado de autos";
            // 
            // lsbAutos
            // 
            this.lsbAutos.FormattingEnabled = true;
            this.lsbAutos.Location = new System.Drawing.Point(6, 19);
            this.lsbAutos.Name = "lsbAutos";
            this.lsbAutos.Size = new System.Drawing.Size(216, 173);
            this.lsbAutos.TabIndex = 0;
            // 
            // grbOrdenar
            // 
            this.grbOrdenar.Controls.Add(this.btnOrdenar);
            this.grbOrdenar.Controls.Add(this.rbDes);
            this.grbOrdenar.Controls.Add(this.rbAsc);
            this.grbOrdenar.Controls.Add(this.cmbPorFoP);
            this.grbOrdenar.Location = new System.Drawing.Point(16, 280);
            this.grbOrdenar.Name = "grbOrdenar";
            this.grbOrdenar.Size = new System.Drawing.Size(258, 67);
            this.grbOrdenar.TabIndex = 1;
            this.grbOrdenar.TabStop = false;
            this.grbOrdenar.Text = "Ordenar";
            // 
            // cmbPorFoP
            // 
            this.cmbPorFoP.AutoCompleteCustomSource.AddRange(new string[] {
            "Por Fabricante",
            "Por Piloto"});
            this.cmbPorFoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPorFoP.FormattingEnabled = true;
            this.cmbPorFoP.Items.AddRange(new object[] {
            "Por Fabricante",
            "Por Piloto"});
            this.cmbPorFoP.Location = new System.Drawing.Point(6, 28);
            this.cmbPorFoP.Name = "cmbPorFoP";
            this.cmbPorFoP.Size = new System.Drawing.Size(121, 21);
            this.cmbPorFoP.TabIndex = 0;
            this.cmbPorFoP.SelectedIndexChanged += new System.EventHandler(this.cmbPorFoP_SelectedIndexChanged);
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Location = new System.Drawing.Point(134, 19);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(46, 17);
            this.rbAsc.TabIndex = 1;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "ASC";
            this.rbAsc.UseVisualStyleBackColor = true;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // rbDes
            // 
            this.rbDes.AutoSize = true;
            this.rbDes.Location = new System.Drawing.Point(134, 42);
            this.rbDes.Name = "rbDes";
            this.rbDes.Size = new System.Drawing.Size(47, 17);
            this.rbDes.TabIndex = 2;
            this.rbDes.TabStop = true;
            this.rbDes.Text = "DES";
            this.rbDes.UseVisualStyleBackColor = true;
            this.rbDes.CheckedChanged += new System.EventHandler(this.rbDes_CheckedChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(183, 26);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 482);
            this.Controls.Add(this.grbOrdenar);
            this.Controls.Add(this.gpbListado);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "UI Carrera";
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gpbResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCantidadKyT)).EndInit();
            this.gpbListado.ResumeLayout(false);
            this.grbOrdenar.ResumeLayout(false);
            this.grbOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.TextBox txtLugarCarrera;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtFechaCarrera;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombreCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbResultado;
        private System.Windows.Forms.GroupBox gpbListado;
        private System.Windows.Forms.Label lblFabricanteAuto;
        private System.Windows.Forms.TextBox txtNombrePiloto;
        private System.Windows.Forms.Label lblNombrePiloto;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lsbAutos;
        private System.Windows.Forms.ComboBox cmbTipoCarrera;
        private System.Windows.Forms.Label lblTipoResultado;
        private System.Windows.Forms.Button btnCorrerCarrera;
        private System.Windows.Forms.TextBox txtCorrerCarrera;
        private System.Windows.Forms.NumericUpDown nmcCantidadKyT;
        private System.Windows.Forms.GroupBox grbOrdenar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbDes;
        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.ComboBox cmbPorFoP;
    }
}

