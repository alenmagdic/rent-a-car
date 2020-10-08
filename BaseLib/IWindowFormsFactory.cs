using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IWindowFormsFactory
    {
        IAddVehicleBrandView CreateAddVehicleBrandView();
        IShowVehicleBrandsListView CreateShowVehicleBrandsListView();
        IEditVehicleBrandView CreateEditVehicleBrandView();

        IAddEmployeeView CreateAddEmployeeView();
        IShowEmployeeListView CreateShowEmployeeListView();
        IEditEmployeeView CreateEditEmployeeView();

        IAddVehicleView CreateAddVehicleView(List<VehicleBrand> vehicleBrands, IMainFormController mainFormController);
        IShowVehicleListView CreateShowVehicleListView();
        IEditVehicleView CreateEditVehicleView(List<VehicleBrand> vehicleBrands, IMainFormController mainFormController);

        IAddClientView CreateAddClientView();
        IShowClientListView CreateShowClientListView();
        IEditClientView CreateEditClientView();

        IAddReservationView CreateAddReservationView(List<VehicleBrand> brands, List<Client> clients, IMainFormController mainFormController);
        IShowReservationListView CreateShowReservationListView();
        IEditReservationView CreateEditReservationView(List<VehicleBrand> brands, List<Client> clients, IMainFormController mainFormController);

        IAddRentView CreateAddRentView(List<Reservation> reservations, IMainFormController mainFormController);
        IShowRentListView CreateShowRentListView();
        IEditRentView CreateEditRentView(List<Reservation> reservations, IMainFormController mainFormController);

    }
}
