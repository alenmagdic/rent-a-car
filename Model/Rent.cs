using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rent
    {
        public Rent() { }

        public Rent(int id, Reservation reservation, DateTime startDate, DateTime? endDate)
        {
            Id = id;
            Reservation = reservation;
            SetDates(startDate, endDate);
        }

        public Rent(Rent r) : this(r.Id,r.Reservation,r.StartTime,r.EndTime)
        {
        }

        public int Id
        {
            get;set;
        }

        private Reservation _reservation;
        public Reservation Reservation
        {
            get
            {
                return _reservation;
            }
            set
            {
                if (value == null)
                {
                    throw new Exception("Reservation is a required field!");
                }
                _reservation = value;
            }
        }
        private DateTime _startTime;
        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }

        private DateTime? _endTime;
        public DateTime? EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }

        public void SetDates(DateTime startTime, DateTime? endTime)
        {
            if (startTime >= endTime)
            {
                throw new Exception("Start time must be lower than the rent end time!");
            }
            _startTime = startTime;
            _endTime = endTime;
        }

        public bool IsActive()
        {
            return EndTime == null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Rent)
            {
                if ((obj as Rent).Id == Id)
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
