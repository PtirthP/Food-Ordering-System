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
    /// Interaction logic for Sides.xaml
    /// </summary>
    public partial class Sides : Window
    {
        public Sides()
        {
            InitializeComponent();
        }


        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            

        }

        

        private void cbFrenchFries_Checked(object sender, RoutedEventArgs e)
        {
            spFrenchFries.Background = Brushes.SkyBlue;
        }

        private void cbFrenchFries_Unchecked(object sender, RoutedEventArgs e)
        {
            spFrenchFries.Background = Brushes.Transparent;
        }

        

        private void cbMacAndCheese_Checked(object sender, RoutedEventArgs e)
        {
            spMacAndCheese.Background = Brushes.SkyBlue;
        }

        private void cbMacAndCheese_Unchecked(object sender, RoutedEventArgs e)
        {
            spMacAndCheese.Background = Brushes.Transparent;
        }

        

        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout();
            co.Show();
            this.Close();
        }
    }
}
