using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Decorator_Coffe
{
    class Sugar : CoffeDecorator
    {
        public Sugar(Coffe coffe) 
            : base(coffe)
        {

        }
        public override void Make()
        {
            base.Make();
            Console.WriteLine("Add some sugar");
        }
    }
}
