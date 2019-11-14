using System;
using System.Data.SqlClient;
//using static System.Data.Common.DbConnection;
using static System.Console;
//using System.Data;

namespace ReadingFromDatabase
{
    class Program
    {
        static private string GetConnectionString()
        {
            return "Data Source=DESKTOP-EPR1T48;Initial Catalog=TSQLV4;" + "Integrated Security=true;"; 
        }

        private static void OpenSQLConnection()
        {
            string connectionString = GetConnectionString();

            try
            {
                using (SqlConnection con = new SqlConnection())
                {
                    con.ConnectionString = connectionString;
                    con.Open();
                    WriteLine($"State: {con.State}");
                    WriteLine($"ConnectionString: {con.ConnectionString}");

                }
            }
            catch (Exception sex)
            {
                WriteLine("Exception code:" + sex);
            }
        }

        /*private static void CreateCommand(string querryString, string connectionString)
        {
            using (SqlConnection conneciton = new SqlConnection(connectionString))
            {

            }
        }*/





        static void Main(string[] args)
        {
            OpenSQLConnection();
            ReadKey();
        }
    }
}
