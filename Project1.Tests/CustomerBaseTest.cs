
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace Project1.Tests {
    [TestClass]
    public class CustomerBaseTest {

        [TestClass]
        public class AddCustomer_Should { //in either case, TRUE means customer was successfully added.
            [TestMethod]
            public void ReturnTrue_WhenOneCustomerIsAdded() {
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.addCustomer(new Customer("John", 1234)));
                
            }
            [TestMethod]
            public void ReturnTrue_WhenMultipleCustomersAreAdded() { //NOT WORKING AT ALL. CAN ONLY ADD ONE, BUT NOT MULTIPLE
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.addCustomer(new Customer("John", 4)));
                Assert.IsTrue(customerBase.addCustomer(new Customer("Abraham", 3456)));
                Assert.IsTrue(customerBase.addCustomer(new Customer("Isaac", 7890)));

                
            }
            [TestMethod]
            public void ReturnFalse_WhenIDAlreadyExists() { //not working
                CustomerBase customerBase = new CustomerBase();
                customerBase.addCustomer(new Customer("Gibran", 1111));
                customerBase.addCustomer(new Customer("Cody", 2222));
                Assert.IsFalse(customerBase.addCustomer(new Customer("Michael", 333)));
            }
            [TestMethod]
            public void ReturnFalse_WhenNameIsAnEmptyStringOrNull() { //WORKING
                CustomerBase customerBase = new CustomerBase();
                Assert.IsFalse(customerBase.addCustomer(new Customer("", 4444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer("", 44444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer("", 44444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer("", 4444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer(null, 4444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer(null, 4444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer(null, 4444)));
                Assert.IsFalse(customerBase.addCustomer(new Customer(null, 4444)));
            }
            [TestMethod]
            public void testTesting() {
                CustomerBase customerBase = new CustomerBase();

                customerBase.addString("asdf");
                customerBase.addString("asdf");
                Assert.IsTrue(2 == customerBase.getStringsSize());
            }
        }

        [TestClass]
        public class FindCustomer_Should {
            [TestMethod]
            public void ReturnCustomer_WhenCustomerIDIsFound() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.addCustomer(new Customer("Joey", 1121));
                customerBase.addCustomer(new Customer("Jordan", 9999));
                customerBase.addCustomer(new Customer("Jacob", 2223));
                Assert.IsNotNull(customerBase.findCustomer(9999));
            }
        }

        [TestClass]
        public class DeleteCustomer_Should {
            [TestMethod]
            public void ReturnTrue_WhenCustomerIsDeletedUsingID() {

            }
            [TestMethod]
            public void ReturnFalse_WhenCustomerIsNotDeletedUsingID() {

            }
        }

        [TestClass]
        public class EditCustomer_Should {
            [TestMethod]
            public void ReturnTrue_WhenCustomerNameIsEdited() {

            }

        }

        [TestClass]
        public class GetListSize_Should {
            [TestMethod]
            public void Return3_WhenThreeCustomersAreAdded() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.addCustomer(new Customer("Joey", 1121));
                customerBase.addCustomer(new Customer("Jordan", 9999));
                customerBase.addCustomer(new Customer("Jacob", 2223));
                Assert.IsTrue(customerBase.getListSize() == 3);
            }
        }

    }
}
