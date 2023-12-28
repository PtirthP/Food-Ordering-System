using System;
using System.CodeDom.Compiler;
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
    /// Interaction logic for HoagiesAndSandwiches.xaml
    /// </summary>
    public partial class HoagiesAndSandwiches : Window
    {

        List<Item> items = new List<Item>();

        public HoagiesAndSandwiches()
        {
            InitializeComponent();
        }

        public HoagiesAndSandwiches(List<Item> items)
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

        private void btnPepperoni_Click(object sender, RoutedEventArgs e)
        {

            Item Pepperoni = new Item();
            Pepperoni.item = "Peperroni Hoagie";
            Pepperoni.price = 5.99;

            items.Add(Pepperoni);

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

        private void btnTurkey_Click(object sender, RoutedEventArgs e)
        {
            Item Turkey = new Item();
            Turkey.item = "Turkey Hoagie";
            Turkey.price = 5.99;

            items.Add(Turkey);

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

        private void btnVeggie_Click(object sender, RoutedEventArgs e)
        {
            Item Veggie = new Item();
            Veggie.item = "Veggie Hoagie";
            Veggie.price = 4.99;

            items.Add(Veggie);

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

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout(items);
            co.Show();
            this.Close();
        }
    }
}
