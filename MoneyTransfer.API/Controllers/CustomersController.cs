
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoneyTransfer.DataAccess;
using MoneyTransfer.Models;

namespace MoneyTransfer.API.Controllers
{
    [ApiController]
    [Route("api/v1/customers")]
    public class CustomersController:Controller
    {
        protected readonly MoneyTransferDbContext context;

        public CustomersController(MoneyTransferDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public JsonResult Get()
        {
            return Json(context.Customers);
        }
        [HttpPost]
        public async Task<JsonResult> Post([FromBody]Customer customer)
        {
            context.Add(customer);
            await context.SaveChangesAsync();
            return Json(customer);
        }
        [HttpDelete]
        public async Task<JsonResult> Delete(int id)
        {
            var customer =await  context.Customers.FindAsync(id);
            if (customer == null) return null;
            context.Customers.Remove(customer);
            await context.SaveChangesAsync();
            return Json(customer);
        }
    }
}