using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    public sealed class CacheService
    {
        private static readonly CacheService _instance = new CacheService();

        private readonly Dictionary<string, object> _cache = new Dictionary<string, object>();

        private CacheService()
        {
            Console.WriteLine("(Экземпляр CacheService создан)");
        }

        public static CacheService GetInstance()
        {
            return _instance;
        }
        public void Add(string key, object value)
        {
            _cache[key] = value;
            Console.WriteLine($"Данные '{key}' добавлены.");
        }

        public object? Get(string key)
        {
            return _cache.ContainsKey(key) ? _cache[key] : null;
        }
    }
}
