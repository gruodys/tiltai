using programavimoTiltas.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tiltai.Services
{
    public class CustomerService :ICustomerService
    {
        private readonly DataModelContext dataModelContext;

        public CustomerService(DataModelContext dataModelContext)
        {
            this.dataModelContext = dataModelContext;
        }

        public IQueryable<Customer> GetAll()
        {
            return dataModelContext.Customers;
        }
    }
}
