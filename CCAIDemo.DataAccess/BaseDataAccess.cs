using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using CCAIDemo.Utility;

namespace CCAIDemo.DataAccess
{
    public class BaseDataAccess<T> : BaseDataAccessNonGeneric where T : new()
    {
       /// <summary>
        /// 根据主键值得到实体对象
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="primaryKeyValue"></param>
       /// <param name="tran"></param>
       /// <returns></returns>
        public T GetEntityByPrimaryKey(string primaryKeyValue,Trans tran=null)
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
               
                    sdr = sqlHelper.ExecuteReader(sql, CommandType.Text,tran);
               
                
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
                throw (ex);
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

        /// <summary>
        /// 根据条件得到实体对象集合
        /// 参数设置类似：queryCondition=" Name='abc' and Age=23";orderBy=" ID desc,Age asc"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public IList<T> GetEntitiesByQueryCondition(string queryCondition, string orderBy=null, Trans tran = null)
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
                sql = "select * from [" + tableName + "] ";
            }
            else
            {
                sql = "select * from [" + tableName + "] where " + queryCondition;
            }
            if (!string.IsNullOrEmpty(orderBy))
            {
                sql += sql + " order by " + orderBy;
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
                throw (ex);
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

        /// <summary>
        /// 根据条件和分页条件得到实体对象集合
        /// 参数设置类似：queryCondition=" Name='abc' and Age=23";orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="pageHelper"></param>
        /// <param name="queryCondition"></param>
        /// <param name="orderBy"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public IList<T> GetEntitiesByQueryConditionPaged(PageHelper pageHelper,string queryCondition, string orderBy=null,  Trans tran = null)
        {
            IList<T> entityList = new List<T>();

            Type columnType = typeof(ColumnAttribute);

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return entityList;

            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryColumn = ta.PrimaryKeyColumn;

          
            string rowIdColumn = string.Empty;
            if (string.IsNullOrEmpty(orderBy) && string.IsNullOrEmpty(primaryColumn))
            {
                return entityList;
            }
            else if (!string.IsNullOrEmpty(orderBy))
            {
                rowIdColumn = "Row_number() over (order by " + orderBy + ") as RowID";
            }
            else
            {
                rowIdColumn = "Row_number() over (order by " + primaryColumn + " asc) as RowID";
            }

            int rowMin = pageHelper.PageSize * pageHelper.PageIndex;
            int rowMax=pageHelper.PageSize*(pageHelper.PageIndex+1);

            string sqlRecord = string.Empty;
            string sqlCount=string.Empty;
            if (string.IsNullOrEmpty(queryCondition))
            {
                sqlRecord = "select * from (select " + rowIdColumn + ",* from [" + tableName + "] ) as t where RowID>" + rowMin + " and RowID<=" + rowMax;
                sqlCount = "select Count(1) as RecordCount from [" + tableName + "]"; 
            }
            else
            {
                sqlRecord = "select * from (select " + rowIdColumn + ",* from [" + tableName + "] where  " + queryCondition + " ) as t where RowID>" + rowMin + " and RowID<=" + rowMax;
                sqlCount="select Count(1) as RecordCount from ["+tableName+"] where "+queryCondition;
            }

            string sql = sqlRecord + ";" + sqlCount;
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

                if (sdr.NextResult() && sdr.Read())
                {
                    object Count = sdr["RecordCount"];
                    if (Count != null)
                        pageHelper.RecordCount = int.Parse(Count.ToString());
                }
            }
            catch (Exception ex)
            {
                throw (ex);
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

        /// <summary>
        /// 保存实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int SaveEntity(T entity, Trans tran = null)
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

        /// <summary>
        /// 删除实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int DeleteEntity(T entity, Trans tran = null)
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
            int rowCount = sqlHelper.ExecuteNonQuery(sql, CommandType.Text,tran);

            return rowCount;
        }

        /// <summary>
        /// 根据主键值来删除对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int DeleteEntityByPrimaryKey(string primaryKeyValue, Trans tran = null)
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

        /// <summary>
        /// 根据条件删除实体对象
        /// 参数设置类似：queryCondition=" Name='abc' and Age=23"; orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public int DeleteEntityByQueryCondition(string queryCondition, Trans tran = null)
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

        private ColumnAttribute GetColumnAttribute(PropertyInfo propInfo)
        {
            object[] attributes = propInfo.GetCustomAttributes(typeof(ColumnAttribute), false);
            if (attributes.Length > 0)
            {
                return attributes[0] as ColumnAttribute;
            }
            else
                return null;
        }
    }
}
