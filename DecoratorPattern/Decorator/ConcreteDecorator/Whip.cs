using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Whip : ICondimentDecorator
    {
        IBeverage beverage;
        public Whip(IBeverage beverageIn)
        {
            beverage = beverageIn;
        }
        public string description
        {
            get
            {
                return beverage.description + " , Whip";
            }
        }

        public double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
