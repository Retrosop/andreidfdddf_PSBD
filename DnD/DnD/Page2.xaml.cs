using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SD = System.Data;

namespace DnD
{
    public partial class Page2 : Page
    {
        private SqlConnection sqlConnection = null;
        public Page2()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            sqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM sclad", sqlConnection);
            SqlCommandBuilder cd = new SqlCommandBuilder(sqlData);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "sclad");
            da.ItemsSource = dataSet.Tables[0].DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page5());
        }
    }
}
