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
    /// Interaction logic for Soups.xaml
    /// </summary>
    public partial class Soups : Window
    {

        List<Item> items = new List<Item>();

        public Soups()
        {
            InitializeComponent();
        }

        public Soups(List<Item> items)
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
            
        }

        private void btnChickenCornChowder_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Chicken Corn Chowder";
            Pepperoni.price = 4.99;

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

        private void btnChickenTortilla_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Chicken Tortilla";
            Pepperoni.price = 4.99;

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

        private void btnMacandCheese_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Mac and Cheese";
            Pepperoni.price = 3.99;

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

        private void btnFrenchFries_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "French Fries";
            Pepperoni.price = 2.99;

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

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout(items);
            co.Show();
            this.Close();
        }
    }
}
