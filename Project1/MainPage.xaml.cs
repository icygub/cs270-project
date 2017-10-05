using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Project1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private CustomerBase customerBase;

        public MainPage()
        {
            this.InitializeComponent();
            this.customerBase = new CustomerBase();
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e) {
            Button button = (Button)sender;
            string customerName = customer_name_box_.Text;
            int customerID = 0;
            bool customerAdded;
            try {
                customerID = int.Parse(customer_id_box_.Text);
                customerAdded = customerBase.addCustomer(new Customer(customerName, customerID));
            } catch{
                error_block_.Text = "Invalid ID input. Customer not added.";
            }
            error_block_.Text = customerBase.getListSize().ToString();
        }
    }
}
