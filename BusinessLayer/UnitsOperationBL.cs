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
    public class UnitsOperationBL : DataAcessLayer<UnitsBL>, IOperation<UnitsBL>
    {
        public UnitsOperationBL()
        {

        }
        public UnitsOperationBL(string Con):base(Con)
        {

        }
        public int Delete(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            return ExecNonQuery("USP_UnitsDelete", CommandType.StoredProcedure, P);
        }

        public int Insert(UnitsBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@Name", InsertingObject.UnitName);
            P[1] = CreateParameters("@UnitTypeID", InsertingObject.UnitTypeID);
            return ExecNonQuery("USP_UnitsInsert", CommandType.StoredProcedure,P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_UnitsReadAll", CommandType.StoredProcedure);
        }

        public UnitsBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_UnitsReadByID", CommandType.StoredProcedure);
            if (dt == null)
                return null;
                return new UnitsBL
                {
                    UnitID = (int)dt.Rows[0]["UnitID"],
                    UnitName = dt.Rows[0]["UnitName"].ToString(),
                    FlagMasterUnit = (bool)dt.Rows[0]["FlagMasterUnit"],
                    //UnitTypeID = (int)dt.Rows[0]["UnitTypeID"]
                }; 
        }

        public int Update(UnitsBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[3];
            P[0] = CreateParameters("@ID", UpdatingObject.UnitID);
            P[1] = CreateParameters("@Name", UpdatingObject.UnitName);
            //P[2] = CreateParameters("@UnitTypeID", UpdatingObject.UnitTypeID);
            return ExecNonQuery("USP_UnitsUpdate", CommandType.StoredProcedure);
        }
    }
}
