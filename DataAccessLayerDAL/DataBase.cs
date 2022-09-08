using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace DataAccessLayerDAL
{
    public abstract class DataBase : CollectionBase
    {
        // Field
        private readonly string Connection;

        // Method to get Connection String 
        public string DataBasecon
        {
            get
            {
                return Connection;
            }
        }
        // Default Constructor
        public DataBase()
        {

        }
        // Non Default Constructor
        public DataBase(string Con)
        {
            Connection = Con;
        }
    }
}

