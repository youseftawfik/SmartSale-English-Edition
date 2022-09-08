using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class UnitsBL
    {
        /// <summary>
        /// Fields of Units Table
        /// </summary>
        public int UnitID { get; set; }
        public int UnitTypeID { get; set; }
        public string UnitName { get; set; }
        public bool FlagMasterUnit { get; set; }
        public bool IsDeleted { get; set; }
    }
}
