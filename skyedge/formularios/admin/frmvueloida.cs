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
    public partial class frmvueloida : Form
    {
        Cconexion cn;//variable conexion
        SqlCommand cmd;//para traer los comandos de sql 
        SqlDataAdapter da;//se necesita para las consultas 
        DataTable dt;
        int contador, i, boton;

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
            txtidvueloida.Focus();
            btnguardar.Visible = true;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
            txtidvueloida.Enabled = true;
            txtidvueloida.Focus();
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
            habilita();
            txtidvueloida.Enabled = true;
            btnguardar.Enabled = true;
            txtidvueloida.Focus();
        }

        private void txtidvueloida_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblVuelosida where id_vuelo_ida='" + txtidvueloida.Text + "'", cn.AbrirConexion());
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
                        SqlCommand comando = new SqlCommand("delete from tblvuelosida where id_vuelo_ida ='" + txtidvueloida.Text + "'", cn.AbrirConexion());
                        comando.ExecuteNonQuery();
                        MessageBox.Show("vuelo retirado de la base");

                    }
                }
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblVuelosida values('" + txtidvueloida.Text + "','" + txtorigenida.Text + "','" + txtdestinoida.Text + "','" + txtfechaida.Text + "','" + txthorasalidaida.Text + "','" + txthorallegadaida.Text + "','" + txtprecioida.Text + "','" + txtempleadosida.Text + "','" + txtidaeronaveida.Text + "','" + txtcapacidadida.Text + "')", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("vuelo guardado");
            }
            if (boton == 3)
            {
                cmd = new SqlCommand("update  tblVuelosida set id_vuelo_ida ='" + txtidvueloida.Text + "',origen ='" + txtorigenida.Text + "',destino='" + txtdestinoida.Text + "',fecha='" + txtfechaida.Text + "',hora_salida='" + txthorasalidaida.Text + "',hora_llegada='" + txthorallegadaida.Text + "',precio'" + txtprecioida.Text + "',empleado'" + txtempleadosida.Text + "',id_aeronave'" + txtidaeronaveida.Text + "',capacidad'" + txtcapacidadida.Text + "'where id_vuelo'" + txtidvueloida.Text + "'", cn.AbrirConexion());
                cmd.ExecuteNonQuery();
                MessageBox.Show("vuelo modificado ");
            }
        }

        public frmvueloida()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblVuelosida", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);// llena dt con consultas cmd 
        }

        private void frmvueloida_Load(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }
        void llenar(DataTable dt, int i)
        {
            if (dt.Rows.Count > 0)
            {
                txtidvueloida.Text = dt.Rows[i][0].ToString();
                txtorigenida.Text = dt.Rows[i][1].ToString();
                txtdestinoida.Text = dt.Rows[i][2].ToString();
                txtfechaida.Text = dt.Rows[i][3].ToString();
                txthorasalidaida.Text = dt.Rows[i][4].ToString();
                txthorallegadaida.Text = dt.Rows[i][5].ToString();
                txtprecioida.Text = dt.Rows[i][6].ToString();
                txtempleadosida.Text = dt.Rows[i][7].ToString();
                txtidaeronaveida.Text = dt.Rows[i][8].ToString();
                txtcapacidadida.Text = dt.Rows[i][9].ToString();
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
            txtidvueloida.Clear();
            txtorigenida.Clear();
            txtdestinoida.Clear();
            txtfechaida.Clear();
            txthorasalidaida.Clear();
            txthorallegadaida.Clear();
            txtprecioida.Clear();
            txtempleadosida.Clear();
            txtidaeronaveida.Clear();
            txtcapacidadida.Clear();
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
            txtidvueloida.Enabled = true;
            txtidvueloida.Focus();
        }

        void habilita()
        {
            txtidvueloida.Enabled = true;
            txtorigenida.Enabled = true;
            txtdestinoida.Enabled = true;
            txtfechaida.Enabled = true;
            txthorasalidaida.Enabled = true;
            txthorallegadaida.Enabled = true;
            txtprecioida.Enabled = true;
            txtempleadosida.Enabled = true;
            txtidaeronaveida.Enabled = true;
            txtcapacidadida.Enabled = true;



        }
        void deshabilita()
        {
            txtidvueloida.Enabled = false;
            txtorigenida.Enabled = false;
            txtdestinoida.Enabled = false;
            txtfechaida.Enabled = false;
            txthorasalidaida.Enabled = false;
            txthorallegadaida.Enabled = false;
            txtprecioida.Enabled = false;
            txtempleadosida.Enabled = false;
            txtidaeronaveida.Enabled = false;
            txtcapacidadida.Enabled = false;
        }
    }
}
