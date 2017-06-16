using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck(new Quack(), new FlyWithWings());
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck(new Quack(), new FlyNoWay());
            model.performFly();
            model.flyBehavior = new FlyRockectPowered();
            model.performFly();
            model.performQuack();
            Console.Read();
        }
    }
}
