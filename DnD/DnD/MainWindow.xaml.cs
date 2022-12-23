using System;
using System.Collections.Generic;
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
using MySql.Data.MySqlClient;

namespace DnD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Page> list;
        int index;
        public MainWindow()
        {
            InitializeComponent();
            this.list = new List<Page>();
            index = 0;

            list.Add(new Page0());
            list.Add(new Page3());
            list.Add(new Page2());
            MyFrame.Content = list[index];
        }

        public SqlConnection conect;

        private void Button_Click(object sender, RoutedEventArgs e)
        {

           
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[index = 0];
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[index = 1];


        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = list[index = 2];
        }
    }
}
