using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public abstract class Database
    {
        public List<BaseObject> ObjectList {get; set;}

        public Database() {
            this.ObjectList = new List<BaseObject>();
        } 

        public virtual bool add(BaseObject baseObject) {
            //will return false if same PrimaryKey exists
            foreach (BaseObject obj in ObjectList) {
                if (baseObject.PrimaryKey == obj.PrimaryKey) {
                    //duplicate found
                    return false;
                }
            }

            ObjectList.Add(baseObject);
            return true;
        }

        //public BaseObject findCustomer(int id) {
        //    foreach (BaseObject c in objectList) {
        //        if (c.Id == id) {
        //            return c;
        //        }
        //    }
        //    return null;
        //}

        //public bool deleteCustomer(int id) {
        //    //check if the baseObject exists
        //    BaseObject customer = findCustomer(id);
        //    if (customer != null) {
        //        //returns true
        //        return objectList.Remove(customer);
        //    }
        //    else {
        //        return false;
        //    }
        //}

        //public bool editCustomer(int id, int newId, string newName) {
        //    BaseObject customer = findCustomer(id);

        //    //no objectList in customerBase
        //    if (objectList.Count == 0) {
        //        return false;
        //    }
        //    //baseObject to edit does not exist
        //    else if (customer == null) {
        //        return false;
        //    }
        //    //cannot edit because newId value already exists
        //    else if (searchForDuplicateId(newId)) {
        //        return false;
        //    }
        //    //blank name not allowed
        //    else if (newName == "") {
        //        return false;
        //    }
        //    else {
        //        customer.Id = newId;
        //        customer.Name = newName;
        //        return true;
        //    }
        //}

        //private bool searchForDuplicateId(int id) {
        //    foreach (BaseObject c in objectList) {
        //        if (c.Id == id) {
        //            //duplicate exists
        //            return true;
        //        }
        //    }
        //    //no duplicates exist
        //    return false;
        //}

        //public int getListSize() {
        //    return objectList.Count;
        //}
    }
}
