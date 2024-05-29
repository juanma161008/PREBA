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

namespace skyedge.formularios.admin
{
    public partial class frmvueloregreso : Form
    {
        Cconexion cn;//variable conexion
        SqlCommand cmd;//para traer los comandos de sql 
        SqlDataAdapter da;//se necesita para las consultas 
        DataTable dt;
        int contador, i, boton;
        public frmvueloregreso()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblVuelosRegreso", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);// llena dt con consultas cmd 
        }

        private void frmvueloregreso_Load(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }
        void llenar(DataTable dt, int i)
        {
            if (dt.Rows.Count > 0)
            {
                txtidvueloregreso.Text = dt.Rows[i]["id_vuelo_regreso"].ToString();
                txtorigenregreso.Text = dt.Rows[i]["origen_regreso"].ToString();
                txtdestinoregreso.Text = dt.Rows[i]["destino_regreso"].ToString();
                txtfecharegreso.Text = dt.Rows[i]["fecha_regreso"].ToString();
                txthorasalidaregreso.Text = dt.Rows[i]["hora_salida_regreso"].ToString();
                txthorallegadaregreso.Text = dt.Rows[i]["hora_llegada_regreso"].ToString();
                txtprecioregreso.Text = dt.Rows[i]["precio_regreso"].ToString();
                txtempleadosregreso.Text = dt.Rows[i]["empleado_regreso"].ToString();
                txtidaeronaveregreso.Text = dt.Rows[i]["tipo_aeronave"].ToString();  
                txtcapacidadregreso.Text = dt.Rows[i]["capacidad"].ToString(); 
                contador = dt.Rows.Count;
            }
            else
            {
                // Manejar el caso en que no hay filas en el DataTable
                MessageBox.Show("No hay datos disponibles.");
            }
        }
        void limpiar()
        {
            txtidvueloregreso.Clear();
            txtorigenregreso.Clear();
            txtdestinoregreso.Clear();
            txtfecharegreso.Clear();
            txthorasalidaregreso.Clear();
            txthorallegadaregreso.Clear();
            txtprecioregreso.Clear();
            txtempleadosregreso.Clear();
            txtidaeronaveregreso.Clear();
            txtcapacidadregreso.Clear();
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblVuelosRegreso values('" + txtidvueloregreso.Text + "','" + txtorigenregreso.Text + "','" + txtdestinoregreso.Text + "','" + txtfecharegreso.Text + "','" + txthorasalidaregreso.Text + "','" + txthorallegadaregreso.Text + "','" + txtprecioregreso.Text + "','" + txtempleadosregreso.Text + "','" + txtidaeronaveregreso.Text + "','" + txtcapacidadregreso.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("vuelo guardado");
            }
            if (boton == 3)
            {
                cmd = new SqlCommand("update  tblVuelosida set id_vuelo_ida ='" + txtidvueloregreso.Text + "',origen ='" + txtorigenregreso.Text + "',destino='" + txtdestinoregreso.Text + "',fecha='" + txtfecharegreso.Text + "',hora_salida='" + txthorasalidaregreso.Text + "',hora_llegada='" + txthorallegadaregreso.Text + "',precio'" + txtprecioregreso.Text + "',empleado'" + txtempleadosregreso.Text + "',id_aeronave'" + txtidaeronaveregreso.Text + "',capacidad'" + txtcapacidadregreso.Text + "'where id_vuelo'" + txtidvueloregreso.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("vuelo modificado ");
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            boton = 1;
            habilita();
            limpiar();
            txtidvueloregreso.Focus();
            btnguardar.Visible = true;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
            txtidvueloregreso.Enabled = true;
            txtidvueloregreso.Focus();
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
            habilita();
            txtidvueloregreso.Enabled = true;
            btnguardar.Enabled = true;
            txtidvueloregreso.Focus();
        }

        private void txtidvueloregreso_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblVuelosRegreso where id_vuelo_regreso='" + txtidvueloregreso.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
            if (boton == 1)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("El vuelo ya existe");
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
                    MessageBox.Show("El vuelo no existe");
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
                        SqlCommand comando = new SqlCommand("delete from tblVuelosRegreso where id_vuelo_regreso ='" + txtidvueloregreso.Text + "'", cn.AbrirConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("vuelo retirado de la base");

                    }
                }
            }
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtidvueloregreso.Enabled = true;
            txtidvueloregreso.Focus();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        void habilita()
        {
            txtidvueloregreso.Enabled = true;
            txtorigenregreso.Enabled = true;
            txtdestinoregreso.Enabled = true;
            txtfecharegreso.Enabled = true;
            txthorasalidaregreso.Enabled = true;
            txthorallegadaregreso.Enabled = true;
            txtprecioregreso.Enabled = true;
            txtempleadosregreso.Enabled = true;
            txtidaeronaveregreso.Enabled = true;
            txtcapacidadregreso.Enabled = true;



        }
        void deshabilita()
        {
            txtidvueloregreso.Enabled = false;
            txtorigenregreso.Enabled = false;
            txtdestinoregreso.Enabled = false;
            txtfecharegreso.Enabled = false;
            txthorasalidaregreso.Enabled = false;
            txthorallegadaregreso.Enabled = false;
            txtprecioregreso.Enabled = false;
            txtempleadosregreso.Enabled = false;
            txtidaeronaveregreso.Enabled = false;
            txtcapacidadregreso.Enabled = false;
        }
    }
}