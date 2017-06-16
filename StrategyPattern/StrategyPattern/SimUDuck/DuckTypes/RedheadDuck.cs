using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RedheadDuck : Duck, FlyBehavior, QuackBehavior
    {
        public override void display()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void quack()
        {
            throw new NotImplementedException();
        }
    }
}
