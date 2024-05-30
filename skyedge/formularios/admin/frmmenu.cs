using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skyedge.formularios
{
    public partial class frmmenu : Form
    {
        public Form activeform = null;
        public frmmenu()
        {
            InitializeComponent();
            disenopersona1();
        }
        private void disenopersona1()
        {
            panelcliente.Visible = false;
            panelempleado.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelcliente.Visible == true) panelcliente.Visible = false;
            if (panelempleado.Visible == false) panelempleado.Visible = false;
        }

        private void mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void abrirpanel(Form frmhijo)
        {
            if (activeform != null) activeform.Close();
            activeform = frmhijo;
            frmhijo.TopLevel = false;
            frmhijo.FormBorderStyle = FormBorderStyle.None;
            frmhijo.Dock = DockStyle.Fill;
            panelcentral.Controls.Add(frmhijo);
            frmhijo.BringToFront();
            frmhijo.Show();
        }
        private void panelcentral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelcliente);
        }

        private void btnempleados_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelempleado);
        }

        private void btnmodificacion_Click(object sender, EventArgs e)
        {
            abrirpanel(new frmmodificareserva());
            ocultarsubmenu();
        }

        private void btnnomina_Click(object sender, EventArgs e)
        {
            abrirpanel(new frmnomina());
            ocultarsubmenu();
        }

        private void btnvuelo_Click(object sender, EventArgs e)
        {
            abrirpanel(new frmvueloida());
            ocultarsubmenu();
        }

        private void btnempleado_Click(object sender, EventArgs e)
        {
            abrirpanel(new frmempleado());
            ocultarsubmenu();
        }
    }
}
