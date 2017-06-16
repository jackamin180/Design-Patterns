using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IObserverInput
    {

        float temperature { get; set; }
        float humidity { get; set; }
        float pressure { get; set; }
    }
}
