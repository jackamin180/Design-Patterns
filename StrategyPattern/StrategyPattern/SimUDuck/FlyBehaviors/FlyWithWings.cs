using System;

namespace StrategyPattern
{
    internal class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying!!"); ;
        }
    }
}