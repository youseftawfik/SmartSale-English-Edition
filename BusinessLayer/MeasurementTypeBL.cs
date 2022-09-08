using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
     public class MeasurementTypeBL
    {
        /// <summary>
        /// Fields of UnitTypes Table 
        /// </summary>
        public int MeasurementTypeID { get; set; }
        public string MeasurementTypeName { get; set; }
        public bool IsDeleted { get; set; }
    }
}
