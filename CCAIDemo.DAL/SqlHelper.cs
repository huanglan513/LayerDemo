using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Xml;

namespace CCAIDemo.DAL
{
    public class SqlHelper
    {
        public static SqlConnection Connection;

          /// <summary>
        /// 初始化Dbconnection对象
        /// </summary>
        /// <returns></returns>
        private static SqlConnection buildInitConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Provider"].ConnectionString;
            Connection=new SqlConnection(connectionString);
            return Connection;

        }
        /// <summary>
        /// 默认构造函数(初始化DbConnection)
        /// </summary>
        public SqlHelper()
        {
            buildInitConnection();
        }

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <returns></returns>
        private SqlCommand BuildInitCommand(CommandType commandType)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = commandType;
            return Command;
        }
        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns>DbCommand对象</returns>
        private static SqlCommand BuildInitCommand(string commandText, CommandType commandType)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = commandType;
            Command.CommandText = commandText;
            return Command;
        }

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op">DbParameter数组</param>
        /// <returns>DbCommand对象</returns>
        private SqlCommand BuildInitCommand(string commandText, CommandType commandType,SqlParameter[] op)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = Connection;
            Command.CommandType = commandType;
            Command.CommandText = commandText;
            foreach (SqlParameter p in op)
            {
                //check for derived output value with no value assigned
                if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                {
                    p.Value = DBNull.Value;
                }
				
                Command.Parameters.Add(p);
            }
            return Command;
        }

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op">DbParameter数组</param>
        /// <returns>DbCommand对象</returns>
        private SqlCommand BuildInitCommand(string commandText, CommandType commandType, SqlParameter[] op,SqlTransaction tran)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = tran.Connection;
            Command.Transaction = tran;
            Command.CommandType = commandType;
            Command.CommandText = commandText;
            foreach (SqlParameter p in op)
            {
                //check for derived output value with no value assigned
                if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                {
                    p.Value = DBNull.Value;
                }

                Command.Parameters.Add(p);
            }
            return Command;
        }

        /// <summary>
        /// 执行T-Sql语句,返回受影响的行数
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string commandText,CommandType commandType)
        {
            int flagValue;
            SqlCommand Command = BuildInitCommand(commandText,commandType);
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
        public int ExecuteNonQuery(string commandText, CommandType commandType,SqlParameter[] op)
        {
            int flagValue;
            SqlCommand Command = BuildInitCommand(commandText,commandType, op);
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
        public Object ExecuteScalar(string commandText,CommandType commandType)
        {
            SqlCommand Command = BuildInitCommand(commandText,commandType);
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
        public object ExecuteScalar(string commandText,CommandType commandType, SqlParameter[] op)
        {
            SqlCommand Command = BuildInitCommand(commandText,commandType, op);
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
        public SqlDataReader ExecuteReader(string commandText,CommandType commandType)
        {
            SqlCommand Command = BuildInitCommand(commandText,commandType);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }
        /// <summary>
        /// 执行带参数的T-Sql语句，返回DbDataReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
        public SqlDataReader ExecuteReader(string commandText,CommandType commandType, SqlParameter[] op)
        {
            SqlCommand Command = BuildInitCommand(commandText,commandType,op);
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader(CommandBehavior.CloseConnection);
            return Reader;
        }

        /// <summary>
        /// 执行T-Sql语句,返回DataSet;
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataSet ExecuteDataSet(string commandText, CommandType commandType,string tableName)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText, commandType);
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
        public DataSet ExecuteDataSet(string commandText, CommandType commandType, SqlParameter[] op, string tableName)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText, commandType,op);
            DataSet Ds = new DataSet();
            Connection.Open();
            Adapter.Fill(Ds, tableName);
            Connection.Close();
            return Ds;
        }

        public DataTable ExecuteDataTable(string commandText, CommandType commandType)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText, commandType);
            Connection.Open();
            Adapter.Fill(dataTable);
            Connection.Close();
            return dataTable;
        }

        public DataTable ExecuteDataTable(string commandText, CommandType commandType, SqlParameter[] op)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            Adapter.SelectCommand = BuildInitCommand(commandText, commandType, op);
            Connection.Open();
            Adapter.Fill(dataTable);
            Connection.Close();
            return dataTable;
        }

        /// <summary>
        /// 执行T-Sql语句，返回XmlReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public XmlReader ExecuteXmlReader(string commandText, CommandType commandType)
        {
            SqlCommand Command = BuildInitCommand(commandText, commandType);
            Connection.Open();
            XmlReader Reader = Command.ExecuteXmlReader();
            Connection.Close();
            return Reader;
        }
        /// <summary>
        /// 执行带参数的T-Sql语句，返回XmlReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
        public XmlReader ExecuteXmlReader(string commandText, CommandType commandType, SqlParameter[] op)
        {
            SqlCommand Command = BuildInitCommand(commandText, commandType, op);
            Connection.Open();
            XmlReader Reader = Command.ExecuteXmlReader();
            Connection.Close();
            return Reader;
        }

        public int ExecuteNonQuery(string commandText, CommandType commandType, SqlParameter[] op,SqlTransaction tran)
        {
            SqlCommand Command = BuildInitCommand(commandText, commandType, op, tran);
            int flagValue = Command.ExecuteNonQuery();
            return flagValue;
        }


        /// <summary>
        /// 执行数据库事务
        /// </summary>
        /// <param name="sqlStringList"></param>
        public void ExecuteTransaction(ArrayList sqlStringList,CommandType commandType)
        {
            Connection.Open();
            SqlTransaction tran = Connection.BeginTransaction();
            SqlCommand Command = BuildInitCommand(commandType);
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
            catch (SqlException E)
            {
                tran.Rollback();
                throw new Exception(E.Message);
            }
        }
    }
}
