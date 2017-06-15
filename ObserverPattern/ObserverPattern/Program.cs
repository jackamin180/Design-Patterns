using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.setMeasurements(new WeatherDataObserverInput(80, 65, 30.4f));
            weatherData.setMeasurements(new WeatherDataObserverInput(82, 70, 29.2f));
            weatherData.setMeasurements(new WeatherDataObserverInput(78, 90, 29.2f));
            Console.ReadLine();
        }
    }
}
