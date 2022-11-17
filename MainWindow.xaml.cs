using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace TaskRecruitment
{

    public partial class MainWindow : Window
    {
        #region Fields
        string login;
        string password;
        string connectionString;

        #endregion Fields

        public MainWindow()
        {
            InitializeComponent();
        }

        #region ButtonMethods
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            TextBoxSelection(sender, e);

            var connectSQL = new ConnectionServerSQL();

            if (connectSQL.ConnectSQL(connectionString))
            {
                btnLoad.IsEnabled = true;
            }
        }

      
        private void btnTestConnect_Click(object sender, RoutedEventArgs e)
        {
            TextBoxSelection(sender, e);

            var testConnection = new TestServerConnection();

            if (!testConnection.IsServerConnected(connectionString))
            {
                txtLogin.Text = String.Empty;
                txtPassword.Password = String.Empty;
            }
        }


        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {

            var strSQL = (@" SELECT COLUMN_NAME, DATA_TYPE
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_CATALOG = 'DevData'
                            AND DATA_TYPE = 'int'");

            var con = new SqlConnection(connectionString);

            var cmd = new SqlCommand(strSQL, con);

            var sqlDataAdapter = new SqlDataAdapter(cmd);
            var dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            DataView dataView = dt.DefaultView;
            dataGrid.ItemsSource = dataView;
        }
        #endregion ButtonMethods

        #region EventMethods

        private void txtLogin_SelectionChanged(object sender, RoutedEventArgs e)
        {
            login = txtLogin.Text;
        }

        public void TextBoxSelection(object sender, RoutedEventArgs e)
        {
            txtLogin_SelectionChanged(sender, e);
            txtPassword_PasswordChanged(sender, e);
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=DevData;User ID=" + login + ";Password=" + password;
        }
        

        private void txtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            password = txtPassword.Password;
        }
        #endregion EventMethods
    }
}
