using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    /// <summary>
    /// Generic Interface for DataBase CRUD { Insert-Update-Delete-Read }
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IOperation<T>
    {
        int Insert(T InsertingObject);
        int Update(T UpdatingObject);
        DataTable ReadAll();
        int Delete(int ID);
        T ReadByID(int ID);
    }
}