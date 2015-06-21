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
    class OrderDAO : DAO
    {

//        private MySql.Data.MySqlClient.MySqlConnection conn;
      //  private const String myConnectionString = "server=localhost;uid=root;" +
       // "pwd=root;database=compsysschema;";

        public OrderDAO()
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

        public bool placeOrder (Order order, List<Item> items)
        {

            bool success = true;

            try
            {
                if (order != null && items != null)
                {
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO compsysschema.order (customer_id, total_price) VALUES "
                        + "( ?customerId, ?total_price)";
                    command.Parameters.AddWithValue("?customerId", order.getCustomerId());
                    command.Parameters.AddWithValue("?total_price", order.getTotalPrice());
                    Console.WriteLine(command.CommandText);
                    command.ExecuteNonQuery();
                    long id = command.LastInsertedId;

                    for (int i = 0; i < items.Count; i++)
                    {
                        insertOrderItem(items[i], id);
                    }
                }
                else
                {
                    success = false;
                }
            } catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw e;
            }

            return success;
        }

        public void insertOrderItem (Item item, long orderId)
        {
            try
            {
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO compsysschema.order_item (item_id, order_id) VALUES "
                    + "( ?item_id, ?order_id)";
                command.Parameters.AddWithValue("?item_id", item.getId());
                command.Parameters.AddWithValue("?order_id", new Decimal(orderId));
                Console.WriteLine(command.CommandText);
                command.ExecuteNonQuery();
            } catch (MySqlException e)
            {
                Console.WriteLine(e);
                throw e;
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



    }
}
