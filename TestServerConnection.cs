using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskRecruitment
{
    public class TestServerConnection
    { 


        public bool IsServerConnected(string connectionString)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Połączenie udane");
                    return true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Połączenie nie udało się");    
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

    }
}
