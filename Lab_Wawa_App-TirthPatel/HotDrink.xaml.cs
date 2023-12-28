﻿using System;
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
    /// Interaction logic for HotDrink.xaml
    /// </summary>
    public partial class HotDrink : Window
    {
        public HotDrink()
        {
            InitializeComponent();
        }

        List<Item> items = new List<Item>();

        public HotDrink(List<Item> items)
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

        private void btnHotChocolate_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Hot Chocolate";
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

        private void btnHotCoffee_Click(object sender, RoutedEventArgs e)
        {
            Item Pepperoni = new Item();
            Pepperoni.item = "Hot Coffee";
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
    }
}
