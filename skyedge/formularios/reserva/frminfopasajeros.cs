using Microsoft.Office.Interop.Word;
using skyedge.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Security.Cryptography;

namespace skyedge.formularios
{
    public partial class frminfopasajeros : Form
    {
        public frminfopasajeros()
        {
            InitializeComponent();
        }

        public frminfopasajeros(List<DataGridViewRow> filasIdaSeleccionadas, List<DataGridViewRow> filasVueltaSeleccionadas)
        {
            InitializeComponent();
            LlenarDataGridViewReservaIda(filasIdaSeleccionadas);
            LlenarDataGridViewReservaVuelta(filasVueltaSeleccionadas);
        }

        private void LlenarDataGridViewReservaIda(List<DataGridViewRow> filasIdaSeleccionadas)
        {
            foreach (DataGridViewRow fila in filasIdaSeleccionadas)
            {
                dgvida.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
            }
        }

        private void LlenarDataGridViewReservaVuelta(List<DataGridViewRow> filasVueltaSeleccionadas)
        {
            foreach (DataGridViewRow fila in filasVueltaSeleccionadas)
            {
                dgvvuelta.Rows.Add(fila.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
            }
        }

        private void frminfopasajeros_Load(object sender, EventArgs e)
        {
            // No es necesario llamar a los métodos de llenado aquí ya que se llaman en el constructor.
        }

        private void GuardarDatosEnBD(DataGridView dgv)
        {
            // Establecer la conexión con la base de datos
            Cconexion conexionDB = new Cconexion();
            using (SqlConnection connection = conexionDB.AbrirConexion())
            {
                // Definir la consulta SQL para la inserción
                string query = "INSERT INTO tblPasajero (Cedula, Nombre, Apellido, Telefono, fecha_nacimineto, Direccion) " +
                               "VALUES (@Cedula, @Nombre, @Apellido, @Telefono, @FechaNacimiento, @Direccion)";

                // Crear el comando SQL
                SqlCommand cmd = new SqlCommand(query, connection);

                // Recorrer las filas del DataGridView
                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    // Verificar si la fila no es nueva y está completa
                    if (!fila.IsNewRow && fila.Cells[0].Value != null && fila.Cells[1].Value != null &&
                        fila.Cells[2].Value != null && fila.Cells[3].Value != null && fila.Cells[4].Value != null &&
                        fila.Cells[5].Value != null)
                    {
                        // Agregar parámetros
                        cmd.Parameters.Clear(); // Limpiar parámetros anteriores
                        cmd.Parameters.AddWithValue("@Cedula", fila.Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@Nombre", fila.Cells[1].Value.ToString());
                        cmd.Parameters.AddWithValue("@Apellido", fila.Cells[2].Value.ToString());
                        cmd.Parameters.AddWithValue("@Telefono", fila.Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("@FechaNacimiento", fila.Cells[4].Value.ToString());
                        cmd.Parameters.AddWithValue("@Direccion", fila.Cells[5].Value.ToString());

                        // Ejecutar la consulta
                        cmd.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje de éxito
                MessageBox.Show("Datos guardados en la base de datos.");
            }
        }

        private string ObtenerValorCelda(DataGridViewRow fila, string nombreColumna)
        {
            DataGridViewCell celda = fila.Cells[nombreColumna];
            if (celda != null && celda.Value != null)
            {
                return celda.Value.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            GuardarDatosEnBD(dgvinfopasajeros);
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            object ObjMiss = System.Reflection.Missing.Value;
            Word.Application ObjWord = new Word.Application();
            Word.Document ObjDoc = ObjWord.Documents.Add(ref ObjMiss);
            ObjDoc.Activate();

            string logoPath = @"C:\Users\JUAN MANUEL CARDENAS\source\repos\skyedge1\skyedge\LOGO 1 .png"; // Cambia esta ruta a la ubicación real de tu logo
            

            try
            {
                // Insertar el logo en la parte superior del documento
                ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWord.Selection.InlineShapes.AddPicture(logoPath, ref ObjMiss, ref ObjMiss, ref ObjMiss).Select();
                Word.InlineShape logo = ObjWord.Selection.InlineShapes[1];
                logo.Width = 200; // Ajusta el tamaño del logo
                logo.Height = 200;

                // Salto de línea después del logo
                ObjWord.Selection.TypeParagraph();

                // Título de información de los pasajeros
                ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlueGray;
                ObjWord.Selection.Font.Size = 18;
                ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWord.Selection.TypeText("Información de los Pasajeros");
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.TypeParagraph();

                // Crear tabla para los pasajeros
                CrearTablaDesdeDataGridView(ObjWord, dgvinfopasajeros);

                // Título de información de vuelos de ida
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlueGray;
                ObjWord.Selection.Font.Size = 18;
                ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWord.Selection.TypeText("Vuelos de Ida");
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.TypeParagraph();

                // Crear tabla para vuelos de ida
                CrearTablaDesdeDataGridView(ObjWord, dgvida);

                // Título de información de vuelos de vuelta
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlueGray;
                ObjWord.Selection.Font.Size = 18;
                ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWord.Selection.TypeText("Vuelos de Vuelta");
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.TypeParagraph();

                // Crear tabla para vuelos de vuelta
                CrearTablaDesdeDataGridView(ObjWord, dgvvuelta);

                // Salto de línea antes del mensaje de pagar
                ObjWord.Selection.TypeParagraph();
                ObjWord.Selection.TypeParagraph();

                // Insertar el mensaje "Pagar"
                ObjWord.Selection.Font.Color = Word.WdColor.wdColorBlack;
                ObjWord.Selection.Font.Size = 16;
                ObjWord.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                ObjWord.Selection.TypeText("Pagar");

                 
                ObjWord.Visible = true;
            }
            catch (System.Runtime.InteropServices.COMException ex)
            {
                MessageBox.Show("Error al insertar una imagen. Verifica que las rutas de las imágenes sean correctas.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearTablaDesdeDataGridView(Word.Application ObjWord, DataGridView dgv)
        {
            int rowCount = dgv.Rows.Count;
            int columnCount = dgv.Columns.Count;
            Word.Table table = ObjWord.Selection.Tables.Add(ObjWord.Selection.Range, rowCount + 1, columnCount);
            table.Borders.Enable = 1;

            // Ajustar el ancho de las columnas para hacer la tabla más pequeña
            foreach (Word.Column column in table.Columns)
            {
                column.PreferredWidthType = Word.WdPreferredWidthType.wdPreferredWidthPoints;
                column.PreferredWidth = 60; // Ajusta este valor según sea necesario para reducir el ancho de las columnas
            }

            // Encabezados de columna
            for (int i = 0; i < columnCount; i++)
            {
                table.Cell(1, i + 1).Range.Text = dgv.Columns[i].HeaderText;
                table.Cell(1, i + 1).Range.Bold = 1;
                table.Cell(1, i + 1).Range.Font.Size = 12;
                table.Cell(1, i + 1).Shading.BackgroundPatternColor = Word.WdColor.wdColorGray25;
            }

            // Contenido de las filas
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    if (dgv.Rows[i].Cells[j].Value != null)
                    {
                        table.Cell(i + 2, j + 1).Range.Text = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            // Formato de la tabla
            table.Rows.Alignment = Word.WdRowAlignment.wdAlignRowCenter;
            table.Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            table.Range.Font.Size = 12;
        }

    }
}