using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class MallardDuck : Duck
    {
        public MallardDuck(QuackBehavior quackBehaviorIn, FlyBehavior flyBehaviorIn)
        {
            quackBehavior = quackBehaviorIn;
            flyBehavior = flyBehaviorIn;
        }
        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck"); ;
        }
        
    }
}
