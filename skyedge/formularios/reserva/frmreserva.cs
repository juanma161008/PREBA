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
        }
        void cargarciudad()
        {
            SqlCommand cmd = new SqlCommand("select nombre_ciudad from tblciudad",cn.AbrirConexion());
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
            
            frmvuelosdisponibles frmA = new frmvuelosdisponibles();
            frmA.lblpasajeros.Text = txtpasajeros.Text;
            frmA.lblfida.Text = cmborigen.Text;
            frmA.lblregreso.Text = cmbdestino.Text;
            frmA.lblFecha.Text = dtpida.Text;
            frmA.Show();
        }
    

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmreserva_Load_1(object sender, EventArgs e)
        {

        }

        private void cmbpasajeros_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
