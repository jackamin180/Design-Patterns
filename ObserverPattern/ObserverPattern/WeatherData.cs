using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class WeatherData:ISubject
    {
        private List<IObserver> observers;
        private IObserverInput dataValues { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if(i >= 0)
            {
                observers.RemoveAt(i);
            }        
        }

        public void notifyObservers(IObserverInput o)
        {
            foreach (var observer in observers)
            {
                observer.Update(o);
            };
        }

        public void measurementsChanged()
        {
            notifyObservers(dataValues);
        }

        public void setMeasurements(IObserverInput o)
        {
            dataValues = o;
            measurementsChanged();
        }
    }
}
