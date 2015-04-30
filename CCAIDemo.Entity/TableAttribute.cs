using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCAIDemo.Entity
{
    public class TableAttribute : Attribute
    {
        public TableAttribute(string tableName)
        {
            this.TableName = tableName;
        }
        public TableAttribute(string tableName,string PrimaryKeyColumn)
        {
            TableName = tableName;
            this.PrimaryKeyColumn = PrimaryKeyColumn;
        }

        public string TableName
        {
            get;
            set;
        }

        public string PrimaryKeyColumn
        {
            get;
            set;
        }

        /// <summary>
        /// 是否为自增列
        /// </summary>
        public bool IsIndentity
        {
            get;
            set;
        }
            
    }

    public class ColumnAttribute : Attribute
    {
        public ColumnAttribute(string columnName)
        {
            this.ColumnName = columnName;
        }

        public string ColumnName
        {
            get;
            set;
        }
        /// <summary>
        /// 是否为自增列
        /// </summary>
        public bool IsIndentity
        {
            get;
            set;
        }
            

    }
}
