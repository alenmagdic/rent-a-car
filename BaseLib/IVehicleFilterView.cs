using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IVehicleFilterView
    {
        DateTime ReservationStartDate { get; }
        DateTime ReservationEndDate { get; }
        VehicleBrand Brand { get; }
        string Category { get; }
        string EngineType { get; }
        string TransmissionType { get; }
        Int32? MinPower { get; }
        Int32? MaxPower { get; }
        Int32? MinTrunkCapacity { get; }
        Int32? MaxTrunkCapacity { get; }
        Int32? MinNumOfSeats { get; }
        Int32? MaxNumOfSeats { get; }
        Int32? MinLength { get; }
        Int32? MaxLength { get; }

    }
}
