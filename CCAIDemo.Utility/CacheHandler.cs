using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using System.Collections;

namespace CCAIDemo.Utility
{
    /// <summary>
    /// This class reads/writes to ASP .NET server cache. For the sake of
    /// simplicity, the class writes objects to cache with no expirateion.
    /// Use the Remove() function to programmatically remove objects stored
    /// from the server cache. This class was created as an alternative  to
    /// storing large objects in the session.
    /// </summary>
    public static class CacheHandler
    {
        private static System.Web.Caching.Cache cache;
        private static double _SaveTime;

        /// <summary>
        /// 缓存保存时间,以分钟计算,默认分钟
        /// </summary>
        public static double SaveTime
        {
            get { return _SaveTime; }
            set { _SaveTime = value; }
        }

        static CacheHandler()
        {
            cache = System.Web.HttpContext.Current.Cache;
            _SaveTime = 30.0;
        }

        #region Get Methods
        /// <summary>
        /// 获取缓存对象
        /// </summary>
        /// <param name="key">key</param>
        /// <returns>object</returns>
        public static object Get(string key)
        {
            return cache.Get(key);
        }
        /// <summary>
        /// 获取缓存数据，需要传入类型
        /// </summary>
        public static T Get<T>(string key)
        {
            object obj = Get(key);
            if (obj == null)
            {
                return default(T);
            }
            else
            {
                return (T)obj;
            }
        }
        /// <summary>
        /// 获取所有缓存对象的key
        /// </summary>
        /// <returns>返回一个IList对象</returns>
        public static IList<string> GetKeys()
        {
            List<string> keys = new List<string>();
            IDictionaryEnumerator cacheItem = HttpRuntime.Cache.GetEnumerator();
            while (cacheItem.MoveNext())
            {
                keys.Add(cacheItem.Key.ToString());
            }
            return keys.AsReadOnly();
        }
        #endregion

        #region Insert Method
        /// <summary>
        /// 插入对象到缓存中
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">对象</param>
        /// <param name="dependency">对象依赖</param>
        /// <param name="priority">优先级</param>
        /// <param name="callback">缓存删除时的回调事件</param>
        public static void Insert(string key, object value, CacheDependency dependency, CacheItemPriority priority, CacheItemRemovedCallback callback)
        {

            cache.Insert(key, value, dependency, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromMinutes(SaveTime), priority, callback);
        }
        /// <summary>
        /// 插入对象到缓存中
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">对象</param>
        /// <param name="dependency">对象依赖</param>
        /// <param name="callback">缓存删除时的回调事件</param>
        public static void Insert(string key, object value, CacheDependency dependency, CacheItemRemovedCallback callback)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, callback);
        }
        /// <summary>
        /// 插入对象到缓存中
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">对象</param>
        /// <param name="dependency">对象依赖</param>
        public static void Insert(string key, object value, CacheDependency dependency)
        {
            Insert(key, value, dependency, CacheItemPriority.Default, null);
        }
        /// <summary>
        /// 插入对象到缓存中
        /// </summary>
        /// <param name="key">key</param>
        /// <param name="value">对象</param>
        public static void Insert(string key, object value)
        {
            Insert(key, value, null, CacheItemPriority.Default, null);
        }
        #endregion

        #region Remove Method
        public static void Remove(string cacheID)
        {
            if (HttpContext.Current == null)
                return;

            if (cacheID == null || cacheID.Equals(""))
                return;
            HttpRuntime.Cache.Remove(cacheID);
        }

        /// <summary>
        /// 删除全部缓存
        /// </summary>
        public static void RemoveAll()
        {
            IList<string> keys = GetKeys();
            foreach (string key in keys)
            {
                HttpRuntime.Cache.Remove(key);
            }
        }
        #endregion


    }

}
