using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using CCAIDemo.Entity;

namespace CCAIDemo.DAL
{
    public class BaseDAL<T> where T:new ()
    {
        public bool Insert(T t)
        {
            //TODO 解析T，通过反向工程构造SQL
            foreach (PropertyInfo pi in typeof(T).GetProperties())
            {
                object value1 = pi.GetValue(t, null);//用pi.GetValue获得值
                string name = pi.Name;//获得属性的名字,后面就可以根据名字判断来进行些自己想要的操作
                //获得属性的类型,进行判断然后进行以后的操作,例如判断获得的属性是整数
                if (value1.GetType() == typeof(int))
                {
                    //进行你想要的操作
                }
            }
            return true;
        }

        public bool Update(T t)
        {
            //TODO 解析T，通过反向工程构造SQL
            return true;
        }

        public bool Delete(T t)
        {
            //TODO 解析T，通过反向工程构造SQL
            return true;
        }

        public T GetEntityByPrimaryKey<T>(string primaryKeyValue)
        {
            T entity = Activator.CreateInstance<T>();

            object[] tableAttributeArray = typeof(T).GetCustomAttributes(typeof(TableAttribute), false);
            if (tableAttributeArray.Length == 0)
                return entity;
            TableAttribute ta = tableAttributeArray[0] as TableAttribute;
            string tableName = ta.TableName;
            string primaryKeyColumn = ta.PrimaryKeyColumn;

            string sql = "select * from " + tableName + " where " + primaryKeyColumn + "=" + primaryKeyValue;

            foreach (PropertyInfo info in typeof(T).GetProperties())
            {
                
            }
            return entity;
        }
    }
}
