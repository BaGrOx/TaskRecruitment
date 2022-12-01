using System.Data.SqlClient;
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
