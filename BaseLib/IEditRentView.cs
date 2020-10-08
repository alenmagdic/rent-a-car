using Model;
using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IEditRentView : IModelObserver
    {
        void ShowView(Rent rent);
        Reservation Reservation { get; }
        DateTime StartDate { get; }
        DateTime? EndDate { get; }
    }
}
