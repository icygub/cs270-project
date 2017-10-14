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
    public class CustomerBase : Database {

        private List<BaseObject> customers;

        public CustomerBase() : base() {
            customers = base.ObjectList;
        }

        public override bool add(BaseObject customer) {
            //blank or null name is not allowed
            if (string.IsNullOrEmpty(((Customer)customer).Name)) {
                return false;
            }

            return base.add(customer as Customer);
        }

        //public override bool add(Customer customer) {
        //    //blank or null name is not allowed
        //    //if (string.IsNullOrEmpty(customer.Name)) {
        //    //    return false;
        //    //}

        //    foreach (BaseObject c in customers) {
        //        if (customer.PrimaryKey == c.PrimaryKey) {
        //            //duplicate found
        //            return false;
        //        }
        //    }

        //    base.add(customer);
        //    return true;
        //}

        public Customer findCustomer(int id) {
            //foreach (Customer c in customers) {
            //    if (c.PrimaryKey == id) {
            //        return c;
            //    }
            //}
            //return null;
            return null;
        }

        public bool deleteCustomer(int id) {
            ////check if the customer exists
            //BaseObject customer = findCustomer(id);
            //if (customer != null) {
            //    //returns true
            //    return customers.Remove(customer);
            //}
            //else {
            //    return false;
            //}
            return false;
        }

        public bool editCustomer(int id, int newId, string newName) {
            //BaseObject customer = findCustomer(id);

            ////no objectList in customerBase
            //if (customers.Count == 0) {
            //    return false;
            //}
            ////customer to edit does not exist
            //else if (customer == null) {
            //    return false;
            //}
            ////cannot edit because newId value already exists
            //else if (searchForDuplicateId(newId)) {
            //    return false;
            //}
            ////blank name not allowed
            //else if (newName == "") {
            //    return false;
            //}
            //else {
            //    customer.Id = newId;
            //    customer.Name = newName;
            //    return true;
            //}
            return false;
        }

        private bool searchForDuplicateId(int id) {
            //foreach (BaseObject c in customers) {
            //    if (c.Id == id) {
            //        //duplicate exists
            //        return true;
            //    }
            //}
            ////no duplicates exist
            //return false;
            return false;
        }

        public int getListSize() {
            return customers.Count;
        }
    }
}