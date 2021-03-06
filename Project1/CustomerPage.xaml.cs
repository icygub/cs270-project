﻿using System;
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
            string name = customer_name_box_.Text;
            
            bool customerAdded;
            try {
                int id = int.Parse(customer_id_box_.Text);
                string street = customer_street_box_.Text;
                string city = customer_city_box_.Text;
                string state = customer_state_box_.Text;
                int zipCode = int.Parse(customer_zip_box_.Text);
                string email = customer_email_box_.Text;
                customerAdded = customerBase.Add(new Customer(name, id, new Address(street,city,state,zipCode),email));
            }
            catch {
                error_block_.Text = "Invalid input. BaseObject not added.";
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

            customer = (Customer) customerBase.Find(id);
            //will be false if customer ID does not exist
            if (customer != null) {
                string name = customer.Name;
                customerBase.Delete(id);
                delete_customer_result_block_.Text = "BaseObject [" + name + "] [" + id + "] has been deleted";
            }
            else {
                delete_customer_result_block_.Text = "BaseObject does not exist.";
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

            foundCustomer = (Customer) customerBase.Find(searchID);
            if (foundCustomer != null) {
                text_block.Text = "NAME: [" + foundCustomer.Name + "] ID: [" + foundCustomer.PrimaryKey + "]";
            }
            else {
                text_block.Text = "BaseObject not found";
            }
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e) {
            int oldId = 0;
            int newId;
            string newName = new_name_box_.Text;          
            TextBox oldIdTextBox = old_id_box_;
            TextBox newIdTextBox = new_id_box_;
            TextBox newNameBox = new_name_box_;
            TextBlock textBlock = edit_block_;
            textBlock.Text = "";

            if (textIsConvertibleToInt(oldIdTextBox)) {
                oldId = int.Parse(oldIdTextBox.Text);
            } else {
                return;
            }

            
            if(customerBase.EditName(oldId, newName)) {
                textBlock.Text += "Name changed. ";
            }

            if (textIsConvertibleToInt(newIdTextBox)) {
                newId = int.Parse(newIdTextBox.Text);
                if (customerBase.Edit(oldId, newId)) {
                    textBlock.Text += "ID changed";
                }
            }
        }

        private bool textIsConvertibleToInt(TextBox textBox) {
            try {
                int.Parse(textBox.Text);
                return true;
            }
            catch {
                //textBlock.Text = "ID input is not an int.";
                return false;
            }
        }

        private void btn_back__Click(object sender, RoutedEventArgs e) {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}