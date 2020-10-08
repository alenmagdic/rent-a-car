using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class VehicleBrandFactory
    {
        public static VehicleBrand CreateVehicleBrand(int id, string brandName)
        {
            return new VehicleBrand(id, brandName);
        }
    }
}
