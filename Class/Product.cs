using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProductsStore.Class
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Country { get; set; }
        public double Price { get; set; }
        public string? Description { get; set;}
        public string? ProductNumber { get; set; }
    }
}
