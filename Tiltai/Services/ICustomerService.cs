using programavimoTiltas.Data;
using System.Linq;

namespace Tiltai.Services
{
    public interface ICustomerService
    {
        IQueryable<Customer> GetAll();
    }
}
