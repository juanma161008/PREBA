namespace skyedge.formularios
{
    partial class frmvuelosdisponibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmvuelosdisponibles));
            this.dgvida = new System.Windows.Forms.DataGridView();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Origen_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvvuelta = new System.Windows.Forms.DataGridView();
            this.Elegir1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origen_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_vuelta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblpasajeros = new System.Windows.Forms.Label();
            this.lblfida = new System.Windows.Forms.Label();
            this.lblfregreso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvuelta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvida
            // 
            this.dgvida.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir,
            this.Origen_ida,
            this.Destino_ida,
            this.fecha_ida,
            this.hora_salida_ida,
            this.hora_llegada_ida,
            this.precio_ida});
            this.dgvida.Location = new System.Drawing.Point(22, 203);
            this.dgvida.Name = "dgvida";
            this.dgvida.RowHeadersWidth = 51;
            this.dgvida.RowTemplate.Height = 24;
            this.dgvida.Size = new System.Drawing.Size(923, 166);
            this.dgvida.TabIndex = 0;
            this.dgvida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvida_CellContentClick);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.MinimumWidth = 6;
            this.Elegir.Name = "Elegir";
            this.Elegir.Width = 125;
            // 
            // Origen_ida
            // 
            this.Origen_ida.HeaderText = "Origen";
            this.Origen_ida.MinimumWidth = 6;
            this.Origen_ida.Name = "Origen_ida";
            this.Origen_ida.Width = 125;
            // 
            // Destino_ida
            // 
            this.Destino_ida.HeaderText = "Destino";
            this.Destino_ida.MinimumWidth = 6;
            this.Destino_ida.Name = "Destino_ida";
            this.Destino_ida.Width = 125;
            // 
            // fecha_ida
            // 
            this.fecha_ida.HeaderText = "fecha";
            this.fecha_ida.MinimumWidth = 6;
            this.fecha_ida.Name = "fecha_ida";
            this.fecha_ida.Width = 125;
            // 
            // hora_salida_ida
            // 
            this.hora_salida_ida.HeaderText = "Hora salida";
            this.hora_salida_ida.MinimumWidth = 6;
            this.hora_salida_ida.Name = "hora_salida_ida";
            this.hora_salida_ida.Width = 125;
            // 
            // hora_llegada_ida
            // 
            this.hora_llegada_ida.HeaderText = "Hora llegada";
            this.hora_llegada_ida.MinimumWidth = 6;
            this.hora_llegada_ida.Name = "hora_llegada_ida";
            this.hora_llegada_ida.Width = 125;
            // 
            // precio_ida
            // 
            this.precio_ida.HeaderText = "Precio";
            this.precio_ida.MinimumWidth = 6;
            this.precio_ida.Name = "precio_ida";
            this.precio_ida.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = " Elige un vuelo de ida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 49);
            this.label2.TabIndex = 3;
            this.label2.Text = " Elige un vuelo de vuelta";
            // 
            // dgvvuelta
            // 
            this.dgvvuelta.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvvuelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvuelta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir1,
            this.origen_vuelta,
            this.destino_vuelta,
            this.fecha_vuelta,
            this.hora_salida_vuelta,
            this.hora_llegada_vuelta,
            this.precio_vuelta});
            this.dgvvuelta.Location = new System.Drawing.Point(22, 468);
            this.dgvvuelta.Name = "dgvvuelta";
            this.dgvvuelta.RowHeadersWidth = 51;
            this.dgvvuelta.RowTemplate.Height = 24;
            this.dgvvuelta.Size = new System.Drawing.Size(929, 156);
            this.dgvvuelta.TabIndex = 4;
            // 
            // Elegir1
            // 
            this.Elegir1.HeaderText = "Elegir";
            this.Elegir1.MinimumWidth = 6;
            this.Elegir1.Name = "Elegir1";
            this.Elegir1.Width = 125;
            // 
            // origen_vuelta
            // 
            this.origen_vuelta.HeaderText = "Origen";
            this.origen_vuelta.MinimumWidth = 6;
            this.origen_vuelta.Name = "origen_vuelta";
            this.origen_vuelta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.origen_vuelta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.origen_vuelta.Width = 125;
            // 
            // destino_vuelta
            // 
            this.destino_vuelta.HeaderText = "Destino";
            this.destino_vuelta.MinimumWidth = 6;
            this.destino_vuelta.Name = "destino_vuelta";
            this.destino_vuelta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destino_vuelta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.destino_vuelta.Width = 125;
            // 
            // fecha_vuelta
            // 
            this.fecha_vuelta.HeaderText = "Fecha";
            this.fecha_vuelta.MinimumWidth = 6;
            this.fecha_vuelta.Name = "fecha_vuelta";
            this.fecha_vuelta.Width = 125;
            // 
            // hora_salida_vuelta
            // 
            this.hora_salida_vuelta.HeaderText = "Hora salida";
            this.hora_salida_vuelta.MinimumWidth = 6;
            this.hora_salida_vuelta.Name = "hora_salida_vuelta";
            this.hora_salida_vuelta.Width = 125;
            // 
            // hora_llegada_vuelta
            // 
            this.hora_llegada_vuelta.HeaderText = "Hora llegada";
            this.hora_llegada_vuelta.MinimumWidth = 6;
            this.hora_llegada_vuelta.Name = "hora_llegada_vuelta";
            this.hora_llegada_vuelta.Width = 125;
            // 
            // precio_vuelta
            // 
            this.precio_vuelta.HeaderText = "Pecio";
            this.precio_vuelta.MinimumWidth = 6;
            this.precio_vuelta.Name = "precio_vuelta";
            this.precio_vuelta.Width = 125;
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btncontinuar.Location = new System.Drawing.Point(981, 409);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(168, 34);
            this.btncontinuar.TabIndex = 5;
            this.btncontinuar.Text = " CONTINUAR";
            this.btncontinuar.UseVisualStyleBackColor = false;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // lblpasajeros
            // 
            this.lblpasajeros.AutoSize = true;
            this.lblpasajeros.Location = new System.Drawing.Point(552, 162);
            this.lblpasajeros.Name = "lblpasajeros";
            this.lblpasajeros.Size = new System.Drawing.Size(44, 16);
            this.lblpasajeros.TabIndex = 6;
            this.lblpasajeros.Text = "label3";
            // 
            // lblfida
            // 
            this.lblfida.AutoSize = true;
            this.lblfida.Location = new System.Drawing.Point(625, 154);
            this.lblfida.Name = "lblfida";
            this.lblfida.Size = new System.Drawing.Size(44, 16);
            this.lblfida.TabIndex = 7;
            this.lblfida.Text = "label3";
            // 
            // lblfregreso
            // 
            this.lblfregreso.AutoSize = true;
            this.lblfregreso.Location = new System.Drawing.Point(695, 157);
            this.lblfregreso.Name = "lblfregreso";
            this.lblfregreso.Size = new System.Drawing.Size(44, 16);
            this.lblfregreso.TabIndex = 8;
            this.lblfregreso.Text = "label3";
            // 
            // frmvuelosdisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1266, 663);
            this.Controls.Add(this.lblfregreso);
            this.Controls.Add(this.lblfida);
            this.Controls.Add(this.lblpasajeros);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.dgvvuelta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvida);
            this.Name = "frmvuelosdisponibles";
            this.Text = "frmvuelosdisponibles";
            this.Load += new System.EventHandler(this.frmvuelosdisponibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvuelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvvuelta;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir1;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen_vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_vuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_vuelta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Origen_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_ida;
        public System.Windows.Forms.Label lblpasajeros;
        public System.Windows.Forms.Label lblfida;
        public System.Windows.Forms.Label lblfregreso;
    }
}