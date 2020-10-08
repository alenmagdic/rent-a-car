using Model;
using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IEditVehicleView : IModelObserver
    {
        void ShowView(Vehicle vehicle);
        VehicleBrand Brand { get; }
        string ModelName { get; }
        string Category { get; }
        int TrunkCapacity { get; }
        int NumberOfSeats { get; }
        string EngineType { get; }
        int Power { get; }
        string TransmissionType { get; }
        int Length { get; }
        int Width { get; }
        int Height { get; }
        string LicensePlate { get; }
        string VehicleId { get; }
    }
}
