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
        //List<string> strings = new List<string>();

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
            foreach (Customer c in customers) {
                if (c.Id == id) {
                    return c;
                }
            }
            return null;
        }

        public bool deleteCustomer(int id) {
            //check if the customer exists
            Customer customer = findCustomer(id);
            if(customer != null) {
                return customers.Remove(customer);
            } else {
                return false;
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