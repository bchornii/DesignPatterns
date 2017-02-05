using System;
using System.Collections.Generic;

namespace _01_Flyweight_GoF
{
    public class FlyweightFactory
    {
        readonly Dictionary<string, Type> _pool = new Dictionary<string, Type>()
        {
            { "1", typeof(ConcretteFlyweight1) },
            { "2", typeof(ConcretteFlyweight1) },
            { "3", typeof(ConcretteFlyweight1) }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!_pool.ContainsKey(key))
            {
                _pool.Add(key, typeof(ConcretteFlyweight1));
            }
            return Activator.CreateInstance(_pool[key]) as Flyweight;
        }
    }
}
