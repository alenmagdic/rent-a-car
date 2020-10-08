using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IVehicleBrandRepository : IModelSubject
    {
        void AddVehicleBrand(VehicleBrand brand);
        int GetNewID();
        VehicleBrand FindByName(string name);
        VehicleBrand FindById(int id);
        List<VehicleBrand> GetAll();
        void DeleteBrand(VehicleBrand brand);
        void SaveBrand(VehicleBrand brand);
    }

}
