using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace programavimoTiltas.Data
{
    public class DataModelRepository : IDataModelRepository
    {
        DataModelContext dataModelContext;
        public DataModelRepository(DataModelContext dataModelContext)
        {
            this.dataModelContext = dataModelContext;
        }
        public IQueryable<Customer> GetCustomer()
        {
            return dataModelContext.Customers;
        }

        public IQueryable<Order> GetOrders()
        {
            return dataModelContext.Orders;//.Include("Customer");
        }

        public void SaveOrder(Order order)
        {
            dataModelContext.Orders.Add(order);
            dataModelContext.SaveChanges();
        }
    }
}