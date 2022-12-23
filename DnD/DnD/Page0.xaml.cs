using System;
using System.Collections.Generic;
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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;




namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для Page0.xaml
    /// </summary>
    public partial class Page0 : Page
    {
        private SqlConnection sqlConnection = null;
        public Page0()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            sqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM zac", sqlConnection);
            SqlCommandBuilder cd = new SqlCommandBuilder(sqlData);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "zac");
            da.ItemsSource = dataSet.Tables[0].DefaultView;

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page1());
        }
    }
}
