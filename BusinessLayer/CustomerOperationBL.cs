using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessLayerDAL;

namespace BusinessLayer
{
    public class CustomerOperationBL : DataAcessLayer<CustomersBL>, IOperation<CustomersBL>
    {
        public CustomerOperationBL()
        {

        }
        public CustomerOperationBL(string con):base(con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(CustomersBL InsertingObject)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_CustomersReadAll",CommandType.StoredProcedure);
        }

        public CustomersBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(CustomersBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
    }
}
