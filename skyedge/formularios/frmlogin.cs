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
            cmd = new SqlCommand("select * from tblUsuario", cn.AbrirConexion());
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
            // Extract email domain
            string email = txtemail.Text.Trim();
            string domain = email.Split('@')[1];

            // Validate email and password against the database
            cn = new Cconexion();
            cmd = new SqlCommand("SELECT * FROM tblUsuario WHERE email = @email AND contrasena = @password", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text.Trim());

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Check if login credentials are valid (assuming dt.Rows.Count > 0 indicates valid credentials)
                if (dt.Rows.Count > 0)
                {
                    // Check domain conditions
                    if (domain.Equals("skyedgecompany.com"))
                    {
                        // Redirect to frmnomina for skyedgecompany.com domain
                        frmnomina nominaForm = new frmnomina();
                        timer1.Stop();
                        nominaForm.Show();
                        this.Hide();
                    }
                    else if (domain.Equals("adminskyedgecompany.com"))
                    {
                        // Redirect to frmmenu for adminskyedgecompany.com domain
                        frmmenu menuForm = new frmmenu();
                        timer1.Stop();
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Redirect to frmreserva for other domains
                        frmreserva reservaForm = new frmreserva();
                        timer1.Stop();
                        reservaForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    // Invalid credentials - Increase counter and display message
                    contador++;

                    txtemail.Focus();

                    if (contador == 2)
                    {
                        MessageBox.Show("Solo te queda una oportunidad!!!");
                    }
                    if (contador == 3)
                    {
                        MessageBox.Show("Fallaste!!!");

                        // Update user status to inactive (replace with your logic)
                        cmd.CommandText = "UPDATE tblusuario SET estado = @est WHERE email = @email";
                        cmd.Parameters.AddWithValue("@est", false); // Assuming false indicates inactive
                        cmd.ExecuteNonQuery();

                        this.Close();
                    }
                }
            }

            // Clear text boxes after processing
            txtpassword.Clear();
            txtemail.Clear();
        }

    }
}
