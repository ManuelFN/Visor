using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Visor
{
    class Conexion
    {
        private static string getConnectionString()
        {

            string host = "server=localhost;";
            string port = "port=3306;";
            string db = "Database=visor;";
            string user = "user=root;";
            string pass = "password=";

            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user, pass);

            return conString;

        }

        public static MySqlConnection con = new MySqlConnection(getConnectionString());
        public static MySqlCommand cmd = default(MySqlCommand);
        public static string sql = string.Empty;

    }
}
