using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
     public class RequestsBL
    {
        /// <summary>
        /// Fields of Requests Table
        /// </summary>
        public int RequestID { get; set; }
        public int EmployeeID { get; set; }
        public int VendorID { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPriceBeforeDis { get; set; }
        public decimal TotalPriceAfterDis { get; set; }
    }
}
