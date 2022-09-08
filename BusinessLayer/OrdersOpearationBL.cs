using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DataAccessLayerDAL;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
    public class OrdersOpearationBL : DataAcessLayer<OrdersBL>, IOperation<OrdersBL>
    {
        public OrdersOpearationBL()
        {

        }
        public OrdersOpearationBL(string Con):base(Con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(OrdersBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[4];
            P[0] = CreateParameters("@customerID", InsertingObject.CustomerID);
            P[1] = CreateParameters("@EmployeeName", InsertingObject.EmployeeName);
            P[2] = CreateParameters("@OrderDate", InsertingObject.OrderDate);
            P[3] = CreateParameters("@OrderTotal", InsertingObject.OrderTotal);
            return ExecNonQuery("USP_OrdersInsert", CommandType.StoredProcedure,P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_OrdersReadAll", CommandType.StoredProcedure);
        }

        public OrdersBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_OrdersReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new OrdersBL()
            {
                OrderID = (int)dt.Rows[0]["Receipt No"],
                OrderDate = (DateTime)dt.Rows[0]["Receipt Date"],
                EmployeeName = dt.Rows[0]["Employee Name"].ToString(),
                CustomerName = dt.Rows[0]["Client Name"].ToString(),
                OrderTotal = (decimal)dt.Rows[0]["Total"],
            };
        }

        public int Update(OrdersBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
        public object OrderID()
        {
            return ExecScalar("USP_OrdersReadBID", CommandType.StoredProcedure);
        }
        public DataTable SelectOrderID()
        {
            return ExecReader("USP_OrdersReadID", CommandType.StoredProcedure);
        }
        public object OrdersCount()
        {
            return ExecScalar("USP_OrdersCount", CommandType.StoredProcedure);
        }
    }
}
