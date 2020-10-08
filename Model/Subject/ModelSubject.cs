using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Subject
{
    public class ModelSubject : IModelSubject
    {
        List<IModelObserver> _observers = new List<IModelObserver>();

        public void Attach(IModelObserver obs)
        {
            _observers.Add(obs);
        }

        public void Detach(IModelObserver obs)
        {
            _observers.Remove(obs);
        }

        public void NotifyObservers()
        {
            foreach (IModelObserver obs in _observers)
            {
                obs.OnModelChanged();
            }
        }
    }
}
