using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class ProductsBL
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string ProductName { get; set; }
        public decimal BuyPrice { get; set; }
        public decimal SellPrice { get; set; }
        public string Barcode { get; set; }
        public byte[] Image { get; set; }
        public int Alert { get; set; }
        public decimal Avaliable { get; set; }
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public decimal Stock { get; set; }
    }
}
