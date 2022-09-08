using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class RefundDetailsBL
    {
        public int RefundID { get; set; }
        public long OrderID { get; set; }
        public int ProductID { get; set; }
        public int StoreID { get; set; }
        public decimal Quantity { get; set; }
        public decimal SellPrice { get; set; }
    }
}
