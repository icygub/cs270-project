﻿using System;
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

        List<System.Object> customers = new List<System.Object>();
        //List<string> strings = new List<string>();

        public bool addCustomer(Object customer) {
            //blank or null name is not allowed
            if (string.IsNullOrEmpty(customer.Name)) {
                return false;
            }
        
            foreach (Object c in customers) {
                if (customer.Id == c.Id) {
                    //duplicate found
                    return false;
                }
            }

            customers.Add(new Object(customer.Name, customer.Id));
            return true;
        }

        public Object findCustomer(int id) {
            foreach (Object c in customers) {
                if (c.Id == id) {
                    return c;
                }
            }
            return null;
        }

        public bool deleteCustomer(int id) {
            //check if the customer exists
            Object customer = findCustomer(id);
            if(customer != null) {
                //returns true
                return customers.Remove(customer);
            } else {
                return false;
            }
        }

        public bool editCustomer(int id, int newId, string newName) {
            Object customer = findCustomer(id);

            //no objList in customerBase
            if (customers.Count == 0) {
                return false;
            }
            //customer to edit does not exist
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
            foreach (Object c in customers) {
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