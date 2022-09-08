using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerDAL;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class OrderRefundOperationBL : DataAcessLayer<OrderRefundBL>, IOperation<OrderRefundBL>
    {
        public OrderRefundOperationBL()
        {

        }
        public OrderRefundOperationBL(string Con):base (Con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(OrderRefundBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[3];
            P[0] = CreateParameters("@RefundDate",InsertingObject.RefundDate);
            P[1] = CreateParameters("@EmployeeName", InsertingObject.EmployeeName);
            P[2] = CreateParameters("@CustomerName", InsertingObject.CustomerName);
            return ExecNonQuery("USP_OrderRefundInsert", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            throw new NotImplementedException();
        }

        public OrderRefundBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(OrderRefundBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
        public object RefundID()
        {
            return ExecScalar("USP_OrderRefundReadID", CommandType.StoredProcedure);
        }
    }
}
