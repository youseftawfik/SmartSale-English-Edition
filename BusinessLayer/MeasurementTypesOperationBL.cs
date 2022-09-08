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
     public class MeasurementTypesOperationBL : DataAcessLayer<MeasurementTypeBL>, IOperation<MeasurementTypeBL>
    {
        public MeasurementTypesOperationBL()
        {

        }
        public MeasurementTypesOperationBL(string Con): base(Con)
        {
            
        }
        public int Delete(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            return ExecNonQuery("USP_MeasrementTypesDelete", CommandType.StoredProcedure, P);
        }

        public int Insert(MeasurementTypeBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@MeasurementTypesName", InsertingObject.MeasurementTypeName);
            return ExecNonQuery("USP_MeasrementTypesInsert", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_MeasrementTypesReadAll", CommandType.StoredProcedure);
        }

        public MeasurementTypeBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_MeasrementTypesReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new MeasurementTypeBL()
            {
               MeasurementTypeID = (int)dt.Rows[0]["MeasurementTypeID"],
               MeasurementTypeName = dt.Rows[0]["MeasurementTypeName"].ToString()
            };
        }

        public int Update(MeasurementTypeBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@ID", UpdatingObject.MeasurementTypeID);
            P[1] = CreateParameters("@MeaserementTypeName", UpdatingObject.MeasurementTypeName);
            return ExecNonQuery("USP_MeasrementTypesUpdate", CommandType.StoredProcedure, P);
        }
        public object MeasrementTypesCount()
        {
            return ExecScalar("USP_MeasrementTypesCount", CommandType.StoredProcedure);
        }
    }
}
