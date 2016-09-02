using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Decorator
{
    class TurboCar : DecoratorCar
    {
        public TurboCar(Car decoratedCar) 
            : base(decoratedCar)
        {
        }

        public override void Go()
        {
            base.Go();
            Console.WriteLine(".....Euuuuuuuuu......");
        }
    }
}
