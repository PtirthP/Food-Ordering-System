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
    /// Interaction logic for Beverages.xaml
    /// </summary>
    public partial class Beverages : Window
    {

        List<Item> items = new List<Item>();

        public Beverages()
        {
            InitializeComponent();
        }

        public Beverages(List<Item> items)
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

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(items);
            mw.Show();
            this.Close();
        }


        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout(items);
            co.Show();
            this.Close();
        }

        private void btnHotDrink_Click(object sender, RoutedEventArgs e)
        {
            HotDrink hd = new HotDrink(items);
            hd.Show();
            this.Close();
        }

        private void btnColdDrink_Click(object sender, RoutedEventArgs e)
        {
            ColdDrink cd = new ColdDrink(items);
            cd.Show();
            this.Close();
        }
    }
}
