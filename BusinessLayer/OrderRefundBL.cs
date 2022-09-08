using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class OrderRefundBL
    {
        public int RefundID { get; set; }
        public DateTime RefundDate { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
    }
}
