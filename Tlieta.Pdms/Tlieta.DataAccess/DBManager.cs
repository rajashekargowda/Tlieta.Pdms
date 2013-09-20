using System;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Configuration;

namespace Tlieta.DataAccess
{
    public sealed class DBManager : IDBManager, IDisposable
    {
        #region Local variables 
        private IDbConnection idbConnection;
        private IDataReader idataReader;
        private IDbCommand idbCommand;
        private IDbTransaction idbTransaction = null;
        private IDbDataParameter[] idbParameters = null;
        private string strConnection;
        #endregion 

        #region Dataacess properties 
        public IDbConnection Connection
        {
            get
            {
                return idbConnection;
            }
        }

        public IDataReader DataReader
        {
            get
            {
                return idataReader;
            }
            set
            {
                idataReader = value;
            }
        }

        public string ConnectionString
        {
            get
            {
                return strConnection;
            }
            set
            {
                strConnection = value;
            }
        }

        public IDbCommand Command
        {
            get
            {
                return idbCommand;
            }
        }

        public IDbTransaction Transaction
        {
            get
            {
                return idbTransaction;
            }
        }

        public IDbDataParameter[] Parameters
        {
            get
            {
                return idbParameters;
            }
        }
        #endregion

        #region Constructor declarations
        public DBManager()
        {
            this.strConnection = ConfigurationSettings.AppSettings["DBConnectionString"].ToString();
        }

        public DBManager(string connectionString)
        {
            this.strConnection = connectionString;
        }
        #endregion

        #region Open Database Connection 
        public void Open()
        {
            idbConnection = DBManagerFactory.GetConnection();
            idbConnection.ConnectionString = this.ConnectionString;
            if (idbConnection.State != ConnectionState.Open)
                idbConnection.Open();
            this.idbCommand = DBManagerFactory.GetCommand();
        }
        #endregion

        #region Close Database Connection 
        public void Close()
        {
            if (idbConnection.State != ConnectionState.Closed)
                idbConnection.Close();
        }
        #endregion 

        #region Dispose Database Object 
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.Close();
            this.idbCommand = null;
            this.idbTransaction = null;
            this.idbConnection = null;
        }
        #endregion 

        #region Create Parameters 
        public void CreateParameters(int paramsCount)
        {
            idbParameters = new IDbDataParameter[paramsCount];
            idbParameters = DBManagerFactory.GetParameters(paramsCount);
        }
        #endregion

        #region Add the parameters 
        public void AddParameters(int index, string paramName, object objValue)
        {
            if (index < idbParameters.Length)
            {
                idbParameters[index].ParameterName = paramName;
                idbParameters[index].Value = objValue;
            }
        }
        #endregion 

        #region Begin the transaction 
        public void BeginTransaction()
        {
            if (this.idbTransaction == null)
                idbTransaction = DBManagerFactory.GetTransaction();
            this.idbCommand.Transaction = idbTransaction;
        }
        #endregion 

        #region Commit the trasaction 
        public void CommitTransaction()
        {
            if (this.idbTransaction != null)
                this.idbTransaction.Commit();
            idbTransaction = null;
        }
        #endregion

        #region Method to execute the reader 
        public IDataReader ExecuteReader(CommandType commandType, string commandText)
        {
            this.idbCommand = DBManagerFactory.GetCommand();
            idbCommand.Connection = this.Connection;
            PrepareCommand(idbCommand, this.Connection, this.Transaction, commandType, commandText, this.Parameters);
            this.DataReader = idbCommand.ExecuteReader();
            idbCommand.Parameters.Clear();
            return this.DataReader;
        }
        #endregion

        #region Method to close the reader 
        public void CloseReader()
        {
            if (this.DataReader != null)
                this.DataReader.Close();
        }
        #endregion

        #region Attach the parameters 
        private void AttachParameters(IDbCommand command, IDbDataParameter[] commandParameters)
        {
            foreach (IDbDataParameter idbParameter in commandParameters)
            {
                if ((idbParameter.Direction == ParameterDirection.InputOutput) && (idbParameter.Value == null))
                {
                    idbParameter.Value = DBNull.Value;
                }
                command.Parameters.Add(idbParameter);
            }
        }
        #endregion 

        #region Prepare the Command 
        private void PrepareCommand(IDbCommand command, IDbConnection connection,
          IDbTransaction transaction, CommandType commandType, string commandText, IDbDataParameter[] commandParameters)
        {
            command.Connection = connection;
            command.CommandText = commandText;
            command.CommandType = commandType;
            command.CommandTimeout = 1200;

            if (transaction != null)
            {
                command.Transaction = transaction;
            }

            if (commandParameters != null)
            {
                AttachParameters(command, commandParameters);
            }
        }
        #endregion 

        #region Execute the non-query 
        public int ExecuteNonQuery(CommandType commandType, string commandText)
        {
            this.idbCommand = DBManagerFactory.GetCommand();
            PrepareCommand(idbCommand, this.Connection, this.Transaction, commandType, commandText, this.Parameters);
            int returnValue = idbCommand.ExecuteNonQuery();
            idbCommand.Parameters.Clear();
            return returnValue;
        }
        #endregion 

        #region Execute scalar 
        public object ExecuteScalar(CommandType commandType, string commandText)
        {
            this.idbCommand = DBManagerFactory.GetCommand();
            PrepareCommand(idbCommand, this.Connection, this.Transaction, commandType, commandText, this.Parameters);
            object returnValue = idbCommand.ExecuteScalar();
            idbCommand.Parameters.Clear();
            return returnValue;
        }
        #endregion 
        
        #region Execute data set (get the dataset as return type) 
        public DataSet ExecuteDataSet(CommandType commandType, string commandText)
        {
            this.idbCommand = DBManagerFactory.GetCommand();
            PrepareCommand(idbCommand, this.Connection, this.Transaction, commandType, commandText, this.Parameters);
            IDbDataAdapter dataAdapter = DBManagerFactory.GetDataAdapter();
            dataAdapter.SelectCommand = idbCommand;
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            idbCommand.Parameters.Clear();
            return dataSet;
        }
        #endregion
    }
}
