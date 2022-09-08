using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataAccessLayerDAL;
namespace BusinessLayer
{
    public class EmployeeOperationBL : DataAcessLayer<EmployeeBL>, IOperation<EmployeeBL>
    {
        public EmployeeOperationBL()
        {

        }
        public EmployeeOperationBL(string con) : base(con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(EmployeeBL InsertingObject)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadAll()
        {
            throw new NotImplementedException();
            //return ExecReader("USP_EmployeeReadAll", CommandType.StoredProcedure);
        }

        public EmployeeBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(EmployeeBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
        public object ReadAll2()
        {
            return ExecScalar("USP_EmployeeReadAll", CommandType.StoredProcedure);
        }
        public object Login(string Username, string Password)
        {
            SqlParameter[] P = new SqlParameter[2];
            P[0] = CreateParameters("@username", Username);
            P[1] = CreateParameters("@password", Password);
            return ExecScalar("USP_Login", CommandType.StoredProcedure, P);
        }
    }
}
