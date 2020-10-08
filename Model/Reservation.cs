using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public Reservation() { }

        public Reservation(Reservation r) : this(r.Id,r.ReservationClient,r.ReservedVehicle,r.StartDate,r.EndDate,r.Employee)
        {
        }

        public Reservation(int id, Client reservationClient, Vehicle reservedVehicle, DateTime startDate, DateTime endDate, Employee employee)
        {
            Id = id;
            ReservationClient = reservationClient;
            ReservedVehicle = reservedVehicle;
            SetDates(startDate, endDate);
            Employee = employee;
        }

        public int Id
        {
            get;set;
        }
        private Client _reservationClient;
        public Client ReservationClient
        {
            get
            {
                return _reservationClient;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Client is a required field!");
                }
                _reservationClient = value;
            }
        }

        private Vehicle _reservedVehicle;
        public Vehicle ReservedVehicle
        {
            get
            {
                return _reservedVehicle;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Vehicle is a required field!");
                }
                _reservedVehicle = value;
            }
        }

        private DateTime _startDate;
        public DateTime StartDate
        {
            get
            {
                return _startDate;
            }
            set
            {
                _startDate = value;
            }
        }

        private DateTime _endDate;
        public DateTime EndDate
        {
            get
            {
                return _endDate;
            }
            set
            {
                _endDate = value;
            }
        }

        public void SetDates(DateTime startDate,DateTime endDate)
        {
            if(startDate>= endDate)
            {
                throw new Exception("Start date must be lower than the reservation end date!");
            }
            _startDate = startDate;
            _endDate = endDate;
        }


        private Employee _employee;
        public Employee Employee
        {
            get
            {
                return _employee;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Employee is a required field!");
                }
                _employee = value;
            }
        }

        public static double CalculateReservationDurationInDays(DateTime start,DateTime end)
        {
            return (end - start).TotalDays;
        }

        public double CalculateReservationDurationInDays()
        {
            return (EndDate - StartDate).TotalDays;
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Reservation)
            {
                if ((obj as Reservation).Id == Id)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
