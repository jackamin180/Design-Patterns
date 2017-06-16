using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class RubberDuck : Duck
    {
        public override void display()
        {
            throw new NotImplementedException();
        }
    }
}
