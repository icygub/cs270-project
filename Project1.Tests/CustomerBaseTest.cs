
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace Project1.Tests {
    [TestClass]
    public class CustomerBaseTest {

        [TestClass]
        public class AddCustomer_Should { //WORKING
            [TestMethod]
            public void ReturnTrue_WhenOneCustomerIsAdded() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.getListSize() == 0);
                Assert.IsTrue(customerBase.add(new Customer("John", 1234)));
                Assert.IsTrue(customerBase.getListSize() == 1);
                
            }
            [TestMethod]
            public void ReturnTrue_WhenThreeCustomersAreAdded() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.getListSize() == 0);
                Assert.IsTrue(customerBase.add(new Customer("John", 4)));
                Assert.IsTrue(customerBase.add(new Customer("Abraham", 3456)));
                Assert.IsTrue(customerBase.add(new Customer("Isaac", 7890)));
                Assert.IsTrue(customerBase.getListSize() == 3);

            }       
            [TestMethod]
            public void ReturnFalse_WhenIDAlreadyExists() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                customerBase.add(new Customer("Gibran", 1111));
                customerBase.add(new Customer("Cody", 2222));
                customerBase.add(new Customer("James", 3333));
                Assert.IsFalse(customerBase.add(new Customer("Michael", 3333)));
            }
            [TestMethod]
            public void ReturnFalse_WhenNameIsAnEmptyStringOrNull() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsFalse(customerBase.add(new Customer("", 4444)));
                Assert.IsFalse(customerBase.add(new Customer(null, 2222)));
                Assert.IsTrue(customerBase.getListSize() == 0);
            }

        }

        //[TestClass]
        //public class FindCustomer_Should {
        //    [TestMethod]
        //    public void ReturnCustomer_WhenCustomerIDIsFound() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.add((BaseObject)new BaseObject("Joey", 1121));
        //        customerBase.add((BaseObject)new BaseObject("Jordan", 9999));
        //        customerBase.add((BaseObject)new BaseObject("Jacob", 2223));
        //        Assert.IsNotNull(customerBase.findCustomer(1121));
        //        Assert.IsNotNull(customerBase.findCustomer(9999));
        //        Assert.IsNotNull(customerBase.findCustomer(2223));
        //    }
        //    [TestMethod]
        //    public void ReturnNull_WhenCustomerIDIsNotFound() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.add((BaseObject)new BaseObject("Jackson", 1234));
        //        customerBase.add((BaseObject)new BaseObject("Roger", 5678));
        //        Assert.IsNull(customerBase.findCustomer(3344));
        //    }
        //}

        //[TestClass]
        //public class DeleteCustomer_Should {
        //    [TestMethod]
        //    public void ReturnTrue_WhenCustomerIsDeleted() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.add((BaseObject)new BaseObject("Joseph", 1329));
        //        customerBase.add((BaseObject)new BaseObject("Brigham", 8791));
        //        Assert.IsTrue(customerBase.deleteCustomer(1329));
        //        Assert.IsTrue(customerBase.deleteCustomer(8791));
        //        Assert.IsTrue(customerBase.getListSize() == 0);
        //    }
        //    [TestMethod]
        //    public void ReturnFalse_WhenCustomerIdDoesNotExist() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.add((BaseObject)new BaseObject("Abraham", 8734));
        //        customerBase.add((BaseObject)new BaseObject("Lincoln", 9010));
        //        Assert.IsFalse(customerBase.deleteCustomer(7777));
        //        Assert.IsTrue(customerBase.getListSize() == 2);
        //    }
        //}

        //[TestClass]
        //public class EditCustomer_Should {
        //    [TestMethod]
        //    public void ReturnTrue_WhenCustomerNameIsEdited() {

        //    }
    
        //}

        //[TestClass]
        //public class GetListSize_Should {
        //    [TestMethod]
        //    public void Return3_WhenThreeCustomersAreAdded() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.add((BaseObject)new BaseObject("Joey", 1121));
        //        customerBase.add((BaseObject)new BaseObject("Jordan", 9999));
        //        customerBase.add((BaseObject)new BaseObject("Jacob", 2223));
        //        Assert.IsTrue(customerBase.getListSize() == 3);
        //    }
        //}

    }
}
