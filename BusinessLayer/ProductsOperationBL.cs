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
    public class ProductsOperationBL : DataAcessLayer<ProductsBL>, IOperation<ProductsBL>
    {
        public ProductsOperationBL()
        {
        }
        public ProductsOperationBL(string Con) : base(Con)
        {
        }

        public int Delete(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            return ExecNonQuery("USP_ProductsDelete", CommandType.StoredProcedure, P);
        }

        public int Insert(ProductsBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[7];
            P[0] = CreateParameters("@ProductName", InsertingObject.ProductName);
            P[1] = CreateParameters("@BuyPrice", InsertingObject.BuyPrice);
            P[2] = CreateParameters("@SellPrice", InsertingObject.SellPrice);
            P[3] = CreateParameters("@Barcode", InsertingObject.Barcode);
            P[4] = CreateParameters("@Image", InsertingObject.Image);
            P[5] = CreateParameters("@Alert", InsertingObject.Alert);
            P[6] = CreateParameters("@CategoryID", InsertingObject.CategoryID);
            return ExecNonQuery("USP_ProductsInsert", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_ProductsReadAll", CommandType.StoredProcedure);
        }
  
        public ProductsBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_ProductsReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new ProductsBL()
            { 
                ProductID = (int)dt.Rows[0]["ProductID"],
                CategoryID = (int)dt.Rows[0]["CategoryID"],
                Name = dt.Rows[0]["Name"].ToString(),
                ProductName = dt.Rows[0]["ProductName"].ToString(),
                BuyPrice = (decimal)dt.Rows[0]["BuyPrice"],
                SellPrice = (decimal)dt.Rows[0]["SellPrice"],
                Avaliable = (decimal)dt.Rows[0]["Avaliable"],
                Barcode = dt.Rows[0]["Barcode"].ToString(),
                Image = (byte[])dt.Rows[0]["Image"],
                Alert = (int)dt.Rows[0]["Alert"],
            };
        }

        public int Update(ProductsBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[8];
            P[0] = CreateParameters("@ID", UpdatingObject.ProductID);
            P[1] = CreateParameters("@CategoryID", UpdatingObject.CategoryID);
            P[2] = CreateParameters("@ProductName", UpdatingObject.ProductName); 
            P[3] = CreateParameters("@BuyPrice", UpdatingObject.BuyPrice);
            P[4] = CreateParameters("@SellPrice", UpdatingObject.SellPrice);
            P[5] = CreateParameters("@Barcode", UpdatingObject.Barcode);
            P[6] = CreateParameters("@Image", UpdatingObject.Image);
            P[7] = CreateParameters("@Alert", UpdatingObject.Alert);
            return ExecNonQuery("USP_ProductsUpdate", CommandType.StoredProcedure, P);
        }
        public object ProductsCount()
        {
            return ExecScalar("USP_ProductsCount", CommandType.StoredProcedure);
        }
        public ProductsBL ProStoreReadByID(int ID,int StoreID)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@ID", ID);
            P[1] = CreateParameters("@StoreID", StoreID);
            DataTable dt = ExecReader("USP_ProductStoreReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new ProductsBL()
            {
                ProductID = (int)dt.Rows[0]["ProductID"],
                Stock = (decimal)dt.Rows[0]["Stock"],
                ProductName = dt.Rows[0]["ProductName"].ToString(),
                SellPrice = (decimal)dt.Rows[0]["SellPrice"]  
            };
        }
    } 
}