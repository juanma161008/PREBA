using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyedge.formularios.empleados
{
    public partial class frmmenuempleado : Form
    {
        public frmmenuempleado()
        {
            InitializeComponent();
        }

        private void frmmenuempleado_Load(object sender, EventArgs e)
        {

        }

        private void btnconsulta_Click(object sender, EventArgs e)
        {
            frmconsultaliquidacion consultaLiquidacionForm = new frmconsultaliquidacion();
            consultaLiquidacionForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
