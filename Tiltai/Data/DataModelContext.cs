using Microsoft.EntityFrameworkCore;

namespace programavimoTiltas.Data
{
    public class DataModelContext : DbContext
    {
        public DataModelContext(DbContextOptions<DataModelContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}