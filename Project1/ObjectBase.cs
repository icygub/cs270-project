using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    abstract class ObjectBase
    {
        List<System.Object> objList = new List<System.Object>();

        /**
         * Will only add object if primary key is unique
         * */
        public bool add(Object @object) {
            //blank or null name is not allowed
            //if (string.IsNullOrEmpty(@object.Name)) {
            //    return false;
            //}

            foreach (Object c in objList) {
                if (@object.Id == c.Id) {
                    //duplicate found
                    return false;
                }
            }

            objList.Add(new Object(@object.Name, @object.Id));
            return true;
        }

        public Object findCustomer(int id) {
            foreach (Object c in objList) {
                if (c.Id == id) {
                    return c;
                }
            }
            return null;
        }

        public bool deleteCustomer(int id) {
            //check if the object exists
            Object customer = findCustomer(id);
            if (customer != null) {
                //returns true
                return objList.Remove(customer);
            }
            else {
                return false;
            }
        }

        public bool editCustomer(int id, int newId, string newName) {
            Object customer = findCustomer(id);

            //no objList in customerBase
            if (objList.Count == 0) {
                return false;
            }
            //object to edit does not exist
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
            foreach (Object c in objList) {
                if (c.Id == id) {
                    //duplicate exists
                    return true;
                }
            }
            //no duplicates exist
            return false;
        }

        public int getListSize() {
            return objList.Count;
        }
    }
}
