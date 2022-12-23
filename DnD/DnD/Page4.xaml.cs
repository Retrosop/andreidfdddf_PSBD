using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Configuration;
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

namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {
        private SqlConnection sqlConnection = null;
        public Page4()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            sqlConnection.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [tov] (namTovar, colTovarVypacovce, srockGodnosti) VALUES ('{TextBox1.Text}', '{TextBox2.Text}', '{TextBox3.Text}')", sqlConnection);
            //MessageBox.Show(command2.ExecuteNonQuery().ToString());
            command.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page3());

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            SqlCommand command2 = new SqlCommand($"DELETE FROM [tov] WHERE id = {TextBox5.Text}", sqlConnection);
            command2.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page3());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SqlCommand command2 = new SqlCommand($"UPDATE [tov] SET namTovar = '{TextBox6.Text}', colTovarVypacovce = '{TextBox7.Text}', srockGodnosti = '{TextBox8.Text}' WHERE id= '{TextBox10.Text}'", sqlConnection);
            command2.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page3());
        }


        private void TextBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
  
}
