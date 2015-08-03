using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.DataAccess;
using CCAIDemo.Utility;

namespace CCAIDemo.BusinessLogic
{
    public class BaseMgr<T> : BaseMgrNonGeneric where T : new()
    {

        /// <summary>
        /// 根据主键值得到实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual T GetEntityByPrimaryKey(string primaryKeyValue)
        {
            return new BaseDataAccess<T>().GetEntityByPrimaryKey(primaryKeyValue);
        }

        /// <summary>
        /// 根据条件得到实体对象集合
        /// 参数设置类似：queryCondition=" and Name='abc' and Age=23";orderBy=" ID desc,Age asc"
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual IList<T> GetEntitiesByQueryCondition(string queryCondition, string orderBy = null)
        {
            return new BaseDataAccess<T>().GetEntitiesByQueryCondition(queryCondition,orderBy);
        }

        /// <summary>
        /// 根据条件和分页条件得到实体对象集合
        /// 参数设置类似：queryCondition=" and Name='abc' and Age=23";orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="pageHelper"></param>
        /// <param name="queryCondition"></param>
        /// <param name="orderBy"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual IList<T> GetEntitiesByQueryConditionPaged(PageHelper pageHelper, string queryCondition, string orderBy = null)
        {
            return new BaseDataAccess<T>().GetEntitiesByQueryConditionPaged(pageHelper, queryCondition, orderBy);
        }

        /// <summary>
        /// 保存实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int SaveEntity(T t)
        {
            return new BaseDataAccess<T>().SaveEntity(t);
        }

        /// <summary>
        /// 得到保存实体对象的SQL，既可以插入也可以更新，主要用于事务中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual string GetSaveEntitySQL(T t)
        {
            return new BaseDataAccess<T>().GetSaveEntitySQL(t);
        }

        /// <summary>
        /// 删除实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual int DeleteEntity(T t)
        {
            return new BaseDataAccess<T>().DeleteEntity(t);
        }

        /// <summary>
        /// 得到删除对象的SQL语句，主要用于事务中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual string GetDeleteEntitySQL(T t)
        {
            return new BaseDataAccess<T>().GetDeleteEntitySQL(t);
        }

        /// <summary>
        /// 根据主键值来删除对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual int DeleteEntityByPrimaryKey(string primaryKeyValue)
        {
            return new BaseDataAccess<T>().DeleteEntityByPrimaryKey(primaryKeyValue);
        }

        /// <summary>
        /// 得到根据主键值来删除对象的SQL，用于事务中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="primaryKeyValue"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual string GetDeleteEntityByPrimaryKeySQL(string primaryKeyValue)
        {
            return new BaseDataAccess<T>().GetDeleteEntityByPrimaryKeySQL(primaryKeyValue);
        }


        /// <summary>
        /// 根据条件删除实体对象
        /// 参数设置类似：queryCondition=" and Name='abc' and Age=23"; orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual int DeleteEntityByQueryCondition(string queryCondition)
        {
            return new BaseDataAccess<T>().DeleteEntityByQueryCondition(queryCondition);
        }

        /// <summary>
        /// 得到根据条件删除实体对象的SQL，用于事务中
        /// 参数设置类似：queryCondition=" and Name='abc' and Age=23"; orderBy=" ID desc,Age asc"
        /// </summary>
        /// <param name="queryCondition"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public virtual string GetDeleteEntityByQueryConditionSQL(string queryCondition)
        {
            return new BaseDataAccess<T>().GetDeleteEntityByQueryConditionSQL(queryCondition);
        }
    }
}
