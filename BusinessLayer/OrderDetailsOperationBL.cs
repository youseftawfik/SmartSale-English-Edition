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
    public class OrderDetailsOperationBL : DataAcessLayer<OrderDetailsBL>, IOperation<OrderDetailsBL>
    {
        public OrderDetailsOperationBL()
        {

        }
        public OrderDetailsOperationBL(string Con):base (Con)
        {

        }

        public int Insert(OrderDetailsBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[5];
            P[0] = CreateParameters("@OrderID",InsertingObject.OrderID);
            P[1] = CreateParameters("@ProductID", InsertingObject.ProductID);
            P[2] = CreateParameters("@StoreID", InsertingObject.StoreID);
            P[3] = CreateParameters("@Quantity", InsertingObject.Quantity);
            P[4] = CreateParameters("@SellPrice", InsertingObject.SellPrice);
            return ExecNonQuery("USP_OrderDetailsInsert", CommandType.StoredProcedure,P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_OrdersReadAll",CommandType.StoredProcedure);
        }

        public int Update(OrderDetailsBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[6];
            P[0] = CreateParameters("@OrderID", UpdatingObject.OrderID);
            P[1] = CreateParameters("@ProductID", UpdatingObject.ProductID);
            P[2] = CreateParameters("@StoreID", UpdatingObject.StoreID);
            P[3] = CreateParameters("@Quantity", UpdatingObject.Quantity);
            P[4] = CreateParameters("@SellPrice", UpdatingObject.SellPrice);
            P[5] = CreateParameters("@OrderTotal", UpdatingObject.OrderTotal);
            return ExecNonQuery("USP_OrderDetailsUpdate", CommandType.StoredProcedure, P);
        }

        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }
        
        public OrderDetailsBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_OrdersDetailsReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new OrderDetailsBL()
            {
                OrderID = (int)dt.Rows[0]["Receipt No"],
                ProductName = dt.Rows[0]["Product Name"].ToString(),
                StoreName = dt.Rows[0]["Store Name"].ToString(),
                Quantity = (decimal)dt.Rows[0]["Quantity"],
                SellPrice = (decimal)dt.Rows[0]["Sell Price"],
                TotalPrice = (decimal)dt.Rows[0]["Total"]
            };
        }
        /// <summary>
        ///  Method TO Retrieve Data
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="ProductID"></param>
        /// <param name="StoreID"></param>
        /// <returns></returns>
        public OrderDetailsBL RefundReadByID(int ID, int ProductID, int StoreID)
        {
            SqlParameter[] P = new SqlParameter[3];
            P[0] = CreateParameters("@ID", ID);
            P[1] = CreateParameters("@ProductID", ProductID);
            P[2] = CreateParameters("@StoreID", StoreID);
            DataTable dt = ExecReader("USP_OrdersDetailsReadByIDfull", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new OrderDetailsBL()
            {
                OrderID = (int)dt.Rows[0]["Order Number"],
                ProductID = (int)dt.Rows[0]["ProductID"],
                StoreID = (int)dt.Rows[0]["StoreID"],
                ProductName = dt.Rows[0]["Product Name"].ToString(),
                StoreName = dt.Rows[0]["Store Name"].ToString(),
                Quantity = (decimal)dt.Rows[0]["Quantity"],
                SellPrice = (decimal)dt.Rows[0]["Sell Price"],
                TotalPrice = (decimal)dt.Rows[0]["Total Price"],
                OrderTotal = (decimal)dt.Rows[0]["Order Total"]
            };
        }

    }
}
