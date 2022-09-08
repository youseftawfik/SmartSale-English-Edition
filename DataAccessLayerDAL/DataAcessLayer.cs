using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayerDAL
{
    public abstract class DataAcessLayer<T> : DataBase
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public DataAcessLayer()
        {
        }
        /// <summary>
        /// Non Default Constructor 
        /// </summary>
        /// <param name="Con">To Get the connection String in it</param>
        public DataAcessLayer(string Con) : base(Con)
        {
        }
        /// <summary>
        ///  Method for the Scalar Procedures
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="cmdtypt"> Comand type {text - store procedure}</param>
        /// <param name="paras"></param>
        /// <returns>Object</returns>
        protected object ExecScalar(string cmdtext, CommandType cmdtypt = CommandType.StoredProcedure, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(DataBasecon))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmdtypt;
                cmd.Parameters.AddRange(paras);
                object Result = cmd.ExecuteScalar();
                conn.Close();
                return Result;
            }
        }
        /// <summary>
        /// Method for the non query methods {Insert - Update - Delete}
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="cmdtypt">Comand type {text - store procedure}</param>
        /// <param name="paras"></param>
        /// <returns>Numder of the rows which effected</returns>
        protected int ExecNonQuery(string cmdtext, CommandType cmdtypt = CommandType.StoredProcedure, params SqlParameter[] paras)
        {
            //try
            //{
                using (SqlConnection conn = new SqlConnection(DataBasecon))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(cmdtext, conn);
                    cmd.CommandType = cmdtypt;
                    cmd.Parameters.AddRange(paras);
                    int Result = cmd.ExecuteNonQuery();
                    conn.Close();
                    return Result;
                }
        //}
        //    catch (Exception ex)
        //    {
        //        return -1;
        //    }
}
        /// <summary>
        /// Method of the Selection 
        /// </summary>
        /// <param name="cmdtext"></param>
        /// <param name="cmdtypt"> Comand type {text - store procedure} </param>
        /// <param name="paras"></param>
        /// <returns> Return the same table from Database </returns>
        protected DataTable ExecReader(string cmdtext, CommandType cmdtypt = CommandType.StoredProcedure, params SqlParameter[] paras)
        {
            using (SqlConnection conn = new SqlConnection(DataBasecon))
            {
                SqlCommand cmd = new SqlCommand(cmdtext, conn);
                cmd.CommandType = cmdtypt;
                cmd.Parameters.AddRange(paras);
                DataTable dt = new DataTable();
                SqlDataAdapter dapt = new SqlDataAdapter(cmd);
                dapt.Fill(dt);
                return dt;
            }
        }
        /// <summary>
        /// To create SQL Paramneter Object 
        /// </summary>
        /// <param name="name"> Name Of Paramenter</param>
        /// <param name="value">Value Of Paramenter</param>
        /// <returns> SqlParamter Object </returns>
        protected SqlParameter CreateParameters(string name, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.SqlValue = value;
            return para;
        }
        /// <summary>
        /// To create SQL Paramneter Object 
        /// </summary>
        /// <param name="name"> Name Of Paramenter</param>
        /// <param name="type"> Type Of Paramenter</param>
        /// <param name="value">Value Of Paramenter</param>
        /// <returns> SqlParamter Object </returns>
        protected SqlParameter CreateParameters(string name, SqlDbType Type, object value)
        {
            SqlParameter para = new SqlParameter();
            para.ParameterName = name;
            para.SqlDbType = Type;
            para.SqlValue = value;
            return para;
        }
        /// <summary>
        ///  Open Connection Method
        /// </summary>
        /// <param name="connection"> Object Of SqlConnection </param>
        protected void OpenConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        /// <summary>
        ///  Close Connection Method
        /// </summary>
        /// <param name="connection"> Object Of SqlConnection </param>
        protected void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Dispose();
                connection.Close();
            }
        }
        /// <summary>
        ///  To Dispose Object Of Data Access Layer 
        /// </summary>
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            GC.Collect(GC.GetGeneration(this), GCCollectionMode.Forced);
        }
        ///// <summary>
        ///// To Execute Reader 
        ///// Notes : This Method is Abstract Method 
        ///// </summary>
        ///// <param name="cmdtext"> Command text </param>
        ///// <param name="cmdtypt"> Command type Text Or Procedure</param>
        ///// <param name="paras">Array Of SqlParamenters </param>
        ///// <returns> T Generic As Business Object </returns>
        //protected abstract T ExecReaderAsObject(string cmdtext, CommandType cmdtypt = CommandType.Text, params SqlParameter[] paras);
        /// <summary>
        /// desconstructor
        /// </summary>
        ~DataAcessLayer()
        {
            this.Dispose();
        }
    }
}
