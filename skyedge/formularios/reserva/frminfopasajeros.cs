using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using skyedge.clases;

namespace skyedge.formularios
{
    public partial class frminfopasajeros : Form
    {
        private List<DataRow> _filasIdaSeleccionadas;
        private List<DataRow> _filasVueltaSeleccionadas;

        public frminfopasajeros()
        {
            InitializeComponent();
        }

        public frminfopasajeros(List<DataRow> filasIdaSeleccionadas, List<DataRow> filasVueltaSeleccionadas)
        {
            InitializeComponent();
            _filasIdaSeleccionadas = filasIdaSeleccionadas;
            _filasVueltaSeleccionadas = filasVueltaSeleccionadas;
            LlenarDataGridViewReservaIda(_filasIdaSeleccionadas);
            LlenarDataGridViewReservaVuelta(_filasVueltaSeleccionadas);
        }

        private void LlenarDataGridViewReservaIda(List<DataRow> filasIdaSeleccionadas)
        {
            foreach (DataRow fila in filasIdaSeleccionadas)
            {
                dgvida.Rows.Add(
                    fila["origen_ida"].ToString(),
                    fila["destino_ida"].ToString(),
                    Convert.ToDateTime(fila["fecha_ida"]).ToString("dd/MM/yyyy"),
                    fila["hora_salida_ida"].ToString(),
                    fila["hora_llegada_ida"].ToString(),
                    Convert.ToDecimal(fila["precio_ida"]).ToString("0.00")
                );
            }
        }

        private void LlenarDataGridViewReservaVuelta(List<DataRow> filasVueltaSeleccionadas)
        {
            foreach (DataRow fila in filasVueltaSeleccionadas)
            {
                dgvvuelta.Rows.Add(
                    fila["origen_regreso"].ToString(),
                    fila["destino_regreso"].ToString(),
                    Convert.ToDateTime(fila["fecha_regreso"]).ToString("dd/MM/yyyy"),
                    fila["hora_salida_regreso"].ToString(),
                    fila["hora_llegada_regreso"].ToString(),
                    Convert.ToDecimal(fila["precio_regreso"]).ToString("0.00")
                );
            }
        }

        private void frminfopasajeros_Load(object sender, EventArgs e)
        {
             
        }
    }
}