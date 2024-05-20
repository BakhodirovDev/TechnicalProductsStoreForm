using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProductsStore.Class
{
    public class HistorySale : Product
    {
        public int SellerID { get; set; }
        public int ProductID { get; set; }
        public int ProductCount { get; set; }
        public double ProductPrice { get; set; }
        public string ProductSaleTime { get; set; }
    }
}
    