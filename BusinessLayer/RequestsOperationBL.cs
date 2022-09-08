using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerDAL;
using System.Data.SqlClient;
using System.Data.Sql;

namespace BusinessLayer
{
    public class RequestsOperationBL : DataAcessLayer<RequestsBL>,IOperation<RequestsBL>
    {
        public RequestsOperationBL()
        {
        }
        public RequestsOperationBL(string Con) : base(Con)
        {
        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(RequestsBL InsertingObject)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadAll()
        {
            throw new NotImplementedException();
        }

        public RequestsBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(RequestsBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
    }
}
