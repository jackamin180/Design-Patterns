using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Espresso : IBeverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public string description { get; set; }
        public double cost()
        {
            return 1.99;
        }
    }
}
