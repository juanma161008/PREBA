using skyedge.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
            cargarciudad();

            dtpida.Format = DateTimePickerFormat.Custom;
            dtpida.CustomFormat = "yyyy-MM-dd";
            dtpida.ShowCheckBox = true;

            dtpvuelta.Format = DateTimePickerFormat.Custom;
            dtpvuelta.CustomFormat = "yyyy-MM-dd";
            dtpvuelta.ShowCheckBox = true;
        }

        void cargarciudad()
        {
            SqlCommand cmd = new SqlCommand("select nombre_ciudad from tblciudad", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmborigen.Items.Add(dt.Rows[i][0].ToString());
                cmbdestino.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void frmreserva_Load(object sender, EventArgs e)
        {
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmborigen.Text) || string.IsNullOrWhiteSpace(cmbdestino.Text))
            {
                MessageBox.Show("Por favor, seleccione el origen y el destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!dtpida.Checked)
            {
                MessageBox.Show("Por favor, seleccione una fecha de ida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string direccion = cmbdireccion.Text;
            string origen = cmborigen.Text;
            string destino = cmbdestino.Text;
            DateTime fechaSalida = dtpida.Value;
            DateTime? fechaRegreso = dtpvuelta.Checked ? (DateTime?)dtpvuelta.Value : null;

            frmvuelosdisponibles frmA = new frmvuelosdisponibles(direccion, origen, destino, fechaSalida, fechaRegreso);
            frmA.lblpasajeros.Text = txtpasajeros.Text;
            frmA.Show();
        }

        private void cmbdireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbdireccion.SelectedItem.ToString())
            {
                case "Ida y Vuelta":
                    dtpida.Enabled = true;
                    dtpvuelta.Enabled = true;
                    break;
                case "Ida":
                    dtpida.Enabled = true;
                    dtpvuelta.Enabled = false;
                    dtpvuelta.Checked = false;
                    break;
                default:
                    dtpida.Enabled = true;
                    dtpvuelta.Enabled = true;
                    break;
            }
        }
    }
}
