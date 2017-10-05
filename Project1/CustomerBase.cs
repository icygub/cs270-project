using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * John Diaz and Gibran
 * CS 270
 * */
namespace Project1 {
    public class CustomerBase {

        List<Object> customers = new List<Object>();
        List<string> strings = new List<string>();

        public void addString(string s) {
            strings.Add(s);
        }

        public int getStringsSize() {
            return strings.Count;
        }
        public bool addCustomer(Customer customer) {
            //blank or null name is not allowed
        
            if (string.IsNullOrEmpty(customer.Name)) {
                return false;
            }

            //check for duplicate customer id, which is not allowed
            //THERE IS A PROBLEM SOMEWHERE IN THIS LOOP
            foreach (Customer c in customers) {
                if (customer.Id == c.Id) {
                    //duplicate found
                    return false;
                }
            }

            customers.Add(new Customer(customer.Name, customer.Id));
            return true;
        }

        public Customer findCustomer(int id) {
            //unit test is failing right here
            
            foreach (Customer c in customers) {
                if (c.Id == id) {
                    return c;
                }
            }
            System.Diagnostics.Debug.WriteLine("Customer " + id + " not found");
            return null;
        }

        public void deleteCustomer(Customer customer) {
            bool customerFound = false;
            //check if the customer exists
            foreach (Customer c in customers) {
                if (c.Id == customer.Id) {
                    customers.Remove(customer);
                    System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was found and removed.");
                    customerFound = true;
                    break;
                }
            }
            if (!customerFound) {
                System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was NOT found and NOT removed.");
            }
        }

        public Customer editCustomer(Customer customer, String nameEdits) {
            if (customers.Count == 0) {
                System.Diagnostics.Debug.WriteLine("There are no customers.");
                return null;
            }
            //customer found
            else if (findCustomer(customer.Id) == null) {
                customer.Name = nameEdits;
                return customer;
            }
            else {
                System.Diagnostics.Debug.WriteLine("Customer " + customer.Id + " was NOT found and NOT edited.");
                return null;
            }
        }

        public int getListSize() {
            return customers.Count;
        }
    }
}