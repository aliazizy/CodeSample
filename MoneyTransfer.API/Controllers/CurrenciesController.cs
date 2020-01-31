using Microsoft.AspNetCore.Mvc;
using MoneyTransfer.DataAccess;

namespace MoneyTransfer.API.Controllers
{
    [ApiController]
    [Route("api/v1/currencies")]
    public class CurrenciesController:Controller
    {
        private readonly MoneyTransferDbContext context;

        public CurrenciesController(MoneyTransferDbContext context )
        {
            this.context = context;
        }

    }
}
