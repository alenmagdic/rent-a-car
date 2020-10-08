using Model;
using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IEditReservationView : IModelObserver
    {
        void ShowView(Reservation reservation);
        Client ReservationClient { get; }
        Vehicle ReservedVehicle { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
    }
}
