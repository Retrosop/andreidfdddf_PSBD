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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private SqlConnection sqlConnection = null;
        public Page1()
        {
            InitializeComponent();

            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

            sqlConnection.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand($"INSERT INTO [zac] (nameHsop, nameTovara, data, car) VALUES ('{TextBox1.Text}', '{TextBox2.Text}', '{TextBox3.Text}', '{TextBox4.Text}')", sqlConnection);
            //MessageBox.Show(command.ExecuteNonQuery().ToString());
            command.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page0());

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            SqlCommand command2 = new SqlCommand($"DELETE FROM [zac] WHERE id = {TextBox5.Text}", sqlConnection);
            command2.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page0());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            SqlCommand command2 = new SqlCommand($"UPDATE [zac] SET nameHsop = '{TextBox6.Text}', nameTovara = '{TextBox7.Text}', data = '{TextBox8.Text}', car = '{TextBox9.Text}' WHERE id= '{TextBox10.Text}'", sqlConnection);
            command2.ExecuteNonQuery().ToString();
            NavigationService.Navigate(new Page0());
        }

        
    }
}
