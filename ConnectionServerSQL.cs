using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskRecruitment
{
    public  class ConnectionServerSQL
    {
        private SqlConnection? connection;

        public bool ConnectSQL(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;

            }
            catch (SqlException)
            {
                MessageBox.Show("Połączenie nie powiodło się");
                return false;
            }
            
        }
    }
}
