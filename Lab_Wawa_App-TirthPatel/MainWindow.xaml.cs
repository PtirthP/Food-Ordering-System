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

namespace Lab_Wawa_App_TirthPatel
{
    public class Item
    {
        public string item { get; set; }
        public double price { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        List<Item> items = new List<Item>();

        
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(List<Item> items)
        {
            InitializeComponent();

            this.items = items;

            string finalItem = "";
            double foodPrice = 0;

            foreach (var i in items)
            {
                finalItem += "\n" + i.item + " $" + i.price.ToString();
                foodPrice += i.price;
            }

            finalItem += "\n------------" + "\n Total Price : $" + foodPrice.ToString();

            txtOrder.Text = finalItem;
        }

        private void btnHoagies_Click(object sender, RoutedEventArgs e)
        {

            HoagiesAndSandwiches hs = new HoagiesAndSandwiches(items);
            hs.Show();
            this.Close();
        }

        

        private void btnBeverages_Click(object sender, RoutedEventArgs e)
        {
            Beverages bg = new Beverages(items);
            bg.Show();
            this.Close();
        }

        private void btnSides_Click(object sender, RoutedEventArgs e)
        {
            Soups sdsp = new Soups(items);
            sdsp.Show();
            this.Close();
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout(items);
            co.Show();
            this.Close();
        }

        
    }
}
