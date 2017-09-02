using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedEasy.DAC
{
    public static class MedEasyConnection
    {
        static string connectionString = @"Data Source=NLCCU042\SQLEXPRESS;Initial Catalog=MedEasy;Integrated Security=False;User Id=sa;Password=123456;";
        //static string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\POC\MedEasy\App_Data\MedEasyServer.mdf;Integrated Security=True";

        public static DbCommand Command(DbConnection connection, string cmdText)
        {
            return new SqlCommand(cmdText, (SqlConnection)connection);
        }

        public static DbConnection NewConnection
        {
            get
            {
                DbConnection connection = null;
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    connection.Close();
                    throw;
                }

                return connection;
            }
        }

       
    }
}
