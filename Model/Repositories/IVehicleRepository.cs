using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IVehicleRepository : IModelSubject
    {
        List<Vehicle> GetAll();
        int GetNewID();
        void AddVehicle(Vehicle vehicle);
        void DeleteVehicle(Vehicle vehicle);
        void SaveVehicle(Vehicle vehicle);
    }
}
