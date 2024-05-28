using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace skyedge.clases
{
    class Cconexion
    {
        // Se define la ruta de la base de datos
        public static string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JUAN MANUEL CARDENAS\OneDrive\Documentos\POB\skyedge\skyedge\dbskyedge.mdf;Integrated Security=True;Connect Timeout=30";

        // Definir una variable para cargar la base de datos
        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        // Método para abrir la base de datos
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        // Método para cerrar la base de datos
        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}

