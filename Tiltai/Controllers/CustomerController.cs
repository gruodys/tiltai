using Microsoft.AspNetCore.Mvc;
using programavimoTiltas.Data;
using System.Linq;
using Tiltai.Services;

namespace programavimoTiltas.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : Controller
    {


        private readonly DataModelContext dataModelContext;
        private readonly ICustomerService customerService;

        public CustomerController(DataModelContext dataModelContext, ICustomerService customerService)
        {
            this.dataModelContext = dataModelContext;
            this.customerService = customerService;
        }
        
        [HttpGet]
        public IQueryable<Customer> GetAll()
        {
            return customerService.GetAll();
        }
    }
}