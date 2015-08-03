using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;
using System.Xml;

namespace CCAIDemo.DataAccess
{
    public static class SqlHelper
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["Provider"].ConnectionString;

        #region 创建数据库连接
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static SqlConnection GetConnection(string connStr)
        {
            return new SqlConnection(connStr);
        }
        #endregion

        #region 创建SqlCommand

        /// <summary>
        /// 初始化DbCommand对象
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op">DbParameter数组</param>
        /// <returns>DbCommand对象</returns>
        private static  SqlCommand BuildInitCommand(SqlConnection conn, string commandText, CommandType commandType, SqlParameter[] op)
        {
            SqlCommand Command = new SqlCommand();
            Command.Connection = conn;
            Command.CommandType = commandType;
            Command.CommandText = commandText;
            if (op != null)
            {
                foreach (SqlParameter p in op)
                {
                    //check for derived output value with no value assigned
                    if ((p.Direction == ParameterDirection.InputOutput) && (p.Value == null))
                    {
                        p.Value = DBNull.Value;
                    }

                    Command.Parameters.Add(p);
                }
            }
            return Command;
        }

        #endregion

        #region 无事务的操作
         /// <summary>
        /// 执行T-Sql语句,返回受影响的行数
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op=null)
        {
            return ExecuteNonQuery(connectionString, commandText, commandType,op);
        }

        /// <summary>
        /// 执行T-Sql语句,返回受影响的行数
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connStr, string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op=null)
        {
            int flagValue;
            
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                SqlCommand Command = BuildInitCommand(connection,commandText, commandType, op);
                flagValue = Command.ExecuteNonQuery();
            }
            return flagValue;
        }
     

        /// <summary>
        /// 执行T-Sql语句,返回第一行第一列,需要用户自己打开数据库连接和关闭连接
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
         public static object ExecuteScalar(string commandText, CommandType commandType=CommandType.Text, SqlParameter[] op=null)
        {
           return ExecuteScalar(connectionString,commandText,commandType,op);
        }

        /// <summary>
        /// 执行带参数的T-Sql语句,返回第一行第一列
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <param name="op"></param>
        /// <returns></returns>
         public static object ExecuteScalar(string connStr, string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
         {
             object flagValue = null;
             using (SqlConnection connection = new SqlConnection(connStr))
             {
                 SqlCommand Command = BuildInitCommand(connection, commandText, commandType, op);
                 flagValue = Command.ExecuteScalar();
             }
             return flagValue;
         }

         public static SqlDataReader ExecuteReader(string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
         {
             return ExecuteReader(connectionString, commandText, commandType, op);
         }

        /// <summary>
        /// 执行T-Sql语句，返回SqlDataReader
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string connStr,string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
        {
           
            SqlCommand cmd = new SqlCommand();
            SqlConnection conn = new SqlConnection(connectionString);
            // we use a try/catch here because if the method throws an exception we want to 
            // close the connection throw code, because no datareader will exist, hence the 
            // commandBehaviour.CloseConnection will not work
            try
            {
                SqlCommand Command = BuildInitCommand(conn, commandText, commandType, op);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return rdr;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
 
        }
   
        public static DataSet ExecuteDataSet( string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
        {
            return ExecuteDataSet(connectionString, commandText, commandType, op);
        }

        /// <summary>
        /// 执行T-Sql语句,返回DataSet;
        /// </summary>
        /// <param name="commandText"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string connStr, string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
        {
            DataSet Ds = new DataSet();
            SqlDataAdapter Adapter = new SqlDataAdapter();
            using (SqlConnection connection = new SqlConnection())
            {
                Adapter.SelectCommand = BuildInitCommand(connection,commandText, commandType,op);
                Adapter.Fill(Ds);
            }
            return Ds;
        }

        public static XmlReader ExecuteXmlReader(string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
        {
            return ExecuteXmlReader(connectionString, commandText, commandType, op);
        }
    
        /// <summary>
        /// 执行T-Sql语句，返回XmlReader,开发者使用完该方法
        /// </summary>
        /// <param name="commandText">T-Sql语句</param>
        /// <returns></returns>
        public static XmlReader ExecuteXmlReader(string connStr, string commandText, CommandType commandType = CommandType.Text, SqlParameter[] op = null)
        {

            SqlConnection conn = new SqlConnection();
            try
            {
                SqlCommand Command = BuildInitCommand(conn, commandText, commandType, op);
                XmlReader Reader = Command.ExecuteXmlReader();
                return Reader;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conn != null && conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 执行事务，返回0或者1
        /// </summary>
        /// <param name="Sqlstr">sql语句</param>
        /// <returns></returns>
        public static int ExecTran(string[] Sqlstr)
        {
            SqlConnection conn = GetConnection();
            SqlTransaction tran=null;
            try
            {
                conn.Open();
                tran = conn.BeginTransaction();//先实例SqlTransaction类，使用这个事务使用的是con 这个连接，使用BeginTransaction这个方法来开始执行这个事务

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.Transaction = tran;


                int count = Sqlstr.Length;
                for (int i = 0; i < count; i++)
                {
                    cmd.CommandText = Sqlstr[i];
                    cmd.ExecuteNonQuery();
                }
                tran.Commit();
                return 1;
            }
            catch (Exception ex)
            {
                if (tran != null)
                    tran.Rollback();
                throw ex;
            }
            finally
            {
                tran.Dispose();
                Close(conn);
            }
        }

        #endregion

        /// <summary>
        /// 关闭数据库连接,当不是调用系统提供的方法，而是单独处理数据库时，才需要调用Close
        /// </summary>
        public static void Close(SqlConnection connection)
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                connection.Close();
                connection.Dispose();
            }
        }
    }
}
