using skyedge.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace skyedge.formularios
{
    public partial class frmmodificareserva : Form
    {
        Cconexion cn; // variable conexión
        SqlCommand cmd; // para traer los comandos de SQL
        SqlDataAdapter da; // se necesita para las consultas
        DataTable dt;
        int contador, i, boton;

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Daniel_Henao\\Documents\\dbskyedge.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=True";

        public frmmodificareserva()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0;
            boton = 0;
            cmd = new SqlCommand("select * from tblreserva", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt); // llena dt con consultas cmd
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
                MessageBox.Show("Último registro");
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
            btnguardar.Visible = true;
        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            boton = 2;
            limpiar();
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            boton = 3;
            limpiar();
            habilita();
            btnguardar.Enabled = true;
        }

        private void btnretiro_Click(object sender, EventArgs e)
        {
            boton = 4;
            limpiar();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (boton == 1)
            {
                cmd = new SqlCommand("insert into tblreserva (codigo_reserva, fecha_salida, origen, destino, nombre, cedula) values(@codigo_reserva, @fecha_salida, @origen, @destino, @nombre, @cedula)", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@codigo_reserva", txtidreserva.Text);
                cmd.Parameters.AddWithValue("@fecha_salida", txtfechavuelo.Text);
                cmd.Parameters.AddWithValue("@origen", txtorigen.Text);
                cmd.Parameters.AddWithValue("@destino", txtdestino.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva guardada");
            }
            if (boton == 3)
            {
                cmd = new SqlCommand("update tblreserva set fecha_salida=@fecha_salida, origen=@origen, destino=@destino, nombre=@nombre, cedula=@cedula where codigo_reserva=@codigo_reserva", cn.AbrirConexion());
                cmd.Parameters.AddWithValue("@codigo_reserva", txtidreserva.Text);
                cmd.Parameters.AddWithValue("@fecha_salida", txtfechavuelo.Text);
                cmd.Parameters.AddWithValue("@origen", txtorigen.Text);
                cmd.Parameters.AddWithValue("@destino", txtdestino.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva modificada");
            }
        }

        private void frmmodificareserva_Load(object sender, EventArgs e)
        {
            i = 0;
            llenar(dt, i);
        }

        private void txtcedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblreserva where codigo_reserva=@codigo_reserva", cn.AbrirConexion());
            cmd.Parameters.AddWithValue("@codigo_reserva", txtidreserva.Text);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (boton == 1)
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("La reserva ya existe");
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
                    MessageBox.Show("La reserva no existe");
                }
            }
            if (boton == 4)
            {
                if (dt.Rows.Count > 0)
                {
                    llenar(dt, 0);
                    var result = MessageBox.Show("Realmente desea borrarlo?", "Mensaje de alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand comando = new SqlCommand("delete from tblreserva where codigo_reserva=@codigo_reserva", cn.AbrirConexion());
                        comando.Parameters.AddWithValue("@codigo_reserva", txtidreserva.Text);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Reserva eliminada");
                    }
                }
            }
        }

        void llenar(DataTable dt, int i)
        {
            txtidreserva.Text = dt.Rows[i][0].ToString();
            txtfechavuelo.Text = dt.Rows[i][4].ToString();
            txtorigen.Text = dt.Rows[i][1].ToString();
            txtdestino.Text = dt.Rows[i][2].ToString();
 
            contador = dt.Rows.Count;
        }

        void limpiar()
        {
            txtidreserva.Clear();
            txtfechavuelo.Clear();
            txtorigen.Clear();
            txtdestino.Clear();
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void habilita()
        {
            txtidreserva.Enabled = true;
            txtfechavuelo.Enabled = true;
            txtorigen.Enabled = true;
            txtdestino.Enabled = true;

        }

        void deshabilita()
        {
            txtidreserva.Enabled = false;
            txtfechavuelo.Enabled = false;
            txtorigen.Enabled = false;
            txtdestino.Enabled = false;
 
        }
    }

    public class Reserva
    {
        public string ID { get; set; }
        public string FechaVuelo { get; set; }
        public string Clase { get; set; }
        public string Origen { get; set; }
        public string Destino { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
    }
}
