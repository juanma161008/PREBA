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
    public partial class frmempleado : Form
    {
        Cconexion cn;//variable conexion
        SqlCommand cmd;//para traer los comandos de sql 
        SqlDataAdapter da;//se necesita para las consultas 
        DataTable dt;
        int contador, i, boton;
        public frmempleado()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblEmpleados", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);// llena dt con consultas cmd 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            i--;
            if (i == -1)
            {
                MessageBox.Show("Primer registro");
                i = 0;
            }
            llenar(dt, i);
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            i++;
            if (i == contador)
            {
                MessageBox.Show("Ultimo registro");
                i--;
            }
            llenar(dt, i);
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {

            i = contador - 1;
            llenar(dt, i);
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            boton = 1;
            habilita();
            limpiar();
            txtcedula.Focus();
            btnguardar.Visible = true;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
            txtcedula.Enabled = true;
            txtcedula.Focus();
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
            habilita();
            txtcedula.Enabled = true;
            btnguardar.Enabled = true;
            txtcedula.Focus();
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtcedula.Enabled = true;
            txtcedula.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblEmpleado values('" + txtcedula.Text + "','" + txtnombre.Text + "','" + txtapellido.Text + "','" + txtemail.Text + "','" + txtdireccion.Text + "','" + txtcargo.Text + "','" + txtsalario + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("empleado guardado");
            }
            if (boton == 3)
            {
                cmd = new SqlCommand("update  tblempleado set cedula='" + txtcedula.Text + "',nombre='" + txtnombre.Text + "',apellido='" + txtapellido.Text + "',email='" + txtemail.Text + "',direccion='" + txtdireccion.Text + "',cargo='" + txtsalario.Text + "' where cedula='" + txtcedula.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("empleado modificado ");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmempleado_Load(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }

        private void txtcedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblEmpleado where id_Personal='" + txtcedula.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (boton == 1)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El empleado ya existe");
                    llenar(dt, i);
                }
            }
            if (boton == 2 || boton == 3)
            {
                if (dt.Rows.Count > 0)
                {
                    llenar(dt, i);
                }
                else
                {
                    MessageBox.Show("El empleado no existe");
                }

            }
            if (boton == 4)
            {
                if (dt.Rows.Count > 0)
                {
                    llenar(dt, 0);
                    var result = MessageBox.Show("Realmente desea borrarlo?", "Mensaje de alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) { }
                    {
                        SqlCommand comando = new SqlCommand("delete from tblempleado where cedula='" + txtcedula.Text + "'", cn.AbrirConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("empleado retirado de la empresa ");

                    }
                }
            }
        }

        void llenar(DataTable dt, int i)
        {
            txtcedula.Text = dt.Rows[i][0].ToString();
            txtnombre.Text = dt.Rows[i][1].ToString();
            txtapellido.Text = dt.Rows[i][2].ToString();
            txtemail.Text = dt.Rows[i][5].ToString();
            txtdireccion.Text = dt.Rows[i][6].ToString();
            txtcargo.Text = dt.Rows[i][7].ToString();
            txtsalario.Text = dt.Rows[i][8].ToString();
            contador = dt.Rows.Count;
        }
        void limpiar()
        {
            txtcedula.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtemail.Clear();
            txtdireccion.Clear();
            txtcargo.Clear();
            txtsalario.Clear();
           
        }

       

        void habilita()
        {
            txtcedula.Enabled = true;
            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtemail.Enabled = true;
            txtdireccion.Enabled = true;
            txtcargo.Enabled = true;
            txtsalario.Enabled = true;

        }
        void deshabilita()
        {
            txtcedula.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtemail.Enabled = false;
            txtdireccion.Enabled = false;
            txtcargo.Enabled = false;
            txtsalario.Enabled = false;
        }

    }
}
