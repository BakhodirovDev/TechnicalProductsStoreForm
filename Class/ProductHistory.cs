﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProductsStore.Class
{
    public class ProductHistory
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public double? ProductPrice { get; set; }
        public int ProductEnterCount { get; set; }
        public string? ProductEnterData { get; set; }
        public int? RemainingProductCount { get; set; }
    }
}
