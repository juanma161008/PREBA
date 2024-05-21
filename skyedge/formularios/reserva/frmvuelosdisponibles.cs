using skyedge.clases;
using System;
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
            CargarVuelosDisponibles();
        }
        public frmvuelosdisponibles() { }

        private void CargarVuelosDisponibles()
        {
           
            dgvida.Rows.Clear();
            dgvvuelta.Rows.Clear();

            try
            {
                // Instanciar la clase Cconexion
                Cconexion conexionDB = new Cconexion();

                // Crear la consulta para seleccionar los vuelos disponibles
                string query = @"
                SELECT *
                FROM tblvuelos
                WHERE (origen_ida = @origen AND destino_ida = @destino AND fecha_ida = @fechaSalida)
                OR (origen_vuelta = @destino AND destino_vuelta = @origen AND fecha_vuelta = @fechaRegreso)";

                // Crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexionDB.AbrirConexion());

                // Definir los parámetros de la consulta
                adaptador.SelectCommand.Parameters.AddWithValue("@origen", this.origen);
                adaptador.SelectCommand.Parameters.AddWithValue("@destino", this.destino);
                adaptador.SelectCommand.Parameters.AddWithValue("@fechaSalida", this.fechaSalida);

                if (this.fechaRegreso.HasValue)
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@fechaRegreso", this.fechaRegreso.Value);
                }
                else
                {
                    adaptador.SelectCommand.Parameters.AddWithValue("@fechaRegreso", DBNull.Value);
                }

                // Crear un DataTable para almacenar los resultados de la consulta
                DataTable tblvuelos = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adaptador.Fill(tblvuelos);

                // Llenar el DataGridView con los datos obtenidos
                foreach (DataRow fila in tblvuelos.Rows)
                {
                    MessageBox.Show("hola");
                    dgvida.Rows.Add(
                        fila["origen_ida"].ToString(),
                        fila["destino_ida"].ToString(),
                        Convert.ToDateTime(fila["fecha_ida"]).ToString("dd/MM/yyyy"),
                        fila["hora_salida_ida"].ToString(),
                        fila["hora_llegada_ida"].ToString(),
                        Convert.ToDecimal(fila["precio_ida"]).ToString("0.00")
                    );

                    // Agregar vuelos de vuelta si están disponibles
                    if (!DBNull.Value.Equals(fila["fecha_vuelta"]))
                    {
                        dgvvuelta.Rows.Add(
                            fila["origen_vuelta"].ToString(),
                            fila["destino_vuelta"].ToString(),
                            Convert.ToDateTime(fila["fecha_vuelta"]).ToString("dd/MM/yyyy"),
                            fila["hora_salida_vuelta"].ToString(),
                            fila["hora_llegada_vuelta"].ToString(),
                            Convert.ToDecimal(fila["precio_vuelta"]).ToString("0.00")
                        );
                    }
                }

                // Cerrar la conexión
                conexionDB.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los vuelos disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmvuelosdisponibles_Load(object sender, EventArgs e)
        {

        }

        private void dgvida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncontinuar_Click(object sender, EventArgs e)
        {
            //frminfopasajeros frmA = new frminfopasajeros();
            //frmA.dgvinfopasajeros.Rows.Add(txtpasajeros.Text);
            //frmA.Show();
        }
    }
}
