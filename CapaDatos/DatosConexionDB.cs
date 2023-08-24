using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private MySqlConnection conexion;
        private string server = "localhost";
        private string database = "inmobiliaria_itsc";
        private string user = "root";
        private string passowrd = "root";

        private string cadenaConexion;

        public Conexion()
        {
            cadenaConexion = "Database=" + database + "; Data Source=" + server + "; User Id= " + user + "; Password=" + passowrd;

        }

        public MySqlConnection getConexion()
        {
            if (conexion == null)
            {
                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();
            }

            return conexion;
        }

    }
}
