using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using DataAccessLayerDAL;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class CategoryOperationBL : DataAcessLayer<CategoryBL>, IOperation<CategoryBL>
    {
        public CategoryOperationBL()
        {
        }
        public CategoryOperationBL(string Con) : base(Con)
        {
        }
        public int Insert(CategoryBL InsertingObject)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@Name", InsertingObject.Name);
            P[1] = CreateParameters("@Description", InsertingObject.Description);
            return ExecNonQuery("USP_CategoryInsert", CommandType.StoredProcedure, P);
        }
        public int Delete(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            return ExecNonQuery("USP_CategoryDelete", CommandType.StoredProcedure, P);
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_CategoryReadAll", CommandType.StoredProcedure);
        }
        public CategoryBL ReadByID(int ID)
        {
            SqlParameter[] P = new SqlParameter[1];
            P[0] = CreateParameters("@ID", ID);
            DataTable dt = ExecReader("USP_CategoryReadByID", CommandType.StoredProcedure, P);
            if (dt == null)
                return null;
            return new CategoryBL()
            {
                CategoryID = (int)dt.Rows[0]["CategoryID"],
                Name = dt.Rows[0]["Name"].ToString(),
                Description = dt.Rows[0]["Description"].ToString()
            };
        }
        public int Update(CategoryBL UpdatingObject)
        {
            SqlParameter[] P = new SqlParameter[3];
            P[0] = CreateParameters("@ID", UpdatingObject.CategoryID);
            P[1] = CreateParameters("@Name", UpdatingObject.Name);
            P[2] = CreateParameters("@Description", UpdatingObject.Description);
            return ExecNonQuery("USP_CategoryUpdate", CommandType.StoredProcedure, P);
        }
    }
}

