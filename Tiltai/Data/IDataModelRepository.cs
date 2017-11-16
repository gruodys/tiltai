using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace programavimoTiltas.Data
{
    public interface IDataModelRepository
    {
        IQueryable<Customer> GetCustomer();
        IQueryable<Order> GetOrders();
    }
}