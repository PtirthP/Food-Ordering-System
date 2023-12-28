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
    /// Interaction logic for ColdDrink.xaml
    /// </summary>
    public partial class ColdDrink : Window
    {
        public ColdDrink()
        {
            InitializeComponent();
        }

        List<Item> items = new List<Item>();

        public ColdDrink(List<Item> items)
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


        private void btnAddToOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            Beverages bvg = new Beverages(items);
            bvg.Show();
            this.Close();
        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            Checkout co = new Checkout(items);
            co.Show();
            this.Close();
        }

        private void btnCaramelEspresso_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Caramel Espresso";
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

        private void btnCreamFrozenCappuccino_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Cream Frozen Cappuccino";
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

        private void btnCreamStrawberryCappuccino_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Cream Strawberry Cappuccino";
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
    }
}
