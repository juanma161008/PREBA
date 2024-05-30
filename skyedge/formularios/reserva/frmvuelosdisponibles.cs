using skyedge.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace skyedge.formularios
{
    public partial class frmvuelosdisponibles : Form
    {
        private string direccion;
        private string origen;
        private string destino;
        private DateTime fechaSalida;
        private DateTime? fechaRegreso;

        public frmvuelosdisponibles(string direccion, string origen, string destino, DateTime fechaSalida, DateTime? fechaRegreso)
        {
            InitializeComponent();
            this.direccion = direccion;
            this.origen = origen;
            this.destino = destino;
            this.fechaSalida = fechaSalida;
            this.fechaRegreso = fechaRegreso;
            LlenarDataGridViewIda();
            LlenarDataGridViewVuelta();
        }

        public frmvuelosdisponibles()
        {
            InitializeComponent();
        }

        private void LlenarDataGridViewIda()
        {
            Cconexion conexionDB = new Cconexion();
            using (SqlConnection connection = conexionDB.AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblVuelosIda", connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvida.Rows.Clear(); // Limpiar cualquier fila existente
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvida.Rows.Add(
                            false,
                            row["origen_ida"].ToString(),
                            row["destino_ida"].ToString(),
                            Convert.ToDateTime(row["fecha_ida"]).ToString("dd/MM/yyyy"),
                            row["hora_salida_ida"].ToString(),
                            row["hora_llegada_ida"].ToString(),
                            Convert.ToDecimal(row["precio_ida"]).ToString("0.00")
                        );
                    }
                }
            }
        }

        private void LlenarDataGridViewVuelta()
        {
            Cconexion conexionDB = new Cconexion();
            using (SqlConnection connection = conexionDB.AbrirConexion())
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblVuelosRegreso", connection);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvvuelta.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dgvvuelta.Rows.Add(
                            false, // Valor booleano para el checkbox
                            row["origen_regreso"].ToString(),
                            row["destino_regreso"].ToString(),
                            Convert.ToDateTime(row["fecha_regreso"]).ToString("dd/MM/yyyy"),
                            row["hora_salida_regreso"].ToString(),
                            row["hora_llegada_regreso"].ToString(),
                            Convert.ToDecimal(row["precio_regreso"]).ToString("0.00")
                        );
                    }
                }
            }
        }

        private void frmvuelosdisponibles_Load(object sender, EventArgs e)
        {
            LlenarDataGridViewIda();
            LlenarDataGridViewVuelta();
        }

        private List<DataGridViewRow> ObtenerFilasSeleccionadasIda()
        {
            List<DataGridViewRow> filasSeleccionadas = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in dgvida.Rows)
            {
                if (fila.DataBoundItem != null && fila.Cells[0].Value != null && (bool)fila.Cells[0].Value)
                {
                    filasSeleccionadas.Add(fila);
                }
            }
            return filasSeleccionadas;
        }

        private List<DataGridViewRow> ObtenerFilasSeleccionadasVuelta()
        {
            List<DataGridViewRow> filasSeleccionadas = new List<DataGridViewRow>();
            foreach (DataGridViewRow fila in dgvvuelta.Rows)
            {
                if (fila.DataBoundItem != null && fila.Cells[0].Value != null && (bool)fila.Cells[0].Value)
                {
                    filasSeleccionadas.Add(fila);
                }
            }
            return filasSeleccionadas;
        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> filasIdaSeleccionadas = ObtenerFilasSeleccionadasIda();
            List<DataGridViewRow> filasVueltaSeleccionadas = ObtenerFilasSeleccionadasVuelta();

            frminfopasajeros frmA = new frminfopasajeros(filasIdaSeleccionadas, filasVueltaSeleccionadas);
            frmA.dgvinfopasajeros.Rows.Add(Int32.Parse(lblpasajeros.Text));
            frmA.Show();
        }

        private void dgvvuelta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // No es necesario implementar nada aquí, ya que esta función se activa cuando se hace clic en cualquier celda del DataGridView de vuelta.
        }
    }
}