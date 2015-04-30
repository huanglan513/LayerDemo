using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Data.Common;
using System.Data;
using System.Configuration;

namespace CCAIDemo.DAL
{
    class DbHelper
    {
        private DbConnection Connection;
        private DbProviderFactory provider;
        private CommandType _CommandType;
        public CommandType CommandType
        {
            get { return _CommandType; }
            set { _CommandType = value; }
        }
        /// <summary>
        /// 初始化Dbconnection对象
        /// </summary>
        /// <returns></returns>
        private DbConnection buildInitConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Provider"].ConnectionString;
            if (ConfigurationManager.ConnectionStrings["Provider"].ProviderName == "System.Data.OleDb")
            {
                connectionString += HttpContext.Current.Server.MapPath(ConfigurationManager.ConnectionStrings["DataPath"].ConnectionString);
            }
            provider = DbProviderFactories.GetFactory(ConfigurationManager.ConnectionStrings["Provider"].ProviderName);
            Connection = provider.CreateConnection();
            Connection.ConnectionString = connectionString;
            return Connection;

        }
        /// <summary>
        /// 默认构造函数(初始化DbConnection)
        /// </summary>
        public DbHelper()
        {
            buildInitConnection();
            this._CommandType = CommandType.Text;
        }
        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <returns></returns>
        private DbCommand BuildInitCommand()
        {
            DbCommand Command = provider.CreateCommand();
            Command.Connection = Connection;
            Command.CommandType = this._CommandType;
            return Command;
        }
        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns>DbCommand对象</returns>
        private DbCommand BuildInitCommand(string commandText)
        {
            DbCommand Command = provider.CreateCommand();
            Command.Connection = Connection;
            Command.CommandType = this._CommandType;
            Command.CommandText = commandText;
            return Command;
        }
        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op">DbParameter数组</param>
        /// <returns>DbCommand对象</returns>
        private DbCommand BuildInitCommand(string commandText, DbParameter[] op)
        {
            DbCommand Command = provider.CreateCommand();
            Command.Connection = Connection;
            Command.CommandType = this._CommandType;
            Command.CommandText = commandText;
            foreach (DbParameter p in op)
            {
                Command.Parameters.Add(p);
            }
            return Command;
        }
        /// <summary>
        /// 执行T-Sql语句,返回受影响的行数
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public int ExecuteNonQuery(string commandText)
        {
            int flagValue;
            DbCommand Command = BuildInitCommand(commandText);
            Connection.Open();
            flagValue = Command.ExecuteNonQuery();
            Connection.Close();
            return flagValue;
        }
        /// <summary>
        /// 执行带数的T-Sql语句,返回受影响的行数
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string commandText, DbParameter[] op)
        {
            int flagValue;
            DbCommand Command = BuildInitCommand(commandText, op);
            Connection.Open();
            flagValue = Command.ExecuteNonQuery();
            Connection.Close();
            return flagValue;
        }
        /// <summary>
        /// 执行T-Sql语句,返回第一行第一列
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public Object ExecuteScalar(string commandText)
        {
            DbCommand Command = BuildInitCommand(commandText);
            Connection.Open();
            object flagValue = Command.ExecuteScalar();
            Connection.Close();
            return flagValue;
        }
        /// <summary>
        /// 执行带参数的T-Sql语句,返回第一行第一列
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
        public object ExecuteScalar(string commandText, DbParameter[] op)
        {
            DbCommand Command = BuildInitCommand(commandText, op);
            Connection.Open();
            object flagValue = Command.ExecuteScalar();
            Connection.Close();
            return flagValue;
        }
        /// <summary>
        /// 执行T-Sql语句，返回DbDataReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public DbDataReader ExecuteReader(string commandText)
        {
            DbCommand Command = BuildInitCommand(commandText);
            Connection.Open();
            DbDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }
        /// <summary>
        /// 执行带参数的T-Sql语句，返回DbDataReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
        public DbDataReader ExecuteReader(string commandText, DbParameter[] op)
        {
            DbCommand Command = BuildInitCommand(commandText, op);
            Connection.Open();
            DbDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }
        /// <summary>
        /// 执行T-Sql语句,返回DataSet;
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, string tableName)
        {
            DbDataAdapter Adapter = provider.CreateDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText);
            DataSet Ds = new DataSet();
            Connection.Open();
            Adapter.Fill(Ds, tableName);
            Connection.Close();
            return Ds;
        }
        /// <summary>
        /// 执行带参数的T-Sql语句,返回DataSet;
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="op"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, DbParameter[] op, string tableName)
        {
            DbDataAdapter Adapter = provider.CreateDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText, op);
            DataSet Ds = new DataSet();
            Connection.Open();
            Adapter.Fill(Ds, tableName);
            Connection.Close();
            return Ds;
        }
        /// <summary>
        /// 执行数据库事务
        /// </summary>
        /// <param name="sqlStringList"></param>
        public void ExecuteTransaction(System.Collections.ArrayList sqlStringList)
        {
            Connection.Open();
            DbTransaction tran = Connection.BeginTransaction();
            DbCommand Command = BuildInitCommand();
            Command.Transaction = tran;
            try
            {
                for (int i = 0; i < sqlStringList.Count; i++)
                {
                    Command.CommandText = sqlStringList[i].ToString();
                    Command.ExecuteNonQuery();
                }
                tran.Commit();
                Connection.Close();
            }
            catch (System.Data.Common.DbException E)
            {
                tran.Rollback();
                throw new Exception(E.Message);
            }
        }
    }
}
