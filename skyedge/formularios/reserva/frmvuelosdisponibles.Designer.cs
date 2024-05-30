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
            this.origen_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvvuelta = new System.Windows.Forms.DataGridView();
            this.Elegir1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origen_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.lblpasajeros = new System.Windows.Forms.Label();
            this.lblfida = new System.Windows.Forms.Label();
            this.lblregreso = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.origen_ida,
            this.destino_ida,
            this.fecha_ida,
            this.hora_salida_ida,
            this.hora_llegada_ida,
            this.precio_ida});
            this.dgvida.Location = new System.Drawing.Point(21, 203);
            this.dgvida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvida.Name = "dgvida";
            this.dgvida.RowHeadersWidth = 51;
            this.dgvida.RowTemplate.Height = 24;
            this.dgvida.Size = new System.Drawing.Size(923, 166);
            this.dgvida.TabIndex = 0;
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.MinimumWidth = 6;
            this.Elegir.Name = "Elegir";
            this.Elegir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Elegir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Elegir.Width = 125;
            // 
            // origen_ida
            // 
            this.origen_ida.HeaderText = "Origen";
            this.origen_ida.MinimumWidth = 6;
            this.origen_ida.Name = "origen_ida";
            this.origen_ida.Width = 125;
            // 
            // destino_ida
            // 
            this.destino_ida.HeaderText = "Destino";
            this.destino_ida.MinimumWidth = 6;
            this.destino_ida.Name = "destino_ida";
            this.destino_ida.Width = 125;
            // 
            // fecha_ida
            // 
            this.fecha_ida.HeaderText = "Fecha";
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
            this.hora_llegada_ida.HeaderText = "Hora Llegada";
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
            this.origen_regreso,
            this.destino_regreso,
            this.fecha_regreso,
            this.hora_salida_regreso,
            this.hora_llegada_regreso,
            this.precio_regreso});
            this.dgvvuelta.Location = new System.Drawing.Point(21, 466);
            this.dgvvuelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvvuelta.Name = "dgvvuelta";
            this.dgvvuelta.RowHeadersWidth = 51;
            this.dgvvuelta.RowTemplate.Height = 24;
            this.dgvvuelta.Size = new System.Drawing.Size(929, 158);
            this.dgvvuelta.TabIndex = 4;
            // 
            // Elegir1
            // 
            this.Elegir1.HeaderText = "Elegir";
            this.Elegir1.MinimumWidth = 6;
            this.Elegir1.Name = "Elegir1";
            this.Elegir1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Elegir1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Elegir1.Width = 125;
            // 
            // origen_regreso
            // 
            this.origen_regreso.HeaderText = "Origen";
            this.origen_regreso.MinimumWidth = 6;
            this.origen_regreso.Name = "origen_regreso";
            this.origen_regreso.Width = 125;
            // 
            // destino_regreso
            // 
            this.destino_regreso.HeaderText = "Destino";
            this.destino_regreso.MinimumWidth = 6;
            this.destino_regreso.Name = "destino_regreso";
            this.destino_regreso.Width = 125;
            // 
            // fecha_regreso
            // 
            this.fecha_regreso.HeaderText = "Fecha";
            this.fecha_regreso.MinimumWidth = 6;
            this.fecha_regreso.Name = "fecha_regreso";
            this.fecha_regreso.Width = 125;
            // 
            // hora_salida_regreso
            // 
            this.hora_salida_regreso.HeaderText = "Hora salida";
            this.hora_salida_regreso.MinimumWidth = 6;
            this.hora_salida_regreso.Name = "hora_salida_regreso";
            this.hora_salida_regreso.Width = 125;
            // 
            // hora_llegada_regreso
            // 
            this.hora_llegada_regreso.HeaderText = "Hora llegada";
            this.hora_llegada_regreso.MinimumWidth = 6;
            this.hora_llegada_regreso.Name = "hora_llegada_regreso";
            this.hora_llegada_regreso.Width = 125;
            // 
            // precio_regreso
            // 
            this.precio_regreso.HeaderText = "Precio";
            this.precio_regreso.MinimumWidth = 6;
            this.precio_regreso.Name = "precio_regreso";
            this.precio_regreso.Width = 125;
            // 
            // btncontinuar
            // 
            this.btncontinuar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btncontinuar.Location = new System.Drawing.Point(981, 409);
            this.btncontinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.lblpasajeros.Visible = false;
            // 
            // lblfida
            // 
            this.lblfida.AutoSize = true;
            this.lblfida.Location = new System.Drawing.Point(625, 154);
            this.lblfida.Name = "lblfida";
            this.lblfida.Size = new System.Drawing.Size(44, 16);
            this.lblfida.TabIndex = 7;
            this.lblfida.Text = "label3";
            this.lblfida.Visible = false;
            // 
            // lblregreso
            // 
            this.lblregreso.AutoSize = true;
            this.lblregreso.Location = new System.Drawing.Point(695, 158);
            this.lblregreso.Name = "lblregreso";
            this.lblregreso.Size = new System.Drawing.Size(44, 16);
            this.lblregreso.TabIndex = 8;
            this.lblregreso.Text = "label3";
            this.lblregreso.Visible = false;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(765, 162);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(44, 16);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "label3";
            this.lblFecha.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(533, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 68);
            this.label3.TabIndex = 10;
            this.label3.Text = "VUELOS DISPONIBLES";
            // 
            // frmvuelosdisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1267, 663);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblregreso);
            this.Controls.Add(this.lblfida);
            this.Controls.Add(this.lblpasajeros);
            this.Controls.Add(this.btncontinuar);
            this.Controls.Add(this.dgvvuelta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvida);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        public System.Windows.Forms.Label lblpasajeros;
        public System.Windows.Forms.Label lblfida;
        public System.Windows.Forms.Label lblregreso;
        public System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir1;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_regreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_ida;
        private System.Windows.Forms.Label label3;
    }
}