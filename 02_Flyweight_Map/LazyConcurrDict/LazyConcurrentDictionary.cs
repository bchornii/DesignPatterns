using System;
using System.Collections.Concurrent;
using System.Threading;

namespace _02_Flyweight_Map
{
    public class LazyConcurrentDictionary<TKey, TValue>
    {
        private readonly ConcurrentDictionary<TKey, Lazy<TValue>> _concurrentDictionary;
        public int Count => _concurrentDictionary.Count;
        public LazyConcurrentDictionary()
        {
            _concurrentDictionary = new ConcurrentDictionary<TKey, Lazy<TValue>>();
        }
        public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) =>
            _concurrentDictionary.GetOrAdd(key,
                k => new Lazy<TValue>(() => valueFactory(k), LazyThreadSafetyMode.ExecutionAndPublication)).Value;
    }
}
