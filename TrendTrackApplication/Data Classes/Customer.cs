﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendTrackApplication.Data_Classes
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public decimal Change { get; set; }
        public DateTime Date { get; set; }
    }
}
