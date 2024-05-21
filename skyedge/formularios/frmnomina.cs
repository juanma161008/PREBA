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
    public partial class frmnomina : Form
    {
        Cconexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        int contador, i, boton;
        public frmnomina()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblUsuario", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);
        }
        void llenar(DataTable dt, int i)
        {
            txtcedula.Text = dt.Rows[i][0].ToString();
            txtnombre.Text = dt.Rows[i][1].ToString();

            contador = dt.Rows.Count;
        }
        private void txtcedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblUsuario where IdUsuario = '" + txtcedula.Text + "'",
               cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                llenar(dt, i);
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            double salarioBaseHora = Convert.ToDouble(txtsalariobasico.Text);
            double horasTrabajadas = Convert.ToDouble(txthoras.Text);
            double salud = Convert.ToDouble(txtsalud.Text);
            double pension = Convert.ToDouble(txtpension.Text);
            double retefuente = Convert.ToDouble(txtretefuente.Text);
            double auxilioTransporte = Convert.ToDouble(txtretefuente.Text);
            double horasExtras = Convert.ToDouble(txthorasextras.Text);
            double valorExtras = Convert.ToDouble(txtvalorextras.Text);

            double salarioBruto = salarioBaseHora * horasTrabajadas;
            double totalDevengado = salarioBruto + auxilioTransporte + (horasExtras * valorExtras);

            totalDevengado -= salud + pension + retefuente;

            txtdevengado.Text = totalDevengado.ToString("N2");
        }

      

      
       

    }
}
