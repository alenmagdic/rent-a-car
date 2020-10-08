using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class RentFactory
    {
        public static Rent CreateRent(int id, Reservation reservation, DateTime startDate,DateTime? endDate)
        {
            return new Rent(id,reservation,startDate,endDate);
        }
    }
}
