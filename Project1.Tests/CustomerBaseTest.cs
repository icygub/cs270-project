
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace Project1.Tests {
    [TestClass]
    public class CustomerBaseTest {

        [TestClass]
        public class AddCustomer_Should { //in either case, TRUE means customer was successfully added.
            [TestMethod]
            public void ReturnTrue_WhenCustomerIsAdded() {
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.addCustomer(new Customer("John", 1234)));
            }
            [TestMethod]
            public void ReturnFalse_WhenIDAlreadyExists() {
                CustomerBase customerBase = new CustomerBase();
                customerBase.addCustomer(new Customer("Gibran", 1111));
                customerBase.addCustomer(new Customer("Cody", 2222));
                Assert.IsFalse(customerBase.addCustomer(new Customer("Michael", 1111)));
            }
            [TestMethod]
            public void ReturnFalse_WhenNameIsAnEmptyStringOrNull() {
                CustomerBase customerBase = new CustomerBase();
                Assert.IsFalse(customerBase.addCustomer(new Customer("", 4444)));
            }
        }

        [TestClass]
        public class FindCustomer_Should {
            [TestMethod]
            public void ReturnCustomer_WhenCustomerIDIsFound() {
                CustomerBase customerBase = new CustomerBase();
            }
        }

    }
}
