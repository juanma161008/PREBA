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
        public static string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Daniel_Henao\Documents\dbskyedge.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection Conexion = new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public void CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
        }
    }
}

