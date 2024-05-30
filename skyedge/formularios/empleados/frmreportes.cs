using Microsoft.Office.Interop.Word;
using skyedge.clases;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace skyedge.formularios.empleados
{
    public partial class frmreportes : Form
    {
        Cconexion cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        System.Data.DataTable dt;
        int contador, i, boton;

        public frmreportes()
        {
            InitializeComponent();
            cn = new Cconexion();
            i = 0; boton = 0;
            cmd = new SqlCommand("select * from tblEmpleados", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt); // llena dt con consultas cmd 
        }

        private void frmreportes_Load(object sender, EventArgs e)
        {
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcedula.Text, out int idPersonal))
            {
                MessageBox.Show("Por favor, ingresa un número de cédula válido.");
                return;
            }

            try
            {
                string query = "SELECT * FROM dbo.tblEmpleados WHERE Id_personal = @IdPersonal";

                using (cmd = new SqlCommand(query, cn.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@IdPersonal", idPersonal);

                    da = new SqlDataAdapter(cmd);
                    dt = new System.Data.DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        GenerarCartaLaboral(dt.Rows[0]);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para la cédula especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerarCartaLaboral(DataRow empleado)
        {
            try
            {
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = true;
                Document doc = wordApp.Documents.Add();

                Paragraph title = doc.Content.Paragraphs.Add();
                title.Range.Text = "CARTA LABORAL EMPRESA SKYEDGE";
                title.Range.Font.Bold = 1;
                title.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                title.Range.InsertParagraphAfter();
                title.Range.InsertParagraphAfter(); 
                title.Range.InsertParagraphAfter(); 

                Paragraph datePara = doc.Content.Paragraphs.Add();
                datePara.Range.Text = "Fecha: ";
                datePara.Range.Font.Bold = 0;
                datePara.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify;
                datePara.Range.InsertParagraphAfter();


                Paragraph onlydate = doc.Content.Paragraphs.Add();
                onlydate.Range.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
                onlydate.Range.Font.Bold = 1;
                onlydate.Range.InsertParagraphAfter();
                onlydate.Range.InsertParagraphAfter();
                onlydate.Range.InsertParagraphAfter();
                onlydate.Range.InsertParagraphAfter();
                onlydate.Range.InsertParagraphAfter();



                Paragraph mainPara = doc.Content.Paragraphs.Add();
                mainPara.Range.Text = "Estimado/a ";
                mainPara.Range.Font.Bold = 0;
                mainPara.Range.InsertAfter(empleado["Nombre"].ToString());
                mainPara.Range.InsertAfter(",");
                mainPara.Range.InsertParagraphAfter();
                mainPara.Range.InsertAfter("Por medio de la presente, certificamos que el(la) Sr.(a) ");
                mainPara.Range.InsertAfter(empleado["Nombre"].ToString());
                mainPara.Range.InsertAfter(" ");
                mainPara.Range.InsertAfter(empleado["Apellido"].ToString());
                mainPara.Range.InsertAfter(", identificado con cédula número ");
                mainPara.Range.InsertAfter(empleado["Id_Personal"].ToString());
                mainPara.Range.InsertAfter(" se encuentra laborando en nuestra empresa SkyEdge ");
                mainPara.Range.InsertAfter("en el cargo de ");
                mainPara.Range.InsertAfter(empleado["Cargo"].ToString());
                mainPara.Range.InsertAfter(" con un salario de $");
                mainPara.Range.InsertAfter(empleado["Salario"].ToString());
                mainPara.Range.InsertAfter(" mensuales.");
                mainPara.Range.Font.Bold = 0;
                mainPara.Range.InsertParagraphAfter();
                mainPara.Range.InsertParagraphAfter();
                mainPara.Range.InsertParagraphAfter(); 
                mainPara.Range.InsertParagraphAfter(); 
                mainPara.Range.InsertParagraphAfter();
                mainPara.Range.InsertParagraphAfter();


                Paragraph regardsPara = doc.Content.Paragraphs.Add();
                regardsPara.Range.Text = "Atentamente,";
                regardsPara.Range.Font.Bold = 0;
                regardsPara.Range.InsertParagraphAfter();

                Paragraph signaturePara = doc.Content.Paragraphs.Add();
                signaturePara.Range.Text = "SKYEDGE";
                signaturePara.Range.Font.Bold = 1;
                signaturePara.Range.InsertParagraphAfter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar la carta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void txtcedula_Leave(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from tblEmpleados where id_Personal='" + txtcedula.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new System.Data.DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                llenar(dt, i);
            }
        }

        void llenar(System.Data.DataTable dt, int i)
        {
            txtcedula.Text = dt.Rows[i][0].ToString();
            txtnombre.Text = dt.Rows[i][1].ToString();
            txtapellidos.Text = dt.Rows[i][2].ToString();
            contador = dt.Rows.Count;
        }
    }
}
