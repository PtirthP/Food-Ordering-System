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
using System.Windows.Shapes;

namespace Lab_Wawa_App_TirthPatel
{
    /// <summary>
    /// Interaction logic for Toppings.xaml
    /// </summary>
    public partial class Toppings : Window
    {
        public Toppings()
        {
            InitializeComponent();
        }


        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            HoagiesAndSandwiches hs = new HoagiesAndSandwiches();
            hs.Show();
            this.Close();
        }

        private void cbCorn_Checked(object sender, RoutedEventArgs e)
        {
            spCorn.Background = Brushes.SkyBlue;
        }

        private void cbCorn_Unchecked(object sender, RoutedEventArgs e)
        {
            spCorn.Background = Brushes.Transparent;
        }

        private void cbCucumber_Checked(object sender, RoutedEventArgs e)
        {
            spCucumber.Background = Brushes.SkyBlue;
        }

        private void cbCucumber_Unchecked(object sender, RoutedEventArgs e)
        {
            spCucumber.Background = Brushes.Transparent;
        }

        private void cbJalapeno_Checked(object sender, RoutedEventArgs e)
        {
            spJalapeno.Background = Brushes.SkyBlue;
        }

        private void cbJalapeno_Unchecked(object sender, RoutedEventArgs e)
        {
            spJalapeno.Background = Brushes.Transparent;
        }

        private void cbLettuce_Checked(object sender, RoutedEventArgs e)
        {
            spLettuce.Background = Brushes.SkyBlue;
        }

        private void cbLettuce_Unchecked(object sender, RoutedEventArgs e)
        {
            spLettuce.Background = Brushes.Transparent;
        }

        private void cbOnion_Checked(object sender, RoutedEventArgs e)
        {
            spOnion.Background = Brushes.SkyBlue;
        }

        private void cbOnion_Unchecked(object sender, RoutedEventArgs e)
        {
            spOnion.Background = Brushes.Transparent;
        }

        private void cbTomatoes_Checked(object sender, RoutedEventArgs e)
        {
            spTomatoes.Background = Brushes.SkyBlue;
        }

        private void cbTomatoes_Unchecked(object sender, RoutedEventArgs e)
        {
            spTomatoes.Background = Brushes.Transparent;
        }

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout();
            co.Show();
            this.Close();
        }
    }

}
