using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class SteamedMilk : ICondimentDecorator
    {
        IBeverage beverage;
        public SteamedMilk(IBeverage beverageIn)
        {
            beverage = beverageIn;
        }
        public string description
        {
            get
            {
                return beverage.description + " , Steamed Milk";
            }
        }

        public double cost()
        {
            return beverage.cost() + 0.10;
        }
    }
}
