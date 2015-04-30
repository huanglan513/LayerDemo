using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Data;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;
using System.Data.SqlClient;
using CCAIDemo.Utility;
using CCAIDemo.BusinessLogic;
using System.Text.RegularExpressions;


namespace CCAIDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string sql = "seLect id,name fRom table where id=3";
            //Regex regexFrom = new Regex("From", RegexOptions.IgnoreCase);
            //sql = regexFrom.Replace(sql, "from");
            //string sqlCount = "select count(1) " + sql.Substring(sql.IndexOf("from"));

            //Console.WriteLine(sqlCount);

            //GetEntityByPrimaryKey<Function>("1");
            //GetEntityByPrimaryKey<Function>("25");

            Function fun = new Function();
          //  fun.FunctionID = 46;
            fun.FunctionName = "abcd";
            fun.ParentID = 0;

            PageHelper pageHelper = new PageHelper();
            
            using (Trans tran = new Trans())
            {
                try
                {
                //    SaveEntity<Function>(fun,tran);
                //    int a = int.Parse("anc");
                //    SaveEntity<Function>(fun,tran);

                    //BaseDataAccess<Function> da = new BaseDataAccess<Function>();
                    //IList<Function> funList=da.GetEntitiesByQueryConditionPaged(pageHelper, string.Empty,string.Empty,tran);
                    //if (pageHelper.RecordCount.HasValue)
                    //{
                    //    Console.WriteLine(pageHelper.RecordCount + "总记录");
                    //}

                  //  da.GetEntityByPrimaryKey("26",tran);
                  //  DeleteEntityByQueryCondition<Function>("FunctionID in (55,56)", tran);
                    tran.Commit();
                }
                catch(Exception ex)
                {
                    tran.RollBack();
                    Console.WriteLine(ex.StackTrace);
                }
            }
         //   CTContractBll bll = new CTContractBll();
            

            //BaseDataAccess<Function> da = new BaseDataAccess<Function>();
            //IList<Function> funList = da.GetEntitiesByQueryConditionPaged( pageHelper,"FunctionID in (2,7)", "FunctionName Desc");
            //if (pageHelper.RecordCount.HasValue)
            //{
            //    Console.WriteLine(pageHelper.RecordCount + "总记录");
            //}

         //  SaveEntity<Function>(fun);
          //  DeleteEntity<Function>(fun);
          //  SaveEntity<Function>(fun);
        //    BaseDataAccess da = new BaseDataAccess();
            //da.GetEntityByPrimaryKey<Function>("26");
          //  Console.WriteLine(da.SaveEntity<Function>(fun));
            Console.ReadKey();
        }
        public static T GetEntityByPrimaryKey<T>(string primaryKeyValue,Trans tran=null)
        {
            T entity = Activator.CreateInstance<T>();
            Type columnType = typeof(ColumnAttribute);

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return entity;

            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryKeyColumn = ta.PrimaryKeyColumn;
            if (string.IsNullOrEmpty(primaryKeyColumn))
                return default(T);

            string sql = "select * from [" + tableName + "] where [" + primaryKeyColumn + "]='" + primaryKeyValue + "'";

            SqlDataReader sdr = null;
            SqlHelper sqlHelper = new SqlHelper();
            try
            {

                sdr = sqlHelper.ExecuteReader(sql, CommandType.Text, tran);


                if (sdr.Read())
                {
                    foreach (PropertyInfo info in typeof(T).GetProperties())
                    {
                        string columnName = (info.GetCustomAttributes(columnType, false)[0] as ColumnAttribute).ColumnName;
                        //给属性赋值
                        if (sdr[columnName] != null)
                        {
                            info.SetValue(entity, Convert.ChangeType(sdr[columnName], info.PropertyType), null);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (tran == null)
                {
                    sqlHelper.Close();
                }
                if (sdr != null && !sdr.IsClosed)
                {
                    sdr.Close();
                }

            }


            return entity;
        }

        public static int SaveEntity<T>(T entity, Trans tran = null)
        {
            if (entity == null)
                return 0;

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)  //该实体类无表名，则返回0
                return 0;
            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryColumn = ta.PrimaryKeyColumn;

            string sql = string.Empty;

            StringBuilder sbInsert = new StringBuilder();
            StringBuilder sbInsertParam = new StringBuilder();
            StringBuilder sbUpdate = new StringBuilder();
            StringBuilder sbUpdateWhere = new StringBuilder();

            sbInsert.Append("insert into [" + tableName + "] (");
            sbInsertParam.Append(" values (");
            sbUpdate.Append("Update [" + tableName + "] \r\t set \r\t ");
            List<int> aa = new List<int>();

            PropertyInfo[] propertyInfos = typeof(T).GetProperties();
            List<SqlParameter> sqlParamList = new List<SqlParameter>();
            for (int i = 0; i < propertyInfos.Length; i++)
            {
                PropertyInfo propInfo = propertyInfos[i];
                ColumnAttribute columnAttr = GetColumnAttribute(propInfo);
                if (columnAttr == null)   //无列名，则不操作
                    continue;

                object propValue = propInfo.GetValue(entity, null);
                if (propValue == null)    //列值为null,只需修改UpdateSql
                {
                    sbUpdate.Append("[" + columnAttr.ColumnName + "] = NULL,");
                    continue;
                }

                if (columnAttr.ColumnName == primaryColumn)   //主键
                {
                    sql = "if not exists (select * from [" + tableName + "] where [" + primaryColumn + "]='" + propValue + "' ) \r\t begin \r\t";
                    sbUpdateWhere.Append(" Where [" + primaryColumn + "] = '" + propValue + "'");

                    if (columnAttr.IsIndentity)   //且是自增列，则不操作
                        continue;
                }

                sbInsert.Append("[" + columnAttr.ColumnName + "],");
                sbInsertParam.Append("'" + propValue + "',");

                sbUpdate.Append("[" + columnAttr.ColumnName + "] = '" + propValue + "',");

            }

            sql += sbInsert.Remove(sbInsert.Length - 1, 1).ToString() + ") " + sbInsertParam.Remove(sbInsertParam.Length - 1, 1).ToString() + ")" + " end \r\t else\r\t begin \r\t "
                + sbUpdate.Remove(sbUpdate.Length - 1, 1) + sbUpdateWhere + " \r\t end;";


            SqlHelper sqlHelper = new SqlHelper();
            int rowCount = sqlHelper.ExecuteNonQuery(sql, CommandType.Text, tran);
            return rowCount;
        }

        private static ColumnAttribute GetColumnAttribute(PropertyInfo propInfo)
        {
            object[] attributes = propInfo.GetCustomAttributes(typeof(ColumnAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0] as ColumnAttribute;
            }
            else
                return null;
        }

        public static int DeleteEntity<T>(T entity, Trans tran = null)
        {
            if (entity == null)
                return 0;

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return 0;
            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryColumn = ta.PrimaryKeyColumn;

            object primaryKeyValue = null;
            foreach (PropertyInfo propInfo in typeof(T).GetProperties())
            {
                ColumnAttribute columnAttr = GetColumnAttribute(propInfo);
                if (columnAttr != null && columnAttr.ColumnName == primaryColumn)
                {
                    primaryKeyValue = propInfo.GetValue(entity, null);
                    break;
                }
            }
            string sql = "delete from [" + tableName + "] where [" + primaryColumn + "]='" + primaryKeyValue + "'";

            SqlHelper sqlHelper = new SqlHelper();
            int rowCount = sqlHelper.ExecuteNonQuery(sql, CommandType.Text, tran);

            return rowCount;
        }

        public static int DeleteEntityByPrimaryKey<T>(string primaryKeyValue, Trans tran = null)
        {
            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return 0;
            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryColumn = ta.PrimaryKeyColumn;
            if (string.IsNullOrEmpty(primaryColumn))
                return 0;
          
            string sql = "delete from [" + tableName + "] where [" + primaryColumn + "]='" + primaryKeyValue + "'";

            SqlHelper sqlHelper = new SqlHelper();
            int rowCount = sqlHelper.ExecuteNonQuery(sql, CommandType.Text, tran);

            return rowCount;
        }

        public static int DeleteEntityByQueryCondition<T>(string queryCondition, Trans tran = null)
        {
            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return 0;
            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryColumn = ta.PrimaryKeyColumn;
            if (string.IsNullOrEmpty(primaryColumn))
                return 0;

            string sql = string.Empty;
            if (string.IsNullOrEmpty(queryCondition))
            {
                sql = "delete from [" + tableName + "]";
            }
            else
            {
                sql = "delete from [" + tableName + "] where 1=1 and " + queryCondition;
            }

            SqlHelper sqlHelper = new SqlHelper();
            int rowCount = sqlHelper.ExecuteNonQuery(sql, CommandType.Text, tran);

            return rowCount;
        }


        public static IList<T> GetEntitiesByQueryCondition<T>(string queryCondition, Trans tran = null)
        {
            IList<T> entityList = new List<T>();
         
            Type columnType = typeof(ColumnAttribute);

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return entityList;

            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;


            string sql = string.Empty;
            if (string.IsNullOrEmpty(queryCondition))
            {
                sql = "select * from [" + tableName + "] where 1=1 ";
            }
            else
            {
                sql = "select * from [" + tableName + "] where 1=1 and " + queryCondition;
            }

            SqlDataReader sdr = null;
            SqlHelper sqlHelper = new SqlHelper();
            try
            {

                sdr = sqlHelper.ExecuteReader(sql, CommandType.Text, tran);


                while (sdr.Read())
                {
                    T entity = Activator.CreateInstance<T>();
                    foreach (PropertyInfo info in typeof(T).GetProperties())
                    {
                        string columnName = (info.GetCustomAttributes(columnType, false)[0] as ColumnAttribute).ColumnName;
                        //给属性赋值
                        if (sdr[columnName] != null)
                        {
                            info.SetValue(entity, Convert.ChangeType(sdr[columnName], info.PropertyType), null);
                        }
                    }
                    entityList.Add(entity);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (tran == null)
                {
                    sqlHelper.Close();
                }
                if (sdr != null && !sdr.IsClosed)
                {
                    sdr.Close();
                }
            }
            return entityList;
        }
    }
}
