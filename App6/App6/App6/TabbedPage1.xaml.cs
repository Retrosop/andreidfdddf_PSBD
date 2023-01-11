using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{  

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class TabbedPage1 : TabbedPage
    {
        public int col = 1;
        public TabbedPage1()
        {
            InitializeComponent();
        }

        private void blud_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void borih_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (borih.IsChecked == true)
            {
                borih_stac.IsVisible = true;
                bor_bor.IsVisible = true;
                bld2.Text = "борьш";
            }
            else
            {
                bor_bor.IsVisible = false;
                borih_stac.IsVisible = false;
            }
        }
        private void cof_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (cof.IsChecked == true)
            {
                cof_stac.IsVisible = true;
                cofe_cofe.IsVisible = true;
                bld4.Text = "кофе";
            }
            else
            {
                cof_stac.IsVisible = false;
                cofe_cofe.IsVisible = false;
            }
        }
        private void compot_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (compot.IsChecked == true)
            {
                compot_stac.IsVisible = true;
                compot_compot.IsVisible = true;
                bld5.Text = "компот";
            }
            else
            {
                compot_stac.IsVisible = false;
                compot_compot.IsVisible = false;
            }
        }

        private void asa_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
           
            if (asa.IsChecked == true)
            {
                hi_stac.IsVisible = true;
                hi_hi.IsVisible = true;
                bld1.Text = "щи";
            }
            else
            {
                hi_stac.IsVisible = false;
                hi_hi.IsVisible = false;
            }
        }
        private void patato_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (patato.IsChecked == true)
            {
                patato_stac.IsVisible = true;
                patato_patato.IsVisible = true;
                bld3.Text = "картошка";
            }
            else
            {
                patato_stac.IsVisible = false;
                patato_patato.IsVisible = false;
            }
        }
        private void plus_Clicked(object sender, EventArgs e)
        {
            string str = int_hi.Text;
            col = Convert.ToInt32(str);
            col = col + 1;
            int_hi.Text = col.ToString();
            bld1_sum.Text = col.ToString();


        }

        private void minus_Clicked(object sender, EventArgs e)
        {
            string str = int_hi.Text;
            col = Convert.ToInt32(str);
            col = col - 1;
            int_hi.Text = col.ToString();
            if (col <= 0)
            {
                col = 1;
                int_hi.Text = col.ToString();
                hi_stac.IsVisible = false;
            }
            bld1_sum.Text = col.ToString();
        }

        
        private void borin_plus_Clicked(object sender, EventArgs e)
        {
            string str = int_borih.Text;
            col = Convert.ToInt32(str);
            col = col + 1;
            int_borih.Text = col.ToString();
            bld2_sum.Text = col.ToString();
        }

        private void borin_minus_Clicked(object sender, EventArgs e)
        {
            string str = int_borih.Text;
            col = Convert.ToInt32(str);
            col = col - 1;
            int_borih.Text = col.ToString();
            if (col <= 0)
            {
                col = 1;
                int_borih.Text = col.ToString();
                borih_stac.IsVisible = false;
            }
            bld2_sum.Text = col.ToString();
        }

        private void plus_patato_Clicked(object sender, EventArgs e)
        {
            string str = int_patato.Text;
            col = Convert.ToInt32(str);
            col = col + 1;
            int_patato.Text = col.ToString();
            bld3_sum.Text = col.ToString();
        }

        private void minus_patato_Clicked(object sender, EventArgs e)
        {

            string str = int_patato.Text;
            col = Convert.ToInt32(str);
            col = col - 1;
            int_patato.Text = col.ToString();
            if (col <= 0)
            {
                col = 1;
                int_patato.Text = col.ToString();
                borih_stac.IsVisible = false;
            }
            bld3_sum.Text = col.ToString();
        }

        private void plus_compot_Clicked(object sender, EventArgs e)
        {
            string str = int_compot.Text;
            col = Convert.ToInt32(str);
            col = col + 1;
            int_compot.Text = col.ToString();
            bld5_sum.Text = col.ToString();
        }

        private void minus_compot_Clicked(object sender, EventArgs e)
        {
            string str = int_compot.Text;
            col = Convert.ToInt32(str);
            col = col - 1;
            int_compot.Text = col.ToString();
            if (col <= 0)
            {
                col = 1;
                int_compot.Text = col.ToString();
                borih_stac.IsVisible = false;
            }
            bld5_sum.Text = col.ToString();
        }

        private void plus_cof_Clicked(object sender, EventArgs e)
        {
            string str = int_cof.Text;
            col = Convert.ToInt32(str);
            col = col + 1;
            int_cof.Text = col.ToString();
            bld4_sum.Text = col.ToString();
        }

        private void minus_cof_Clicked(object sender, EventArgs e)
        {
            string str = int_cof.Text;
            col = Convert.ToInt32(str);
            col = col - 1;
            int_cof.Text = col.ToString();
            if (col <= 0)
            {
                col = 1;
                int_cof.Text = col.ToString();
                borih_stac.IsVisible = false;
            }
            bld4_sum.Text = col.ToString();
        }
    }
}