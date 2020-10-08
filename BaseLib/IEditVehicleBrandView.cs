using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IEditVehicleBrandView
    {
        void ShowView(VehicleBrand brand, IMainFormController mainFormController);
        string BrandName { get; }

    }
}
