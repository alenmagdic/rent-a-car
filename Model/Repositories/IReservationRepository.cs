using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IReservationRepository : IModelSubject
    {
        int GetNewID();
        void AddReservation(Reservation reservation);
        List<Reservation> GetAll();
        void DeleteReservation(Reservation reservation);
        void SaveReservation(Reservation reservation);
        List<Reservation> GetForVehicle(Vehicle vehicle);
    }
}
