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

namespace Project1 {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CustomerPage : Page {
        private CustomerBase customerBase;

        public CustomerPage() {
            this.InitializeComponent();
            this.customerBase = new CustomerBase();
        }

        private void GridView_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e) {
            string customerName = customer_name_box_.Text;
            int customerID = 0;
            bool customerAdded;
            try {
                customerID = int.Parse(customer_id_box_.Text);
                customerAdded = customerBase.addCustomer(new Customer(customerName, customerID));
            }
            catch {
                error_block_.Text = "Invalid ID input. Customer not added.";
            }
            error_block_.Text = customerBase.getListSize().ToString();
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e) {
            int id;
            Customer customer;
            //making sure user enters an int
            try {
                id = int.Parse(delete_customer_by_id_box_.Text);
            }
            catch {
                delete_customer_result_block_.Text = "ID input is not an int";
                return;
            }

            customer = customerBase.findCustomer(id);
            //will be false if customer ID does not exist
            if (customer != null) {
                string name = customer.Name;
                customerBase.deleteCustomer(id);
                delete_customer_result_block_.Text = "Customer [" + name + "] [" + id + "] has been deleted";
            }
            else {
                delete_customer_result_block_.Text = "Customer does not exist.";
            }
        }

        private void FindCustomer_Click(object sender, RoutedEventArgs e) {
            int searchID;
            Customer foundCustomer;
            TextBlock text_block = found_customer_block_; //displays results. Created text_block to avoid repetition
            try {
                searchID = int.Parse(find_customer_by_id_box_.Text);
            }
            catch {
                text_block.Text = "ID input is not an int";
                return;
            }

            foundCustomer = customerBase.findCustomer(searchID);
            if (foundCustomer != null) {
                text_block.Text = "NAME: [" + foundCustomer.Name + "] ID: [" + foundCustomer.Id + "]";
            }
            else {
                text_block.Text = "Customer not found";
            }
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e) {
            int oldId;
            int newId;
            string newName = new_name_box_.Text;
            TextBox idTextBox = old_id_box_;
            TextBox newIdTextBox = new_id_box_;
            TextBlock textBlock = edit_block_;
            if (idTextBox.Text == "") {
                textBlock.Text = "Initial ID required!";
                return;
            }
            if (textIsConvertibleToInt(idTextBox, textBlock) && textIsConvertibleToInt(newIdTextBox, textBlock)) {
                oldId = int.Parse(idTextBox.Text);
                newId = int.Parse(newIdTextBox.Text);
                if (customerBase.editCustomer(oldId, newId, newName)) {
                    textBlock.Text = "Success!";
                }
                else {
                    textBlock.Text = "Failure.";
                }
            }
        }

        private bool textIsConvertibleToInt(TextBox textBox, TextBlock textBlock) {
            try {
                int.Parse(textBox.Text);
                return true;
            }
            catch {
                textBlock.Text = "ID input is not an int.";
                return false;
            }
        }

        private void btn_back__Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}