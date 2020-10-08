using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public class WindowFormsFactory : IWindowFormsFactory
    {
        public IAddClientView CreateAddClientView()
        {
            return new AddClientForm();
        }

        public IAddEmployeeView CreateAddEmployeeView()
        {
            return new AddEmployeeForm();
        }

        public IAddRentView CreateAddRentView(List<Reservation> reservations, IMainFormController mainFormController)
        {
            return new AddRentForm(reservations,mainFormController);
        }

        public IAddReservationView CreateAddReservationView(List<VehicleBrand> brands, List<Client> clients, IMainFormController mainFormController)
        {
            return new AddReservationForm(clients,brands,mainFormController);
        }

        public IAddVehicleBrandView CreateAddVehicleBrandView()
        {
            return new AddVehicleBrandForm();
        }

        public IAddVehicleView CreateAddVehicleView(List<VehicleBrand> vehicleBrands,IMainFormController mainFormController)
        {
            return new AddVehicleForm(vehicleBrands,mainFormController);
        }

        public IEditClientView CreateEditClientView()
        {
            return new EditClientForm();
        }

        public IEditEmployeeView CreateEditEmployeeView()
        {
            return new EditEmployeeForm();
        }

        public IEditRentView CreateEditRentView(List<Reservation> reservations, IMainFormController mainFormController)
        {
            return new EditRentForm(reservations,mainFormController);
        }

        public IEditReservationView CreateEditReservationView(List<VehicleBrand> brands, List<Client> clients, IMainFormController mainFormController)
        {
            return new EditReservationForm(clients,brands,mainFormController);
        }

        public IEditVehicleBrandView CreateEditVehicleBrandView()
        {
            return new EditVehicleBrandForm();
        }

        public IEditVehicleView CreateEditVehicleView(List<VehicleBrand> vehicleBrands, IMainFormController mainFormController)
        {
            return new EditVehicleForm(vehicleBrands,mainFormController);
        }

        public IShowClientListView CreateShowClientListView()
        {
            return new ShowClientListForm();
        }

        public IShowEmployeeListView CreateShowEmployeeListView()
        {
            return new ShowEmployeeListForm();
        }

        public IShowRentListView CreateShowRentListView()
        {
            return new ShowRentListForm();
        }

        public IShowReservationListView CreateShowReservationListView()
        {
            return new ShowReservationListForm();
        }

        public IShowVehicleBrandsListView CreateShowVehicleBrandsListView()
        {
            return new ShowVehicleBrandsListForm();
        }

        public IShowVehicleListView CreateShowVehicleListView()
        {
            return new ShowVehicleListForm();
        }
    }
}
