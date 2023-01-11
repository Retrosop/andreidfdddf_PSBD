using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void blud_SelectedIndexChanged(object sender, EventArgs e)
        {
            van.IsVisible = false;
            if (blud.SelectedIndex == 0)
            {
                van.IsVisible = false;
            }
        }

        private void asa_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
           
        }
    }
}