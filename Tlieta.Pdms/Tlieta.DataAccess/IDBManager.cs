﻿
using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Tlieta.DataAccess
{
    public interface IDBManager
    {
        #region Interface Properties 
        string ConnectionString
        { get; set; }

        IDbConnection Connection
        { get; }

        IDbTransaction Transaction
        { get; }

        IDataReader DataReader
        { get; }
        
        IDbCommand Command
        { get; }

        IDbDataParameter[] Parameters
        { get; }
        #endregion 

        #region Interface methods 
        void Open();
        void BeginTransaction();
        void CommitTransaction();
        void CreateParameters(int paramsCount);
        void AddParameters(int index, string paramName, object objValue);
        IDataReader ExecuteReader(CommandType commandType, string commandText);
        DataSet ExecuteDataSet(CommandType commandType, string commandText);
        object ExecuteScalar(CommandType commandType, string commandText);
        int ExecuteNonQuery(CommandType commandType, string commandText);
        void CloseReader();
        void Close();
        void Dispose();
        #endregion
    }
}
