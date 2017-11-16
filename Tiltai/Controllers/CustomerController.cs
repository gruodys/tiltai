using Microsoft.AspNetCore.Mvc;
using programavimoTiltas.Data;
using System.Linq;

namespace programavimoTiltas.Controllers
{
    [Route("api/[controller]/[action]")]
    public class CustomerController : Controller
    {


        private readonly DataModelContext dataModelContext;

        public CustomerController(DataModelContext dataModelContext)
        {
            this.dataModelContext = dataModelContext;
        }
        //GET quotation
        [Route("")]
        [HttpGet]
        public IQueryable<Customer> GetAll()
        {

            return dataModelContext.Customers;
        }
    }
}