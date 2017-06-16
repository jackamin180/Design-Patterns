using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private IObserverInput dataValues { get; set; }
        private ISubject weatherData { get; set; }

        public CurrentConditionsDisplay(ISubject weatherDataIn)
        {
            weatherData = weatherDataIn;
            weatherData.registerObserver(this);
        }
        public void Display()
        {
            Console.WriteLine("Current conditions: " + dataValues.temperature + "F degrees and " + dataValues.humidity + "% humidity" );
        }

        public void Update(IObserverInput o)
        {
            dataValues = o;
            Display();
        }
    }
}
