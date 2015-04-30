using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CCAIDemo.Utility;

namespace CCAIDemo.BusinessLogic
{
    public class BaseMgrNonGeneric
    {
        /// <summary>
        /// 根据Sql得到查询的数据集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataSet GetDataSetBySql(string sql)
        {
            return new BaseMgrNonGeneric().GetDataSetBySql(sql);
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
            return new BaseMgrNonGeneric().GetDataSetBySqlPaged(pageHelper, sql, orderBy);
        }
    }
}
