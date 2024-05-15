using skyedge.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyedge.formularios
{

    public partial class frmvuelosdisponibles : Form
    {
        private string direccion;
        private string origen;
        private string destino;

        public frmvuelosdisponibles(string direccion, string origen, string destino)
        {
            InitializeComponent();
            this.direccion = direccion;
            this.origen = origen;
            this.destino = destino;
            CargarVuelosDisponibles();
        }

        private void CargarVuelosDisponibles()
        {
            dgvida.Rows.Clear();
            dgvvuelta.Rows.Clear();

            try
            {
                // Instanciar la clase Cconexion
                Cconexion conexionDB = new Cconexion();

                // Crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM tblvuelos WHERE direccion = @direccion AND origen = @origen AND destino = @destino", conexionDB.AbrirConexion());

                // Definir los parámetros de la consulta
                adaptador.SelectCommand.Parameters.AddWithValue("@direccion", this.direccion);
                adaptador.SelectCommand.Parameters.AddWithValue("@origen", this.origen);
                adaptador.SelectCommand.Parameters.AddWithValue("@destino", this.destino);

                // Crear un DataTable para almacenar los resultados de la consulta
                DataTable tablaVuelos = new DataTable();

                // Llenar el DataTable con los resultados de la consulta
                adaptador.Fill(tablaVuelos);

                // Recorrer los resultados y agregarlos a los DataGridView
                foreach (DataRow fila in tablaVuelos.Rows)
                {
                    dgvida.Rows.Add(
                        fila["Origen_ida"].ToString(),
                        fila["Destino_ida"].ToString(),
                        Convert.ToDateTime(fila["fecha_ida"]).ToString("dd/MM/yyyy"),
                        fila["hora_salida_ida"].ToString(),
                        fila["hora_llegada_ida"].ToString(),
                        Convert.ToDecimal(fila["precio_isa"]).ToString("0.00")
                    );

                    // Agregar vuelos de vuelta si están disponibles
                    if (!DBNull.Value.Equals(fila["fecha_vuelta"]))
                    {
                        dgvvuelta.Rows.Add(
                            fila["origen_vuelta"].ToString(),
                            fila["destino_vuelta"].ToString(),
                            Convert.ToDateTime(fila["fecha_vuelta"]).ToString("dd/MM/yyyy"),
                            fila["horaSalida_vuelta"].ToString(),
                            fila["horaLlegada_vuelta"].ToString(),
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
    }

}
