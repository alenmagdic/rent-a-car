using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(int id, VehicleBrand brand, string modelName, string category, int trunkCapacity, int numberOfSeats, string engineType, int power, string transmissionType, int length, int height, int width, string licensePlate, string vehicleId)
        {
            return new Vehicle(id,brand,modelName,category,trunkCapacity,numberOfSeats,engineType,power,transmissionType,length,height,width,licensePlate,vehicleId);
        }
    }
}
