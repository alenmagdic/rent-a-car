using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public class VehicleFilterService
    {
        private static VehicleFilterService _instance = null;

        public static VehicleFilterService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new VehicleFilterService();
            }
            return _instance;
        }

        public List<Vehicle> GetAvailableVehiclesForCriteria(FilterCriteria filterCriteria, IVehicleRepository vehicleRepository, 
            IReservationRepository reservationRepository, IRentRepository rentRepository)
        {
            FilterCriteria fc = filterCriteria;
            var vehicles = vehicleRepository.GetAll().Where(
                v => EqOrNull(v.Brand, fc.Brand) &&
                EqOrNull(v.Category, fc.Category) &&
                EqOrNull(v.EngineType, fc.EngineType) &&
                EqOrNull(v.TransmissionType, fc.TransmissionType) &&
                InRange(v.EnginePower, fc.MinPower, fc.MaxPower) &&
                InRange(v.TrunkCapacityLiters, fc.MinTrunkCapacity, fc.MaxTrunkCapacity) &&
                InRange(v.NumberOfSeats, fc.MinNumOfSeats, fc.MaxNumOfSeats) &&
                InRange(v.Length, fc.MinLength, fc.MaxLength)
            );
            return vehicles.Where(v => IsVehicleAvailableAtTime(v, fc.AvailableFromDate, fc.AvailableToDate,
                reservationRepository, rentRepository)).ToList();
           
        }

        public bool IsVehicleAvailableAtTime(Vehicle vehicle, DateTime fromDate, DateTime toDate,
            IReservationRepository reservationRepository, IRentRepository rentRepository)
        {
            var collisionsWithExistingReservations = reservationRepository.GetForVehicle(vehicle)

                //provjera preklapanja postojećih rezervacija sa željenom rezervacijom
                .Where(r=> r.StartDate<=fromDate && r.EndDate > fromDate ||
                       r.StartDate >= fromDate && r.StartDate < toDate)

                //koliziju stvaraju samo rezervacije koje nisu već izvršene jer je 
                //npr. netko vratio automobil prije nego mu je istekla rezervacija
                .Where(r => !ReservationAlreadyDone(r,rentRepository)).Count();

            return collisionsWithExistingReservations == 0;
        }

        private bool ReservationAlreadyDone(Reservation reservation, IRentRepository rentRepository)
        {
            var rent = rentRepository.FindByReservation(reservation);
            if(rent==null)
            {
                return false; //klijent jos nije ni preuzeo auto
            }
            if(rent.EndTime!=null)
            {
                return true; //klijent je vec vratio auto
            }
            return false;
        }

        private bool InRange(int parameter, Int32? rangeStart, Int32? rangeEnd)
        {
            return (rangeStart==null || parameter>=rangeStart) && (rangeEnd == null || parameter <= rangeEnd);
        }

        private bool EqOrNull(object first, object second)
        {
            if(first==null || second==null)
            {
                return true;
            }
            return first.Equals(second);
        }

        public class FilterCriteria
        {
            public DateTime AvailableFromDate { get; set; }
            public DateTime AvailableToDate { get; set; }
            public VehicleBrand Brand { get; set; }
            public string Category { get; set; }
            public string EngineType { get; set; }
            public string TransmissionType { get; set; }
            public Int32? MinPower { get; set; }
            public Int32? MaxPower { get; set; }
            public Int32? MinTrunkCapacity { get; set; }
            public Int32? MaxTrunkCapacity { get; set; }
            public Int32? MinNumOfSeats { get; set; }
            public Int32? MaxNumOfSeats { get; set; }
            public Int32? MinLength { get; set; }
            public Int32? MaxLength { get; set; }
        }
    }
}
