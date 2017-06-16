using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class HouseBlend : IBeverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public string description { get; set; }
        public double cost()
        {
            return 0.89;
        }
    }
}
