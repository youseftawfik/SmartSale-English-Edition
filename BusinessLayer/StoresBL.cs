using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StoresBL
    {
        /// <summary>
        /// Fields of Stores Table 
        /// </summary>
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string Location { get; set; }
        public bool IsDeleted { get; set; }
    }
}
