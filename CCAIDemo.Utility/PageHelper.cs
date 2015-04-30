using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

namespace CCAIDemo.Utility
{
    public class PageHelper
    {
        private bool _paging = true;
        /// <summary>
        /// 构造函数
        /// </summary>
        public PageHelper()
        {
            PageIndex = 0;
            PageSize = 10;
            SortExpress = new List<string>();
        }

        /// <summary>
        /// 是否分页
        /// </summary>
        public bool Paging
        {
            get { return _paging && PageSize > 0; }
            set { _paging = value; }
        }

        /// <summary>
        /// 数据数量，涉及总行数变更的查询时,赋值为null。备注：为NULL是查询总行数
        /// </summary>
        public int? RecordCount { get; set; }

        /// <summary>
        /// 每页大小
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount
        {
            get
            {
                if (RecordCount.HasValue)
                    return (int)(RecordCount.Value / PageSize) + ((RecordCount.Value % PageSize) == 0 ? 0 : 1);
                else
                    return 0;
            }
        }

        public List<string> SortExpress { get; set; }

        /// <summary>
        /// 按照指定字段排序，如果字段已经存在排序表达式中，则逆反排序方向
        /// </summary>
        /// <param name="expression">排序字段</param>
        /// <returns></returns>
        public PageHelper OrderBy(string expression)
        {
            var item = SortExpress.Select(c => c.Split(' ')).Where(c => c[0] == expression).FirstOrDefault();

            bool desc = false;
            if (item != null)
            {
                desc = item[1] != "desc";
            }
            SortExpress = new List<string>() { expression + (desc ? " desc" : " asc") };
            return this;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="desc"></param>
        /// <returns></returns>
        public PageHelper OrderBy(string expression, bool desc)
        {
            SortExpress = new List<string>() { expression + (desc ? " desc" : " asc") };
            return this;
        }
    }
}

