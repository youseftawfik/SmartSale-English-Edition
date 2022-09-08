using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderDetailsBL
    {
        public long OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public decimal Quantity { get; set; }
        public decimal SellPrice { get; set; }
        public decimal OrderTotal { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
