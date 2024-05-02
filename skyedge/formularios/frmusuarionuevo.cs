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
        public frmusuarionuevo()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text.Trim();
            string apellidos = txtapellidos.Text.Trim();
            string telefono = txttelefono.Text.Trim();
            string email = textemail.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellidos) ||
                string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Completa Todos los Campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cconexion cn = new Cconexion();

            string sqlInsert = "INSERT INTO tblUsuario (nombre, apellidos, telefono, email, contrasena) VALUES (@nombre, @apellidos, @telefono, @email, @contrasena)";

            using (SqlConnection connection = cn.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                {

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellidos", apellidos);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@email", email);

                    cmd.Parameters.AddWithValue("@contrasena", password);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuario Guardado con Exito!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmlogin loginForm = new frmlogin();

                        loginForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Un Error Ocurrio Guardando la Informacion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

       
    }
}
