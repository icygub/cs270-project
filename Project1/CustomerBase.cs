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
                //returns true
                return customers.Remove(customer);
            } else {
                return false;
            }
        }

        public bool editCustomer(int id, int newId, string newName) {
            Customer customer = findCustomer(id);

            //no customers in customerBase
            if (customers.Count == 0) {
                return false;
            }
            //customer to edit does not exists
            else if (customer == null) {
                return false;
            }
            //cannot edit because newId value already exists
            else if (searchForDuplicateId(newId)) {
                return false;
            }
            //blank name not allowed
            else if (newName == "") {
                return false;
            }
            else {
                customer.Id = newId;
                customer.Name = newName;
                return true;
            }         
        }

        private bool searchForDuplicateId(int id) {
            foreach (Customer c in customers) {
                if(c.Id == id) {
                    //duplicate exists
                    return true;
                }
            }
            //no duplicates exist
            return false;
        }

        public int getListSize() {
            return customers.Count;
        }
    }
}