using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mocha : ICondimentDecorator
    {
        IBeverage beverage;
        public Mocha(IBeverage beverageIn)
        {
            beverage = beverageIn;
        }
        public string description
        {
            get
            {
                return beverage.description + ", Mocha";
            }
            
        }

        public double cost()
        {
            return beverage.cost() + 0.20;
        }
    }
}
