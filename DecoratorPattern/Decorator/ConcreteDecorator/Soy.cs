using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Soy : ICondimentDecorator
    {
        IBeverage beverage;
        public Soy(IBeverage beverageIn)
        {
            beverage = beverageIn;
        }
        public string description
        {
            get
            {
             return beverage.description + " , Soy";
            }
        }

        public double cost()
        {
            return beverage.cost() + 0.15;
        }
    }
}
