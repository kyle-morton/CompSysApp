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
    class ItemDAO : DAO
    {

      //  private MySql.Data.MySqlClient.MySqlConnection conn;
       // private const String myConnectionString = "server=localhost;uid=root;" +
       // "pwd=root;database=compsysschema;";




        public ItemDAO()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = getConnString();
                conn.Open();
                Console.WriteLine(conn);

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        /*
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
        */

        public Item getItem(int id)
        {
            Console.WriteLine("Getting Item at: " + id);
            return new Item();
        }

        public List<Item> getItems()
        {
            List<Item> items = new List<Item>();

            try
            {
                //1: create query
                String query = "SELECT * FROM item";

                //2: create command
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //3:Create reader and execute
                MySqlDataReader dataReader = cmd.ExecuteReader();

                Item tempItem;

                //Cycle thru each user 
                while (dataReader.Read())
                {
                    //create and set values for each user
                    tempItem = new Item();
                    Console.WriteLine(dataReader["id"].GetType());
                    tempItem.setId((UInt32)dataReader["id"]);
                    tempItem.setName((String)dataReader["name"]);
                    tempItem.setPrice((decimal)dataReader["price"]);
                    tempItem.setUnitOfMeasure((String)dataReader["unit_of_measure"]);
                    tempItem.setStandProfMargin((decimal)dataReader["standard_profit_margin"]);

                    //add user to list
                    items.Add(tempItem);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Getting All Items...");

            return items;
        }

    }
}
