using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;
using FirstApplication.Model;

namespace FirstApplication.DAO
{
    class DAO
    {

        public MySql.Data.MySqlClient.MySqlConnection conn;

        public void closeConnection()
        {
            try
            {
                Console.WriteLine("Closing Database Connection...");
                conn.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
