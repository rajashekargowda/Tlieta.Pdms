using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace Tlieta.DataAccess
{
    public sealed class DBManagerFactory
    {
        //All function can return Oracle,OleDB objects depending on a provider parameter

        #region Constructor 
        private DBManagerFactory() { }
        #endregion 

        #region Get connection object 
        public static IDbConnection GetConnection()
        {
            IDbConnection iDbConnection = new SqlConnection();
            return iDbConnection;
        }
        #endregion

        #region Get command object 
        public static IDbCommand GetCommand()
        {
            return new SqlCommand();
        }
        #endregion

        #region Get data adapter object 
        public static IDbDataAdapter GetDataAdapter()
        {
            return new SqlDataAdapter();
        }
        #endregion 

        #region Get the transaction object 
        public static IDbTransaction GetTransaction()
        {
            IDbConnection iDbConnection = GetConnection();
            IDbTransaction iDbTransaction = iDbConnection.BeginTransaction();
            return iDbTransaction;
        }
        #endregion

        #region Get parameters object 
        public static IDataParameter GetParameter()
        {
            IDataParameter iDataParameter = new SqlParameter();
            return iDataParameter;
        }
        #endregion 

        #region Get parameters object based on the number of parameters 
        public static IDbDataParameter[] GetParameters(int paramsCount)
        {
            IDbDataParameter[] idbParams = new IDbDataParameter[paramsCount];
            for (int i = 0; i < paramsCount; ++i)
            {
                idbParams[i] = new SqlParameter();
            }
            return idbParams;
        }
        #endregion
    }
}
