using System;
using System.Collections.Concurrent;
using System.Threading;

namespace _02_Flyweight_Map
{
    public class LazyConcurrentDictionary<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> concurrentDictionary;
        public int Count => concurrentDictionary.Count;
        public LazyConcurrentDictionary()
        {
            concurrentDictionary = new ConcurrentDictionary<TKey, Lazy<TValue>>();
        }
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) =>
            concurrentDictionary.GetOrAdd(key,
                k => new Lazy<TValue>(() => valueFactory(k), LazyThreadSafetyMode.ExecutionAndPublication)).Value;
    }
}
