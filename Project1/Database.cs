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

        public virtual bool Add(BaseObject baseObject) {
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

        public bool Delete(int primaryKey) {
            //check if the baseObject exists
            BaseObject baseObject = Find(primaryKey);
            if (baseObject != null) {
                //returns true
                return ObjectList.Remove(baseObject);
            }
            else {
                return false;
            }
        }

        public BaseObject Find(int primaryKey) {
            foreach (BaseObject obj in ObjectList) {
                if (obj.PrimaryKey == primaryKey) {
                    return obj;
                }
            }
            return null;
        }

        public virtual bool Edit(int oldPrimaryKey, int newPrimaryKey) {
            if (oldPrimaryKey == newPrimaryKey) {
                return true;
            }
            else if (ObjectList.Count == 0) {
                //no BaseObject exists in ObjectList
                return false;
            }

            BaseObject baseObject = Find(oldPrimaryKey);
            if (baseObject == null) {
                return false;
            }
            else if (Find(newPrimaryKey) != null) {
                //cannot edit because newPrimaryKey already exists
                return false;
            }
            else {              
                baseObject.PrimaryKey = newPrimaryKey;
                return true;
            }
        }

        //private bool searchForDuplicateId(int id) {
        //    foreach (BaseObject c in objectList) {
        //        if (c.PrimaryKey == id) {
        //            //duplicate exists
        //            return true;
        //        }
        //    }
        //    //no duplicates exist
        //    return false;
        //}
    }
}
