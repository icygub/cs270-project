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

        public override bool Add(BaseObject customer) {
            //blank or null name is not allowed
            if (string.IsNullOrEmpty(((Customer)customer).Name)) {
                return false;
            }

            return base.Add(customer);
        }

        //Delete() in the base class Database

        //Find() in the base class Database

        public bool Edit(int oldId, int newId, string newName) {
            if (newName == "") {
                return false;
            }

            bool idWasEdited = base.Edit(oldId, newId);
            if (!idWasEdited) {
                return false;
            }

            Customer customer = (Customer) Find(newId);
            customer.Name = newName;
            return true;
        }

        public bool EditName(int id, string newName) {
            Customer customer = (Customer) Find(id);
            if(customer != null && newName != "") {
                customer.Name = newName;
                return true;
            }
            return false;
        }

        



        public int getListSize() {
            return customers.Count;
        }





        //private bool searchForDuplicateId(int id) {
        //    //foreach (BaseObject c in customers) {
        //    //    if (c.PrimaryKey == id) {
        //    //        //duplicate exists
        //    //        return true;
        //    //    }
        //    //}
        //    ////no duplicates exist
        //    //return false;
        //    return false;
        //}
    }
}