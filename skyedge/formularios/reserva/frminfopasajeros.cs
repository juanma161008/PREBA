using skyedge.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace skyedge.formularios
{
    public partial class frminfopasajeros : Form
    {
        public frminfopasajeros()
        {
            InitializeComponent();
        }

        public frminfopasajeros(List<DataGridViewRow> filasIdaSeleccionadas, List<DataGridViewRow> filasVueltaSeleccionadas)
        {
            InitializeComponent();
            LlenarDataGridViewReservaIda(filasIdaSeleccionadas);
            LlenarDataGridViewReservaVuelta(filasVueltaSeleccionadas);
        }

        private void LlenarDataGridViewReservaIda(List<DataGridViewRow> filasIdaSeleccionadas)
        {
            foreach (DataGridViewRow fila in filasIdaSeleccionadas)
            {
                dgvida.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
            }
        }

        private void LlenarDataGridViewReservaVuelta(List<DataGridViewRow> filasVueltaSeleccionadas)
        {
            foreach (DataGridViewRow fila in filasVueltaSeleccionadas)
            {
                dgvvuelta.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
            }
        }

        private void frminfopasajeros_Load(object sender, EventArgs e)
        {
            // No es necesario llamar a los métodos de llenado aquí ya que se llaman en el constructor.
        }

        private void GuardarDatosEnBD(DataGridView dgv)
        {
            // Establecer la conexión con la base de datos
            Cconexion conexionDB = new Cconexion();
            using (SqlConnection connection = conexionDB.AbrirConexion())
            {
                // Definir la consulta SQL para la inserción
                string query = "INSERT INTO tblPasajero (Cedula, Nombre, Apellido, Telefono, fecha_nacimineto, Direccion) " +
                               "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @FechaNacimiento, @Direccion)";

                // Crear el comando SQL
                SqlCommand cmd = new SqlCommand(query, connection);

                // Recorrer las filas del DataGridView
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    // Verificar si la fila no es nueva y está completa
                    if (!fila.IsNewRow && fila.Cells[0].Value != null && fila.Cells[1].Value != null &&
                        fila.Cells[2].Value != null && fila.Cells[3].Value != null && fila.Cells[4].Value != null &&
                        fila.Cells[5].Value != null)
                    {
                        // Agregar parámetros
                        cmd.Parameters.Clear(); // Limpiar parámetros anteriores
                        cmd.Parameters.AddWithValue("@Cedula", fila.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@Nombre", fila.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@Apellido", fila.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@Telefono", fila.Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fila.Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@Direccion", fila.Cells[5].Value.ToString());

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Datos guardados en la base de datos.");
            }
        }

        private string ObtenerValorCelda(DataGridViewRow fila, string nombreColumna)
        {
            DataGridViewCell celda = fila.Cells[nombreColumna]; 
            if (celda != null && celda.Value != null)
            {
                return celda.Value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarDatosEnBD(dgvinfopasajeros);
        }
    }
}
