using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using DataAccessLayerDAL;

namespace BusinessLayer
{
    public class RefundDetailOperationBL:DataAcessLayer<RefundDetailsBL>,IOperation<RefundDetailsBL>
    {
        public RefundDetailOperationBL()
        {

        }
        public RefundDetailOperationBL(string Con):base(Con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(RefundDetailsBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[6];
            P[0] = CreateParameters("@RefundID", InsertingObject.RefundID);
            P[1] = CreateParameters("@OrderID", InsertingObject.OrderID);
            P[2] = CreateParameters("@ProductID", InsertingObject.ProductID);
            P[3] = CreateParameters("@StoreID", InsertingObject.StoreID);
            P[4] = CreateParameters("@Quantity", InsertingObject.Quantity);
            P[5] = CreateParameters("@SellPrice", InsertingObject.SellPrice);
            return ExecNonQuery("USP_RefundDetailsInsert", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            throw new NotImplementedException();
        }

        public RefundDetailsBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(RefundDetailsBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
    }
}
