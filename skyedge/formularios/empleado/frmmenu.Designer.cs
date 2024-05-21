namespace skyedge.formularios
{
    partial class frmmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmenu));
            this.panelcentral = new System.Windows.Forms.Panel();
            this.panelsuperior = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelempleado = new System.Windows.Forms.Panel();
            this.btnempleado = new System.Windows.Forms.Button();
            this.btnvuelo = new System.Windows.Forms.Button();
            this.btnnomina = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelcliente = new System.Windows.Forms.Panel();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btnmodificacion = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelcentral.SuspendLayout();
            this.panelsuperior.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelempleado.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelcliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcentral
            // 
            this.panelcentral.Controls.Add(this.panelsuperior);
            this.panelcentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcentral.Location = new System.Drawing.Point(0, 0);
            this.panelcentral.Name = "panelcentral";
            this.panelcentral.Size = new System.Drawing.Size(1159, 837);
            this.panelcentral.TabIndex = 0;
            this.panelcentral.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcentral_Paint);
            // 
            // panelsuperior
            // 
            this.panelsuperior.Controls.Add(this.panel3);
            this.panelsuperior.Controls.Add(this.panel2);
            this.panelsuperior.Controls.Add(this.panel1);
            this.panelsuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsuperior.Location = new System.Drawing.Point(0, 0);
            this.panelsuperior.Name = "panelsuperior";
            this.panelsuperior.Size = new System.Drawing.Size(1159, 133);
            this.panelsuperior.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelempleado);
            this.panel3.Controls.Add(this.btnempleados);
            this.panel3.Location = new System.Drawing.Point(700, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 129);
            this.panel3.TabIndex = 2;
            // 
            // panelempleado
            // 
            this.panelempleado.Controls.Add(this.btnempleado);
            this.panelempleado.Controls.Add(this.btnvuelo);
            this.panelempleado.Controls.Add(this.btnnomina);
            this.panelempleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelempleado.Location = new System.Drawing.Point(0, 38);
            this.panelempleado.Name = "panelempleado";
            this.panelempleado.Size = new System.Drawing.Size(458, 91);
            this.panelempleado.TabIndex = 1;
            // 
            // btnempleado
            // 
            this.btnempleado.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnempleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnempleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleado.ForeColor = System.Drawing.Color.White;
            this.btnempleado.Location = new System.Drawing.Point(0, 63);
            this.btnempleado.Name = "btnempleado";
            this.btnempleado.Size = new System.Drawing.Size(458, 31);
            this.btnempleado.TabIndex = 2;
            this.btnempleado.Text = "Empleados";
            this.btnempleado.UseVisualStyleBackColor = false;
            this.btnempleado.Click += new System.EventHandler(this.btnempleado_Click);
            // 
            // btnvuelo
            // 
            this.btnvuelo.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnvuelo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnvuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvuelo.ForeColor = System.Drawing.Color.White;
            this.btnvuelo.Location = new System.Drawing.Point(0, 31);
            this.btnvuelo.Name = "btnvuelo";
            this.btnvuelo.Size = new System.Drawing.Size(458, 32);
            this.btnvuelo.TabIndex = 1;
            this.btnvuelo.Text = "Vuelos";
            this.btnvuelo.UseVisualStyleBackColor = false;
            this.btnvuelo.Click += new System.EventHandler(this.btnvuelo_Click);
            // 
            // btnnomina
            // 
            this.btnnomina.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnnomina.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnnomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnomina.ForeColor = System.Drawing.Color.White;
            this.btnnomina.Location = new System.Drawing.Point(0, 0);
            this.btnnomina.Name = "btnnomina";
            this.btnnomina.Size = new System.Drawing.Size(458, 31);
            this.btnnomina.TabIndex = 0;
            this.btnnomina.Text = "Nomina";
            this.btnnomina.UseVisualStyleBackColor = false;
            this.btnnomina.Click += new System.EventHandler(this.btnnomina_Click);
            // 
            // btnempleados
            // 
            this.btnempleados.BackColor = System.Drawing.Color.MediumPurple;
            this.btnempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnempleados.Location = new System.Drawing.Point(0, 0);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(458, 38);
            this.btnempleados.TabIndex = 0;
            this.btnempleados.Text = "Empleados";
            this.btnempleados.UseVisualStyleBackColor = false;
            this.btnempleados.Click += new System.EventHandler(this.btnempleados_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelcliente);
            this.panel2.Controls.Add(this.btncliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(287, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 133);
            this.panel2.TabIndex = 1;
            // 
            // panelcliente
            // 
            this.panelcliente.Controls.Add(this.btnusuario);
            this.panelcliente.Controls.Add(this.btnmodificacion);
            this.panelcliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelcliente.Location = new System.Drawing.Point(0, 41);
            this.panelcliente.Name = "panelcliente";
            this.panelcliente.Size = new System.Drawing.Size(410, 90);
            this.panelcliente.TabIndex = 1;
            // 
            // btnusuario
            // 
            this.btnusuario.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.White;
            this.btnusuario.Location = new System.Drawing.Point(0, 39);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(410, 52);
            this.btnusuario.TabIndex = 1;
            this.btnusuario.Text = "Usuarios";
            this.btnusuario.UseVisualStyleBackColor = false;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btnmodificacion
            // 
            this.btnmodificacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnmodificacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnmodificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmodificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificacion.ForeColor = System.Drawing.Color.White;
            this.btnmodificacion.Location = new System.Drawing.Point(0, 0);
            this.btnmodificacion.Name = "btnmodificacion";
            this.btnmodificacion.Size = new System.Drawing.Size(410, 39);
            this.btnmodificacion.TabIndex = 0;
            this.btnmodificacion.Text = " Modificacion";
            this.btnmodificacion.UseVisualStyleBackColor = false;
            this.btnmodificacion.Click += new System.EventHandler(this.btnmodificacion_Click);
            // 
            // btncliente
            // 
            this.btncliente.BackColor = System.Drawing.Color.MediumPurple;
            this.btncliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.SystemColors.Control;
            this.btncliente.Location = new System.Drawing.Point(0, 0);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(410, 41);
            this.btncliente.TabIndex = 0;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = false;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 133);
            this.panel1.TabIndex = 0;
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 837);
            this.Controls.Add(this.panelcentral);
            this.Name = "frmmenu";
            this.Text = "frmmenu";
            this.panelcentral.ResumeLayout(false);
            this.panelsuperior.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelempleado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelcliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelcentral;
        private System.Windows.Forms.Panel panelsuperior;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelcliente;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btnmodificacion;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.Panel panelempleado;
        private System.Windows.Forms.Button btnempleado;
        private System.Windows.Forms.Button btnvuelo;
        private System.Windows.Forms.Button btnnomina;
        private System.Windows.Forms.Button btnempleados;
    }
}