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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace skyedge.formularios
{
    public partial class frmreserva : Form
    {
        private Cconexion cn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        public frmreserva()
        {
            InitializeComponent();
            cn = new Cconexion();
            CargarDestinosYOrigenes();
        }

        private void frmreserva_Load(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            // Validar que se hayan seleccionado todas las opciones necesarias
            if (cmbdireccion.SelectedItem == null || cmborigen.SelectedItem == null || cmbdestino.SelectedItem == null || dtpida.Value == null)
            {
                MessageBox.Show("Por favor, complete todas las opciones de reserva.", "Error de reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener la información seleccionada
            string direccionParam = cmbdireccion.SelectedItem.ToString();
            string origenParam = cmborigen.SelectedItem.ToString();
            string destinoParam = cmbdestino.SelectedItem.ToString();
            DateTime fechaSalida = dtpida.Value;
            DateTime? fechaRegreso = null;

            // Si es vuelta o ida y vuelta, obtener la fecha de regreso
            if (direccionParam == "Vuelta" || direccionParam == "Ida y Vuelta")
            {
                if (dtpvuelta.Value == null)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de vuelta.", "Error de reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                fechaRegreso = dtpvuelta.Value;
            }

            // Crear la instancia del formulario de vuelos disponibles y pasar la información
            frmvuelosdisponibles vuelosDisponiblesForm = new frmvuelosdisponibles(direccionParam, origenParam, destinoParam);
            vuelosDisponiblesForm.Show();

            // Ocultar el formulario actual
            this.Hide();
        }

        private void frmreserva_Load_1(object sender, EventArgs e)
        {

        }
        private void CargarDestinosYOrigenes()
        {
            try
            {
                // Limpiar ComboBoxes
                cmborigen.Items.Clear();
                cmbdestino.Items.Clear();

                // Consultar la base de datos para obtener los destinos y orígenes disponibles
                string query = "SELECT DISTINCT origen_ida, destino_ida FROM tblvuelos";

                using (SqlConnection conexion = new SqlConnection(Cconexion.CadenaConexion))
                {
                    SqlCommand comando = new SqlCommand(query, conexion);
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        cmborigen.Items.Add(reader["origen_ida"].ToString());
                        cmbdestino.Items.Add(reader["destino_ida"].ToString());
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar destinos y orígenes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}