using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    class ModelDuck : Duck
    {
        public ModelDuck( QuackBehavior quackBehaviorIn, FlyBehavior flyBehaviorIn)
        {
            flyBehavior = flyBehaviorIn;
            quackBehavior = quackBehaviorIn;
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
