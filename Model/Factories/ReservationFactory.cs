using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class ReservationFactory
    {
        public static Reservation CreateReservation(int id, Client reservationClient, Vehicle reservedVehicle, DateTime startDate,DateTime endDate, Employee employee)
        {
            return new Reservation(id,reservationClient,reservedVehicle,startDate,endDate,employee);
        }
    }
}
