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
            this.dgvinfopasajeros = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfopasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvinfopasajeros
            // 
            this.dgvinfopasajeros.BackgroundColor = System.Drawing.Color.Indigo;
            this.dgvinfopasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfopasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.origen,
            this.destino,
            this.cedula,
            this.fechaN,
            this.telefono});
            this.dgvinfopasajeros.GridColor = System.Drawing.Color.Indigo;
            this.dgvinfopasajeros.Location = new System.Drawing.Point(19, 18);
            this.dgvinfopasajeros.Name = "dgvinfopasajeros";
            this.dgvinfopasajeros.RowHeadersWidth = 51;
            this.dgvinfopasajeros.RowTemplate.Height = 24;
            this.dgvinfopasajeros.Size = new System.Drawing.Size(804, 402);
            this.dgvinfopasajeros.TabIndex = 0;
            this.dgvinfopasajeros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinfopasajeros_CellContentClick);
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Completo ";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.Width = 125;
            // 
            // origen
            // 
            this.origen.HeaderText = "origen";
            this.origen.MinimumWidth = 6;
            this.origen.Name = "origen";
            this.origen.Width = 125;
            // 
            // destino
            // 
            this.destino.HeaderText = "Destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.Width = 125;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.Width = 125;
            // 
            // fechaN
            // 
            this.fechaN.HeaderText = "Fecha de nacimiento";
            this.fechaN.MinimumWidth = 6;
            this.fechaN.Name = "fechaN";
            this.fechaN.Width = 125;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // frminfopasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.dgvinfopasajeros);
            this.Name = "frminfopasajeros";
            this.Text = "frminfopasajeros";
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfopasajeros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        public System.Windows.Forms.DataGridView dgvinfopasajeros;
    }
}