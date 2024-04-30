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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Elegir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLLegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Elegir1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.origen1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destino1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalida1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLLegada1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir,
            this.origen,
            this.destino,
            this.fecha,
            this.horaSalida,
            this.horaLLegada});
            this.dataGridView1.Location = new System.Drawing.Point(195, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(789, 156);
            this.dataGridView1.TabIndex = 0;
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Elegir
            // 
            this.Elegir.HeaderText = "Elegir";
            this.Elegir.MinimumWidth = 6;
            this.Elegir.Name = "Elegir";
            this.Elegir.Width = 125;
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
            this.destino.HeaderText = "destino";
            this.destino.MinimumWidth = 6;
            this.destino.Name = "destino";
            this.destino.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.Width = 125;
            // 
            // horaSalida
            // 
            this.horaSalida.HeaderText = "Hora salida";
            this.horaSalida.MinimumWidth = 6;
            this.horaSalida.Name = "horaSalida";
            this.horaSalida.Width = 125;
            // 
            // horaLLegada
            // 
            this.horaLLegada.HeaderText = "Hora llegada";
            this.horaLLegada.MinimumWidth = 6;
            this.horaLLegada.Name = "horaLLegada";
            this.horaLLegada.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Elegir1,
            this.origen1,
            this.destino1,
            this.fecha1,
            this.horaSalida1,
            this.horaLLegada1});
            this.dataGridView2.Location = new System.Drawing.Point(195, 466);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(789, 156);
            this.dataGridView2.TabIndex = 4;
            // 
            // Elegir1
            // 
            this.Elegir1.HeaderText = "Elegir";
            this.Elegir1.MinimumWidth = 6;
            this.Elegir1.Name = "Elegir1";
            this.Elegir1.Width = 125;
            // 
            // origen1
            // 
            this.origen1.HeaderText = "Origen";
            this.origen1.MinimumWidth = 6;
            this.origen1.Name = "origen1";
            this.origen1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.origen1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.origen1.Width = 125;
            // 
            // destino1
            // 
            this.destino1.HeaderText = "Destino";
            this.destino1.MinimumWidth = 6;
            this.destino1.Name = "destino1";
            this.destino1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.destino1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.destino1.Width = 125;
            // 
            // fecha1
            // 
            this.fecha1.HeaderText = "Fecha";
            this.fecha1.MinimumWidth = 6;
            this.fecha1.Name = "fecha1";
            this.fecha1.Width = 125;
            // 
            // horaSalida1
            // 
            this.horaSalida1.HeaderText = "Hora salida";
            this.horaSalida1.MinimumWidth = 6;
            this.horaSalida1.Name = "horaSalida1";
            this.horaSalida1.Width = 125;
            // 
            // horaLLegada1
            // 
            this.horaLLegada1.HeaderText = "Hora llegada";
            this.horaLLegada1.MinimumWidth = 6;
            this.horaLLegada1.Name = "horaLLegada1";
            this.horaLLegada1.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.button1.Location = new System.Drawing.Point(1027, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = " CONTINUAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // frmvuelosdisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1266, 663);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmvuelosdisponibles";
            this.Text = "frmvuelosdisponibles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLLegada;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Elegir1;
        private System.Windows.Forms.DataGridViewTextBoxColumn origen1;
        private System.Windows.Forms.DataGridViewTextBoxColumn destino1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida1;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLLegada1;
        private System.Windows.Forms.Button button1;
    }
}