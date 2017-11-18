using System;

namespace _03_State_Func.State
{
    public class ContretteState1 : IState
    {
        public string Name { get; set; } = StateConstants.ContretteState1;

        public void Operation1()
        {
            Console.WriteLine("ContretteState1.Operation1");
        }

        public void Operation2()
        {
            Console.WriteLine("ContretteState1.Operation2");
        }
    }
}