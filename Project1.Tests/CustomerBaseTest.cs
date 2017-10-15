
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace Project1.Tests {
    [TestClass]
    public class CustomerBaseTest {

        [TestClass]
        public class Add_Should { //WORKING
            [TestMethod]
            public void ReturnTrue_WhenOneCustomerIsAdded() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.getListSize() == 0);
                Assert.IsTrue(customerBase.Add(new Customer("John", 1234)));
                Assert.IsTrue(customerBase.getListSize() == 1);
                
            }
            [TestMethod]
            public void ReturnTrue_WhenThreeCustomersAreAdded() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.getListSize() == 0);
                Assert.IsTrue(customerBase.Add(new Customer("John", 4)));
                Assert.IsTrue(customerBase.Add(new Customer("Abraham", 3456)));
                Assert.IsTrue(customerBase.Add(new Customer("Isaac", 7890)));
                Assert.IsTrue(customerBase.getListSize() == 3);

            }       
            [TestMethod]
            public void ReturnFalse_WhenIDAlreadyExists() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                customerBase.Add(new Customer("Gibran", 1111));
                customerBase.Add(new Customer("Cody", 2222));
                customerBase.Add(new Customer("James", 3333));
                Assert.IsFalse(customerBase.Add(new Customer("Michael", 3333)));
            }
            [TestMethod]
            public void ReturnFalse_WhenNameIsAnEmptyStringOrNull() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsFalse(customerBase.Add(new Customer("", 4444)));
                Assert.IsFalse(customerBase.Add(new Customer(null, 2222)));
                Assert.IsTrue(customerBase.getListSize() == 0);
            }

        }

        [TestClass]
        public class Find_Should {
            [TestMethod]
            public void ReturnCustomer_WhenCustomerIDIsFound() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.Add(new Customer("Joey", 1121));
                customerBase.Add(new Customer("Jordan", 9999));
                customerBase.Add(new Customer("Jacob", 2223));
                Assert.IsNotNull(customerBase.Find(1121));
                Assert.IsNotNull(customerBase.Find(9999));
                Assert.IsNotNull(customerBase.Find(2223));
            }
            [TestMethod]
            public void ReturnNull_WhenCustomerIDIsNotFound() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.Add(new Customer("Jackson", 1234));
                customerBase.Add(new Customer("Roger", 5678));
                Assert.IsNull(customerBase.Find(3333));
            }
        }

        [TestClass]
        public class Delete_Should {
            [TestMethod]
            public void ReturnTrue_WhenCustomerIsDeleted() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.Add(new Customer("Joseph", 1329));
                customerBase.Add(new Customer("Brigham", 8791));
                Assert.IsTrue(customerBase.Delete(1329));
                Assert.IsTrue(customerBase.Delete(8791));
                Assert.IsTrue(customerBase.getListSize() == 0);
            }
            [TestMethod]
            public void ReturnFalse_WhenCustomerIdDoesNotExist() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.Add(new Customer("Abraham", 8734));
                customerBase.Add(new Customer("Lincoln", 9010));
                Assert.IsFalse(customerBase.Delete(7777));
                Assert.IsTrue(customerBase.getListSize() == 2);
            }
        }

        [TestClass]
        public class Edit_Should {
            [TestMethod]
            public void ReturnTrue_WhenOnlyCustomerNameIsEdited() {
                CustomerBase customerBase = new CustomerBase();
                Customer customer = new Customer("Abraham", 7234);
                customerBase.Add(customer);
                Assert.IsTrue(customerBase.Edit(customer.PrimaryKey, 7234, "Isaac"));
            }
            [TestMethod]
            public void ReturnTrue_WhenOnlyCustomerIdIsEdited() {
                CustomerBase customerBase = new CustomerBase();
                Customer customer = new Customer("Joey", 5746);
                customerBase.Add(customer);
                Assert.IsTrue(customerBase.Edit(customer.PrimaryKey, 4398));
            }
            [TestMethod]
            public void ReturnTrue_WhenBothCustomerNameAndIdAreEdited() {
                CustomerBase customerBase = new CustomerBase();
                Customer customer = new Customer("Coby", 72343);
                customerBase.Add(customer);
                Assert.IsTrue(customerBase.Edit(customer.PrimaryKey, 8253, "Ryan"));
            }
            [TestMethod]
            public void ReturnFalse_WhenCustomerIdDoesNotExist() {
                CustomerBase customerBase = new CustomerBase();
                Customer customer = new Customer("Larry", 8855);
                customerBase.Add(customer);
                Assert.IsFalse(customerBase.Edit(0090, 4430, "Larry"));
            }


        }

        //[TestClass]
        //public class GetListSize_Should {
        //    [TestMethod]
        //    public void Return3_WhenThreeCustomersAreAdded() {
        //        CustomerBase customerBase = new CustomerBase();
        //        customerBase.Add((BaseObject)new BaseObject("Joey", 1121));
        //        customerBase.Add((BaseObject)new BaseObject("Jordan", 9999));
        //        customerBase.Add((BaseObject)new BaseObject("Jacob", 2223));
        //        Assert.IsTrue(customerBase.getListSize() == 3);
        //    }
        //}

    }
}
