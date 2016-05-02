using System.Runtime.Caching;

namespace LineupOptimizer.Domain.Services
{
    public static class CacheService
    {
        public static void AddObjectToCache(object item, string key)
        {
            ObjectCache cache = MemoryCache.Default;
            cache.Add(key, item, new CacheItemPolicy());
        }

        /// <summary>
        /// This returns an object that will need to be cast before used
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static object GetObjectFromCache(string key)
        {
            ObjectCache cache = MemoryCache.Default;
            object cachedItem = cache[key];
            return cachedItem;
        }

        public static void RemoveObjectFromCache(string key)
        {
            ObjectCache cache = MemoryCache.Default;
            cache.Remove(key);
        }
    }
}
