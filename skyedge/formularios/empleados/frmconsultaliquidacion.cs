using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using skyedge.clases;
using Word = Microsoft.Office.Interop.Word;

namespace skyedge.formularios.empleados
{
    public partial class frmconsultaliquidacion : Form
    {
        Cconexion cn;

        public frmconsultaliquidacion()
        {
            InitializeComponent();
            cn = new Cconexion();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcedula.Text, out int idPersonal))
            {
                MessageBox.Show("Por favor ingresa un número de cédula válido.");
                return;
            }

            if (comboBoxmes.SelectedItem == null)
            {
                MessageBox.Show("Por favor selecciona un mes.");
                return;
            }

            string mes = comboBoxmes.SelectedItem.ToString();
            string fecha = mes + "%"; 

            try
            {
                string query = "SELECT * FROM dbo.tblNomina WHERE Id_personal = @IdPersonal AND Fecha LIKE @Fecha";

                using (SqlCommand cmd = new SqlCommand(query, cn.AbrirConexion()))
                {
                    cmd.Parameters.AddWithValue("@IdPersonal", idPersonal);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    System.Data.DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        Word.Application wordApp = new Word.Application();
                        wordApp.Visible = true;

                        Document doc = wordApp.Documents.Add();

                        Paragraph title = doc.Content.Paragraphs.Add();
                        title.Range.Text = "NOMINA EMPRESA SKYEDGE";
                        title.Range.Font.Bold = 1;
                        title.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                        title.Range.InsertParagraphAfter();

                        Paragraph para = doc.Content.Paragraphs.Add();
                        para.Range.InsertParagraphAfter();

                        Table table = doc.Tables.Add(para.Range, 4, 4);
                        table.Borders.Enable = 1;

                        WdColor colorFondo = (WdColor)System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(0xC0, 0xE6, 0xF5));

                        table.Cell(1, 1).Range.Text = "Nombre";
                        table.Cell(1, 2).Range.Text = "Salario Básico por Hora";
                        table.Cell(1, 3).Range.Text = "Horas Trabajadas";
                        table.Cell(1, 4).Range.Text = "Salario Bruto";
                        table.Cell(3, 1).Range.Text = "Auxilio de Transporte";
                        table.Cell(3, 2).Range.Text = "Horas Extras";
                        table.Cell(3, 3).Range.Text = "Valor Extras";
                        table.Cell(3, 4).Range.Text = "Fecha";

                        for (int i = 1; i <= 4; i++)
                        {
                            table.Cell(1, i).Range.Shading.BackgroundPatternColor = colorFondo;
                            table.Cell(1, i).Range.Bold = 1;
                            table.Cell(1, i).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            table.Cell(3, i).Range.Shading.BackgroundPatternColor = colorFondo;
                            table.Cell(3, i).Range.Bold = 1;
                            table.Cell(3, i).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                            table.Cell(1, i).Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            table.Cell(1, i).Borders.OutsideLineWidth = WdLineWidth.wdLineWidth075pt;
                            table.Cell(3, i).Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                            table.Cell(3, i).Borders.OutsideLineWidth = WdLineWidth.wdLineWidth075pt;
                        }

                        int rowIndex = 2;
                        foreach (DataRow row in dt.Rows)
                        {
                            table.Cell(rowIndex, 1).Range.Text = row["Nombre"].ToString();
                            table.Cell(rowIndex, 2).Range.Text = row["Salario_basico_hora"].ToString();
                            table.Cell(rowIndex, 3).Range.Text = row["Horas_trabajadas"].ToString();
                            table.Cell(rowIndex, 4).Range.Text = row["Salario_bruto"].ToString();

                            for (int i = 1; i <= 4; i++)
                            {
                                table.Cell(rowIndex, i).Range.Bold = 0;
                            }

                            rowIndex++;
                        }

                        int rowIndex3 = 4;
                        foreach (DataRow row in dt.Rows)
                        {
                            table.Cell(rowIndex3, 1).Range.Text = row["auxilio_de_transporte"].ToString();
                            table.Cell(rowIndex3, 2).Range.Text = row["Horas_extras"].ToString();
                            table.Cell(rowIndex3, 3).Range.Text = row["Valor_extras"].ToString();
                            table.Cell(rowIndex3, 4).Range.Text = row["Fecha"].ToString();

                            for (int i = 1; i <= 4; i++)
                            {
                                table.Cell(rowIndex3, i).Range.Bold = 0;
                            }

                            rowIndex3++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron datos para la cédula y el mes especificados.", "Consulta de Liquidación");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta: " + ex.Message);
            }
        }
    }
}
