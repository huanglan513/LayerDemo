using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CCAIDemo.Utility;
using System.Text.RegularExpressions;

namespace CCAIDemo.DataAccess
{
    public class BaseDataAccessNonGeneric
    {
        /// <summary>
        /// 根据Sql得到查询的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSetBySql(string sql)
        {
            DataSet ds = SqlHelper.ExecuteDataSet(sql, CommandType.Text);

            return ds;
        }

        /// <summary>
        /// 根据sql,排序条件和分页条件得到实体对象集合
        /// 参数设置类似：sql="select * from table1 where name like '%aa%'"; orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="pageHelper"></param>
        /// <param name="sql"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public DataSet GetDataSetBySqlPaged(PageHelper pageHelper, string sql, string orderBy)
        {
            if (string.IsNullOrEmpty(orderBy))
            {
                return null;
            }

            int rowMin = pageHelper.PageSize * pageHelper.PageIndex;
            int rowMax = pageHelper.PageSize * (pageHelper.PageIndex + 1);

            string rowIdColumn = "select Row_number() over (order by " + orderBy + ") as RowID,";
            Regex regex = new Regex("select", RegexOptions.IgnoreCase);
            string sqlPaged = "select * from (" + regex.Replace(sql, rowIdColumn) + ") as t where RowID>" + rowMin + " and RowID<=" + rowMax;

            Regex regexFrom = new Regex("From", RegexOptions.IgnoreCase);
            sql = regexFrom.Replace(sql, "from");
            string sqlCount = "select count(1) as RecordCount " + sql.Substring(sql.IndexOf("from"));

            DataSet ds = SqlHelper.ExecuteDataSet(sqlPaged + ";" + sqlCount, CommandType.Text);

            if (ds.Tables.Count >= 2 && !string.IsNullOrEmpty(ds.Tables[1].Rows[0]["RecordCount"].ToString()))
            {
                pageHelper.RecordCount = int.Parse(ds.Tables[1].Rows[0]["RecordCount"].ToString());
            }
            return ds;
        }
        
    }
}
