using System;

namespace _03_State_Func.State
{
    public class ConcretteState2 : IState
    {
        public string Name { get; set; } = StateConstants.ContretteState2;

        public void Operation1()
        {
            Console.WriteLine("ContretteState2.Operation1");
        }

        public void Operation2()
        {
            Console.WriteLine("ContretteState2.Operation2");
        }
    }
}