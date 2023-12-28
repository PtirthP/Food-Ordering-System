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
using System.Xml.Linq;

namespace Lab_Wawa_App_TirthPatel
{
    /// <summary>
    /// Interaction logic for Checkout.xaml
    /// </summary>
    /// 

    
    public partial class Checkout : Window
    {

        List<Item> items = new List<Item>();
        List<Item> receipt = new List<Item>();

        public Checkout()
        {
            InitializeComponent();
        }

        public Checkout(List<Item> items)
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

        private void btnComplete_Click(object sender, RoutedEventArgs e)
        {
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

            Random rnd = new Random();
            int num = rnd.Next(100, 1000);

            MessageBox.Show("-----------Your Print Order-----------\n\n" + "----------Order no. " + num + "-------\n" + finalItem + "\nPlease pay for the order at the register");
            MessageBox.Show("The application will be closed");
            Application.Current.Shutdown();

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("All your items will be canceled");
            txtOrder.Clear();
            MessageBox.Show("The application will be closed");
            Application.Current.Shutdown();
        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow(items);
            mw.Show();
            this.Close();
        }
    }
}
