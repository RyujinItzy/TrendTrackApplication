using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendTrackApplication.Data_Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public decimal CostPrice { get; set; }
        public decimal SalePrice { get; set; }
        public int Stock { get; set; }
        public string ImagePath { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
