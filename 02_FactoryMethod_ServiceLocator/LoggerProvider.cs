using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_FactoryMethod_ServiceLocator
{
    class LoggerProvider
    {
        public ILogger GetLogger<T>() where T : ILogger
        {
            return Activator.CreateInstance<T>();
        }
    }
}
