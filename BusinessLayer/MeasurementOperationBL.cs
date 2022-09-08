using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayerDAL;
using System.Data.SqlClient;
using System.Data;

namespace BusinessLayer
{
   public class MeasurementOperationBL : DataAcessLayer<MeasurementBL>, IOperation<MeasurementBL>
    {
        public MeasurementOperationBL()
        {

        }
        public MeasurementOperationBL(string Con):base (Con)
        {

        }
        public int Delete(int ID)
        {
            throw new NotImplementedException();
        }

        public int Insert(MeasurementBL InsertingObject)
        {
            throw new NotImplementedException();
        }

        public DataTable ReadAll()
        {
            return ExecReader("USP_MeasrementReadAll",CommandType.StoredProcedure);
        }

        public MeasurementBL ReadByID(int ID)
        {
            throw new NotImplementedException();
        }

        public int Update(MeasurementBL UpdatingObject)
        {
            throw new NotImplementedException();
        }
    }
}
