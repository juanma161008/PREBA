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
    public partial class frmlogin : Form
    {
        Cconexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;

        public frmlogin()
        {
            InitializeComponent();

            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblusuario", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkregistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmusuarionuevo nuevoUsuario = new frmusuarionuevo();
            nuevoUsuario.Show();
            this.Hide();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Boolean est = false;

            cn = new Cconexion();
            cmd = new SqlCommand("select * from tblusuario where idUsuario= '" + txtemail.Text + "' and contrasena ='" + txtpassword.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                contador++;

                txtemail.Focus();

                if (contador == 2)
                {
                    MessageBox.Show("solo te queda una oportunidad!!!");

                }
                if (contador == 3)
                {
                    MessageBox.Show("Fallaste!!!");

                    cmd = new SqlCommand("UPDATE tblusuario SET estado ='" + est + "' WHERE idusuario ='" + txtemail.Text + "'", cn.AbrirConexion());

                    cmd.ExecuteNonQuery();
                    this.Close();



                }
            }
            else
            {
                frmvuelo frm = new frmvuelo();
                timer1.Stop();
                frm.Show();
                this.Hide();

            }

            txtpassword.Clear();
            txtemail.Clear();
        }
    }
}
