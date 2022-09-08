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
    public class StoresOperationBL : DataAcessLayer<StoresBL>, IOperation<StoresBL>
    {
        public StoresOperationBL()
        {
        }
        public StoresOperationBL(string Con):base (Con)
        {
        }
        public int Delete(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            return ExecNonQuery("USP_StoreDelete", CommandType.StoredProcedure, P);
        }

        public int Insert(StoresBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@StoreName", InsertingObject.StoreName);
            P[1] = CreateParameters("@Location", InsertingObject.Location);
            return ExecNonQuery("USP_StoreInsert", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_StoreReadAll",CommandType.StoredProcedure);
        }

        public StoresBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_StocreReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new StoresBL {
                StoreID = (int)dt.Rows[0]["StoreID"],
                StoreName = dt.Rows[0]["StoreName"].ToString(),
                Location = dt.Rows[0]["Location"].ToString()
            };
        }

        public int Update(StoresBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[3];
            P[0] = CreateParameters("@ID", UpdatingObject.StoreID);
            P[1] = CreateParameters("@StoreName", UpdatingObject.StoreName);
            P[2] = CreateParameters("@Location", UpdatingObject.Location);
            return ExecNonQuery("USP_StoreUpdate", CommandType.StoredProcedure, P);
        }
        public object StoresCount()
        {
            return ExecScalar("USP_StoreCount",CommandType.StoredProcedure);
        }
    }
}
