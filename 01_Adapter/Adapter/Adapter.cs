using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Adapter
{
    // Адаптер назовні виглядає як нові євророзетки, шляхом наслідування
    // прийнятого в системі інтерфейсу
    class Adapter : INewElectricitySystem
    {
        // Але всередині він знає що коїлося в системі СРСР
        private readonly OldElectricitySystem _adaptee;

        public Adapter(OldElectricitySystem adaptee)
        {
            _adaptee = adaptee;
        }

        // І тут відбувається вся магія - наш адаптер перекладає функціональність
        // із нового стандарту на старий
        public string MathWideSocket()
        {
            return _adaptee.MathThinSocket();
        }
    }
}
