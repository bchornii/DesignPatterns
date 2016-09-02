﻿using System;

namespace _02_Decorator_Coffe
{
    class Lime : CoffeDecorator
    {
        public Lime(Coffe coffe) 
            : base(coffe)
        {

        }
        public override void Make()
        {
            base.Make();
            Console.WriteLine("Add some lime");
        }
    }
}