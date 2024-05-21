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
    public partial class frmusuarionuevo : Form
    {
        Cconexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;

       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmusuarionuevo_Load(object sender, EventArgs e)
        {

        }

       

        public frmusuarionuevo()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblUsuario", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("insert into tblUsuario values('" + txtCedula.Text + "','" + txtnombre.Text + "','" + txtapellidos.Text + "','" + txttelefono.Text + "','"+ txtemail.Text + "','"+txtpassword.Text + "', 1)", cn.AbrirConexion());
            cmd.ExecuteNonQuery();
            MessageBox.Show("empleado guardado");

            this.Close();

            frmlogin frmLogin = new frmlogin();
            frmLogin.Show();
        }   

       
    }
}
