using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace programavimoTiltas.Data
{
    public class Order
    {
        public int Id { get; set; }
        public string PolisoNr { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}