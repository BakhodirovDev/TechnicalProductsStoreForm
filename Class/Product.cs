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
        public string? ProductCountry { get; set; }
        public double? ProductPrice { get; set; }
        public string? ProductDescription { get; set;}
<<<<<<< HEAD
        public int? ProductEnterCount { get; set; }
=======
        public int ProductEnterCount { get; set; }
>>>>>>> 7ebf9e1b0ddb855390d7b802d209f03feccbda24
        public string? ProductEnterData { get; set; }
        public int? RemainingProductCount { get; set; }
    }
}
