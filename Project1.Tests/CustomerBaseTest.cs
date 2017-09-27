
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;

namespace Project1.Tests {
    [TestClass]
    public class CustomerBaseTest {

        [TestClass]
        public class AddCustomer_Should {
            [TestMethod]
            public void ReturnTrue_WhenCustomerIsAStringAndIDIsAWholeNumber() {
                CustomerBase customerBase = new CustomerBase();
                Assert.IsTrue(customerBase.addCustomer(new Customer("John", 1234)));
            }

        }

    }
}
