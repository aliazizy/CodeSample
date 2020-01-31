using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoneyTransfer.API.Controllers;
using MoneyTransfer.Models;
namespace MoneyTransfer.Test
{
    [TestClass]
    public class CustomerControllerTest
    {
        [TestMethod]
        public void ShouldReturnJsonResultOnGetMethodCalling()
        {
            var res = new CustomersController(new DataAccess.MoneyTransferDbContext()).Get();
            Assert.IsNotNull(res);
        }
        [TestMethod]
        public void ShouldReturnPostedCustomerWithAssignedId()
        {
            var customer = new Customer
            {
                CustomerId = 0,
                FullName = "Ali",
                Email = "Ali Azizi",
                Tel = "0999999"
            };

            var res = new CustomersController(new DataAccess.MoneyTransferDbContext()).Post(customer);
            Assert.IsFalse(res==null);
        }
    }
}