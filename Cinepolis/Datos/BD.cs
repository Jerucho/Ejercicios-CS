using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Cinepolis.Datos
{
    internal class BD
    {
        private static string serverQuery = "Server=localhost;Database=cinepolis;User=root;Password=0800jeremias";

        public static DbConnection getConnection()
        {
            MySqlConnection con = null;
            try
            {

                con = new MySqlConnection(BD.serverQuery);
                con.Open();
                return con;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
            
            
        }
    }

}

