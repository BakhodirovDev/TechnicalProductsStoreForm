﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalProductsStore.Class
{
    public class HistoryWorking
    {
        public int SellerID { get; set; }
        public string SellerSignInTime { get; set; }
        public string? SellerSignOutTime { get; set; }
        public int? SellerSaleTotalCount { get; set; }
        public double? SellerSaleTotalPrice { get; set; }
    }
}
