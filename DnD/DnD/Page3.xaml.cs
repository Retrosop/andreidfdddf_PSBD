using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
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

namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        private SqlConnection sqlConnection = null;
        public Page3()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Page4());
        }

        private void Grid_Loaded_1(object sender, RoutedEventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            sqlConnection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("SELECT * FROM tov", sqlConnection);
            SqlCommandBuilder cd = new SqlCommandBuilder(sqlData);
            DataSet dataSet = new DataSet();
            sqlData.Fill(dataSet, "tov");
            da.ItemsSource = dataSet.Tables[0].DefaultView;
        }
    }
}
