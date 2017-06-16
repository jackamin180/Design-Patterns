using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Decafe : IBeverage
    {
        public Decafe()
        {
            description= "Decafe";
        }
        public string description { get; set; }

        public double cost()
        {
            return 1.05;
        }
    }
}
