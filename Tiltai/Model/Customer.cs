using System;

namespace programavimoTiltas.Data
{
    public class Customer
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string EORI { get; set; }
        public int Code { get; set; }
        public DateTime CreateDate { get; set; }
    }
}