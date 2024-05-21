namespace skyedge.formularios
{
    partial class frmreserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmreserva));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpvuelta = new System.Windows.Forms.DateTimePicker();
            this.dtpida = new System.Windows.Forms.DateTimePicker();
            this.cmbdestino = new System.Windows.Forms.ComboBox();
            this.cmbclase = new System.Windows.Forms.ComboBox();
            this.cmbdireccion = new System.Windows.Forms.ComboBox();
            this.cmborigen = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpasajeros = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-5, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1236, 259);
            this.panel2.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(915, 197);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(168, 34);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar vuelo";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtpasajeros);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpvuelta);
            this.panel1.Controls.Add(this.dtpida);
            this.panel1.Controls.Add(this.cmbdestino);
            this.panel1.Controls.Add(this.cmbclase);
            this.panel1.Controls.Add(this.cmbdireccion);
            this.panel1.Controls.Add(this.cmborigen);
            this.panel1.Location = new System.Drawing.Point(179, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 124);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(715, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha regreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(534, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fecha ida";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpvuelta
            // 
            this.dtpvuelta.Location = new System.Drawing.Point(680, 61);
            this.dtpvuelta.Name = "dtpvuelta";
            this.dtpvuelta.Size = new System.Drawing.Size(154, 22);
            this.dtpvuelta.TabIndex = 11;
            // 
            // dtpida
            // 
            this.dtpida.Location = new System.Drawing.Point(496, 61);
            this.dtpida.Name = "dtpida";
            this.dtpida.Size = new System.Drawing.Size(159, 22);
            this.dtpida.TabIndex = 10;
            // 
            // cmbdestino
            // 
            this.cmbdestino.FormattingEnabled = true;
            this.cmbdestino.Location = new System.Drawing.Point(246, 59);
            this.cmbdestino.Name = "cmbdestino";
            this.cmbdestino.Size = new System.Drawing.Size(181, 24);
            this.cmbdestino.TabIndex = 9;
            this.cmbdestino.Text = "Destino";
            // 
            // cmbclase
            // 
            this.cmbclase.FormattingEnabled = true;
            this.cmbclase.Items.AddRange(new object[] {
            "Economy ",
            "Bussinnes ",
            "First class"});
            this.cmbclase.Location = new System.Drawing.Point(200, 20);
            this.cmbclase.Name = "cmbclase";
            this.cmbclase.Size = new System.Drawing.Size(133, 24);
            this.cmbclase.TabIndex = 7;
            this.cmbclase.Text = "Clase";
            // 
            // cmbdireccion
            // 
            this.cmbdireccion.FormattingEnabled = true;
            this.cmbdireccion.Items.AddRange(new object[] {
            "Ida y Vuelta ",
            "Ida",
            "Vuelta"});
            this.cmbdireccion.Location = new System.Drawing.Point(23, 20);
            this.cmbdireccion.Name = "cmbdireccion";
            this.cmbdireccion.Size = new System.Drawing.Size(133, 24);
            this.cmbdireccion.TabIndex = 6;
            this.cmbdireccion.Text = "Direccion";
            // 
            // cmborigen
            // 
            this.cmborigen.FormattingEnabled = true;
            this.cmborigen.Location = new System.Drawing.Point(22, 59);
            this.cmborigen.Name = "cmborigen";
            this.cmborigen.Size = new System.Drawing.Size(181, 24);
            this.cmborigen.TabIndex = 5;
            this.cmborigen.Text = "Origen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vuelos";
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(302, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 250);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1130, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 51);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1068, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "COP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(540, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "CENTRO DE AYUDA";
            // 
            // txtpasajeros
            // 
            this.txtpasajeros.Location = new System.Drawing.Point(369, 23);
            this.txtpasajeros.Name = "txtpasajeros";
            this.txtpasajeros.Size = new System.Drawing.Size(136, 22);
            this.txtpasajeros.TabIndex = 14;
            // 
            // frmreserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1208, 653);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "frmreserva";
            this.Text = "frmreserva";
            this.Load += new System.EventHandler(this.frmreserva_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.ComboBox cmbdestino;
        private System.Windows.Forms.ComboBox cmbclase;
        private System.Windows.Forms.ComboBox cmbdireccion;
        private System.Windows.Forms.ComboBox cmborigen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpida;
        private System.Windows.Forms.DateTimePicker dtpvuelta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpasajeros;
    }
}