using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Subject
{
    public interface IModelSubject
    {
         void Attach(IModelObserver obs);
         void Detach(IModelObserver obs);
         void NotifyObservers();
    }
}
