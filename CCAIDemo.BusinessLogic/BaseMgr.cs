using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.DataAccess;
using CCAIDemo.Utility;

namespace CCAIDemo.BusinessLogic
{
    //范例见ConsoleApp工程
    public class BaseMgr<T> where T : new()
    {
        /// <summary>
        /// 根据主键值得到实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual T GetEntityByPrimaryKey(string primaryKeyValue, Trans tran = null)
        {
            return new BaseDataAccess<T>().GetEntityByPrimaryKey(primaryKeyValue, tran);
        }

        /// <summary>
        /// 根据条件得到实体对象集合
        /// 参数设置类似：queryCondition=" Name='abc' and Age=23";orderBy=" ID desc,Age asc"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual IList<T> GetEntitiesByQueryCondition(string queryCondition, string orderBy = null, Trans tran = null)
        {
            return new BaseDataAccess<T>().GetEntitiesByQueryCondition(queryCondition,orderBy, tran);
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
        public virtual IList<T> GetEntitiesByQueryConditionPaged(PageHelper pageHelper, string queryCondition, string orderBy = null, Trans tran = null)
        {
            return new BaseDataAccess<T>().GetEntitiesByQueryConditionPaged(pageHelper, queryCondition, orderBy, tran);
        }

        /// <summary>
        /// 保存实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int SaveEntity(T t, Trans tran = null)
        {
            return new BaseDataAccess<T>().SaveEntity(t,tran);
        }

        /// <summary>
        /// 删除实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int DeleteEntity(T t, Trans tran = null)
        {
            return new BaseDataAccess<T>().DeleteEntity(t,tran);
        }

        /// <summary>
        /// 根据主键值来删除对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual int DeleteEntityByPrimaryKey(string primaryKeyValue, Trans tran = null)
        {
            return new BaseDataAccess<T>().DeleteEntityByPrimaryKey(primaryKeyValue, tran);
        }

        /// <summary>
        /// 根据条件删除实体对象
        /// 参数设置类似：queryCondition=" Name='abc' and Age=23"; orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual int DeleteEntityByQueryCondition(string queryCondition, Trans tran = null)
        {
            return new BaseDataAccess<T>().DeleteEntityByQueryCondition(queryCondition, tran);
        }
    }
}
