namespace skyedge.formularios
{
    partial class frmnomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmnomina));
            this.txthoras = new System.Windows.Forms.TextBox();
            this.txtsalariobasico = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtdevengado = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtvalorextras = new System.Windows.Forms.TextBox();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.txtauxiliodetransporte = new System.Windows.Forms.TextBox();
            this.txtsalariobruto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtretefuente = new System.Windows.Forms.TextBox();
            this.txtpension = new System.Windows.Forms.TextBox();
            this.txtsalud = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.comboBoxFecha = new System.Windows.Forms.ComboBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txthoras
            // 
            this.txthoras.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txthoras.Location = new System.Drawing.Point(323, 407);
            this.txthoras.Name = "txthoras";
            this.txthoras.Size = new System.Drawing.Size(211, 30);
            this.txthoras.TabIndex = 28;
            // 
            // txtsalariobasico
            // 
            this.txtsalariobasico.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtsalariobasico.Location = new System.Drawing.Point(334, 353);
            this.txtsalariobasico.Name = "txtsalariobasico";
            this.txtsalariobasico.Size = new System.Drawing.Size(193, 30);
            this.txtsalariobasico.TabIndex = 27;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtnombre.Location = new System.Drawing.Point(261, 291);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(231, 30);
            this.txtnombre.TabIndex = 26;
            // 
            // txtcedula
            // 
            this.txtcedula.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtcedula.Location = new System.Drawing.Point(261, 229);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.Size = new System.Drawing.Size(220, 30);
            this.txtcedula.TabIndex = 25;
            this.txtcedula.Leave += new System.EventHandler(this.txtcedula_Leave_1);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.DarkRed;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(204, 459);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(243, 49);
            this.btnguardar.TabIndex = 24;
            this.btnguardar.Text = "Calcular y Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(119, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Horas Trabajadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Salario Basico Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(119, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Cornsilk;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = " Cedula";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Controls.Add(this.txtdevengado);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(634, 431);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(417, 181);
            this.panel4.TabIndex = 19;
            // 
            // txtdevengado
            // 
            this.txtdevengado.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtdevengado.Location = new System.Drawing.Point(80, 103);
            this.txtdevengado.Name = "txtdevengado";
            this.txtdevengado.Size = new System.Drawing.Size(271, 30);
            this.txtdevengado.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(144, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total Devengado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Controls.Add(this.txtvalorextras);
            this.panel3.Controls.Add(this.txthorasextras);
            this.panel3.Controls.Add(this.txtauxiliodetransporte);
            this.panel3.Controls.Add(this.txtsalariobruto);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(634, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(417, 210);
            this.panel3.TabIndex = 18;
            // 
            // txtvalorextras
            // 
            this.txtvalorextras.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtvalorextras.Location = new System.Drawing.Point(195, 150);
            this.txtvalorextras.Name = "txtvalorextras";
            this.txtvalorextras.Size = new System.Drawing.Size(197, 30);
            this.txtvalorextras.TabIndex = 21;
            // 
            // txthorasextras
            // 
            this.txthorasextras.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txthorasextras.Location = new System.Drawing.Point(195, 101);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(197, 30);
            this.txthorasextras.TabIndex = 20;
            // 
            // txtauxiliodetransporte
            // 
            this.txtauxiliodetransporte.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtauxiliodetransporte.Location = new System.Drawing.Point(195, 53);
            this.txtauxiliodetransporte.Name = "txtauxiliodetransporte";
            this.txtauxiliodetransporte.Size = new System.Drawing.Size(199, 30);
            this.txtauxiliodetransporte.TabIndex = 19;
            // 
            // txtsalariobruto
            // 
            this.txtsalariobruto.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.txtsalariobruto.Location = new System.Drawing.Point(195, 16);
            this.txtsalariobruto.Name = "txtsalariobruto";
            this.txtsalariobruto.Size = new System.Drawing.Size(200, 30);
            this.txtsalariobruto.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = " Valor Extras";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(8, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = " Horas Extras";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(8, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Auxilio de Transporte";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Salario Bruto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(572, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 555);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.txtretefuente);
            this.panel1.Controls.Add(this.txtpension);
            this.panel1.Controls.Add(this.txtsalud);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(123, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(403, 170);
            this.panel1.TabIndex = 16;
            // 
            // txtretefuente
            // 
            this.txtretefuente.Location = new System.Drawing.Point(199, 114);
            this.txtretefuente.Name = "txtretefuente";
            this.txtretefuente.Size = new System.Drawing.Size(169, 20);
            this.txtretefuente.TabIndex = 16;
            // 
            // txtpension
            // 
            this.txtpension.Location = new System.Drawing.Point(165, 59);
            this.txtpension.Name = "txtpension";
            this.txtpension.Size = new System.Drawing.Size(192, 20);
            this.txtpension.TabIndex = 15;
            // 
            // txtsalud
            // 
            this.txtsalud.Location = new System.Drawing.Point(148, 18);
            this.txtsalud.Name = "txtsalud";
            this.txtsalud.Size = new System.Drawing.Size(210, 20);
            this.txtsalud.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = " Retefuente 10%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Pension 4%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Salud 4%";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.BackColor = System.Drawing.Color.Cornsilk;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(120, 167);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(59, 20);
            this.Fecha.TabIndex = 29;
            this.Fecha.Text = "Fecha";
            // 
            // comboBoxFecha
            // 
            this.comboBoxFecha.Font = new System.Drawing.Font("Sans Serif Collection", 7F);
            this.comboBoxFecha.FormattingEnabled = true;
            this.comboBoxFecha.Items.AddRange(new object[] {
            "2024-01",
            "2024-02",
            "2024-03",
            "2024-04",
            "2024-05",
            "2024-06",
            "2024-07",
            "2024-08",
            "2024-09",
            "2024-10",
            "2024-11",
            "2024-12"});
            this.comboBoxFecha.Location = new System.Drawing.Point(251, 170);
            this.comboBoxFecha.Name = "comboBoxFecha";
            this.comboBoxFecha.Size = new System.Drawing.Size(229, 31);
            this.comboBoxFecha.TabIndex = 30;
            // 
            // frmnomina
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1107, 572);
            this.Controls.Add(this.comboBoxFecha);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.txthoras);
            this.Controls.Add(this.txtsalariobasico);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcedula);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmnomina";
            this.Text = "frmnomina";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txthoras;
        private System.Windows.Forms.TextBox txtsalariobasico;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtdevengado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtvalorextras;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.TextBox txtauxiliodetransporte;
        private System.Windows.Forms.TextBox txtsalariobruto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtretefuente;
        private System.Windows.Forms.TextBox txtpension;
        private System.Windows.Forms.TextBox txtsalud;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.ComboBox comboBoxFecha;
    }
}