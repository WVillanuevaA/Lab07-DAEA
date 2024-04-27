using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CustomerData
    {
        public List<Customer> GetCustom()
        {
            string connectionString = "Data Source=LAB1504-30\\SQLEXPRESS;Initial Catalog=master;User ID=Eduardo;Password=123456;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("USP_ListCustomers", connection);
                command.CommandType = CommandType.StoredProcedure;



                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    int customerId = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string address = reader.GetString(2);
                    string phone = reader.GetString(3);
                    bool active = reader.GetBoolean(4);

                    reader.Close();
                }



                return null;

            }
        }
    }
}
