using System.Data.SqlClient;
using System.Windows;

namespace TaskRecruitment
{
    public class ConnectionServerSQL
    {

        public bool ConnectSQL(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Połączenie nie powiodło się");
                return false;
            }

        }
    }
}
