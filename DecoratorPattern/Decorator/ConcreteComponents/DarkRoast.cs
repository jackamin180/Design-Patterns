using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DarkRoast : IBeverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }
        public string description { get; set; }
        public double cost()
        {
            return 0.99;
        }
    }
}
