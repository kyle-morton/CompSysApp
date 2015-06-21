using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MySql.Data.MySqlClient;

namespace FirstApplication.DAO
{
    class UserDAO : DAO
    {

      //  private MySql.Data.MySqlClient.MySqlConnection conn;
      //  private const String myConnectionString = "server=localhost;uid=root;" +
     //   "pwd=root;database=compsysschema;";




        public UserDAO ()
        {
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = getConnString();
                conn.Open();
                Console.WriteLine(conn);

            } catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        /*
        public void closeConnection ()
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

        public User getUser(int id)
        {
            Console.WriteLine("Getting User at: " + id);
            return new User();
        }

        public List<User> getUsers()
        {

            List<User> users = new List<User>();

            try
            {
                //1: create query
                String query = "SELECT * FROM user";

                //2: create command
                MySqlCommand cmd = new MySqlCommand(query, conn);

                //3:Create reader and execute
                MySqlDataReader dataReader = cmd.ExecuteReader();

                User tempUser;

                //Cycle thru each user 
                while (dataReader.Read())
                {
                    //create and set values for each user
                    tempUser = new User();
                    Console.WriteLine(dataReader["id"].GetType());
                    tempUser.setId((UInt32)dataReader["id"]);
                    tempUser.setName((String)dataReader["name"]);
                    tempUser.setAddress((String)dataReader["address"]);
                    tempUser.setPhoneNumber((String)dataReader["phone_number"]);
                    //Console.WriteLine(dataReader["standard_profit_margin"].GetType());

                    //add user to list
                    users.Add(tempUser);
                }
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("Getting All Users...");
   
            return users;
        }
         
    }
}
