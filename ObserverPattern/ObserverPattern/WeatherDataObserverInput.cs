using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherDataObserverInput : IObserverInput
    {
        public WeatherDataObserverInput(float h, float p, float t)
        {
            humidity = h;
            pressure = p;
            temperature = t;
        }
        public float humidity
        {
            get;

            set;
        }

        public float pressure
        {
            get;

            set;
        }

        public float temperature
        {
            get;

            set;
        }
    }
}
