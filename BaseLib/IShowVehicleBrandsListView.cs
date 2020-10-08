using Model;
using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IShowVehicleBrandsListView : IModelObserver
    {
        void ShowView(List<VehicleBrand> brandsList,IMainFormController mainFormController);
    }
}
