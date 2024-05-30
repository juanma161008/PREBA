namespace skyedge.formularios
{
    partial class frminfopasajeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frminfopasajeros));
            this.dgvinfopasajeros = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.dgvida = new System.Windows.Forms.DataGridView();
            this.origen_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_ida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvvuelta = new System.Windows.Forms.DataGridView();
            this.origen_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_salida_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_llegada_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_regreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfopasajeros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvuelta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfopasajeros
            // 
            this.dgvinfopasajeros.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvinfopasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfopasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellido,
            this.telefono,
            this.fechaN,
            this.direccion});
            this.dgvinfopasajeros.Location = new System.Drawing.Point(168, 192);
            this.dgvinfopasajeros.Name = "dgvinfopasajeros";
            this.dgvinfopasajeros.RowHeadersWidth = 51;
            this.dgvinfopasajeros.RowTemplate.Height = 24;
            this.dgvinfopasajeros.Size = new System.Drawing.Size(806, 155);
            this.dgvinfopasajeros.TabIndex = 0;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.Width = 125;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre ";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // fechaN
            // 
            this.fechaN.HeaderText = "Fecha de nacimiento";
            this.fechaN.MinimumWidth = 6;
            this.fechaN.Name = "fechaN";
            this.fechaN.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.Width = 125;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(767, 667);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(380, 50);
            this.btnimprimir.TabIndex = 1;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "PASAJEROS";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(12, 667);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(380, 50);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgvida
            // 
            this.dgvida.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origen_ida,
            this.destino_ida,
            this.fecha_ida,
            this.hora_salida_ida,
            this.hora_llegada_ida,
            this.precio_ida});
            this.dgvida.Location = new System.Drawing.Point(173, 426);
            this.dgvida.Name = "dgvida";
            this.dgvida.RowHeadersWidth = 51;
            this.dgvida.RowTemplate.Height = 24;
            this.dgvida.Size = new System.Drawing.Size(801, 71);
            this.dgvida.TabIndex = 4;
            // 
            // origen_ida
            // 
            this.origen_ida.HeaderText = "Origen";
            this.origen_ida.MinimumWidth = 6;
            this.origen_ida.Name = "origen_ida";
            this.origen_ida.ReadOnly = true;
            this.origen_ida.Width = 125;
            // 
            // destino_ida
            // 
            this.destino_ida.HeaderText = "Destino";
            this.destino_ida.MinimumWidth = 6;
            this.destino_ida.Name = "destino_ida";
            this.destino_ida.ReadOnly = true;
            this.destino_ida.Width = 125;
            // 
            // fecha_ida
            // 
            this.fecha_ida.HeaderText = "Fecha";
            this.fecha_ida.MinimumWidth = 6;
            this.fecha_ida.Name = "fecha_ida";
            this.fecha_ida.ReadOnly = true;
            this.fecha_ida.Width = 125;
            // 
            // hora_salida_ida
            // 
            this.hora_salida_ida.HeaderText = "Hora salida";
            this.hora_salida_ida.MinimumWidth = 6;
            this.hora_salida_ida.Name = "hora_salida_ida";
            this.hora_salida_ida.ReadOnly = true;
            this.hora_salida_ida.Width = 125;
            // 
            // hora_llegada_ida
            // 
            this.hora_llegada_ida.HeaderText = "Hora llegada";
            this.hora_llegada_ida.MinimumWidth = 6;
            this.hora_llegada_ida.Name = "hora_llegada_ida";
            this.hora_llegada_ida.ReadOnly = true;
            this.hora_llegada_ida.Width = 125;
            // 
            // precio_ida
            // 
            this.precio_ida.HeaderText = "Precio";
            this.precio_ida.MinimumWidth = 6;
            this.precio_ida.Name = "precio_ida";
            this.precio_ida.ReadOnly = true;
            this.precio_ida.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(373, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(429, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "INFORMACION DEL VUELO IDA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 519);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(508, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "INFORMACION DE VUELO REGRESO";
            // 
            // dgvvuelta
            // 
            this.dgvvuelta.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvvuelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvvuelta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.origen_regreso,
            this.destino_regreso,
            this.fecha_regreso,
            this.hora_salida_regreso,
            this.hora_llegada_regreso,
            this.precio_regreso});
            this.dgvvuelta.Location = new System.Drawing.Point(173, 567);
            this.dgvvuelta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvvuelta.Name = "dgvvuelta";
            this.dgvvuelta.RowHeadersWidth = 51;
            this.dgvvuelta.RowTemplate.Height = 24;
            this.dgvvuelta.Size = new System.Drawing.Size(800, 72);
            this.dgvvuelta.TabIndex = 8;
            // 
            // origen_regreso
            // 
            this.origen_regreso.HeaderText = "Origen";
            this.origen_regreso.MinimumWidth = 6;
            this.origen_regreso.Name = "origen_regreso";
            this.origen_regreso.ReadOnly = true;
            this.origen_regreso.Width = 125;
            // 
            // destino_regreso
            // 
            this.destino_regreso.HeaderText = "Destino";
            this.destino_regreso.MinimumWidth = 6;
            this.destino_regreso.Name = "destino_regreso";
            this.destino_regreso.ReadOnly = true;
            this.destino_regreso.Width = 125;
            // 
            // fecha_regreso
            // 
            this.fecha_regreso.HeaderText = "Fecha";
            this.fecha_regreso.MinimumWidth = 6;
            this.fecha_regreso.Name = "fecha_regreso";
            this.fecha_regreso.ReadOnly = true;
            this.fecha_regreso.Width = 125;
            // 
            // hora_salida_regreso
            // 
            this.hora_salida_regreso.HeaderText = "Hora salida";
            this.hora_salida_regreso.MinimumWidth = 6;
            this.hora_salida_regreso.Name = "hora_salida_regreso";
            this.hora_salida_regreso.ReadOnly = true;
            this.hora_salida_regreso.Width = 125;
            // 
            // hora_llegada_regreso
            // 
            this.hora_llegada_regreso.HeaderText = "Hora llegada";
            this.hora_llegada_regreso.MinimumWidth = 6;
            this.hora_llegada_regreso.Name = "hora_llegada_regreso";
            this.hora_llegada_regreso.ReadOnly = true;
            this.hora_llegada_regreso.Width = 125;
            // 
            // precio_regreso
            // 
            this.precio_regreso.HeaderText = "Precio";
            this.precio_regreso.MinimumWidth = 6;
            this.precio_regreso.Name = "precio_regreso";
            this.precio_regreso.ReadOnly = true;
            this.precio_regreso.Width = 125;
            // 
            // frminfopasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 729);
            this.Controls.Add(this.dgvvuelta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvida);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.dgvinfopasajeros);
            this.Name = "frminfopasajeros";
            this.Text = "frminfopasajeros";
            this.Load += new System.EventHandler(this.frminfopasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfopasajeros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvvuelta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvinfopasajeros;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.DataGridView dgvida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvvuelta;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_ida;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_salida_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_llegada_regreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_regreso;
    }
}