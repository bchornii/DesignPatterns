using System;
using System.Collections.Generic;

namespace _01_Flyweight_GoF
{
    class FlyweightFactory
    {
        Dictionary<string, Type> pool = new Dictionary<string, Type>()
        {
            { "1", typeof(ConcretteFlyweight1) },
            { "2", typeof(ConcretteFlyweight1) },
            { "3", typeof(ConcretteFlyweight1) }
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!pool.ContainsKey(key))
            {
                pool.Add(key, typeof(ConcretteFlyweight1));
            }
            return Activator.CreateInstance(pool[key]) as Flyweight;
        }
    }
}
