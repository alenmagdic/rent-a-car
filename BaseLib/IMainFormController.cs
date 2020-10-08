using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BaseLib
{
    public interface IMainFormController
    {
        Employee CurrentEmployee { get; set; }

        void AddVehicleBrand(IAddVehicleBrandView inForm);
        void DeleteBrands(List<VehicleBrand> brandsToDelete);
        void ShowAddVehicleBrand();
        void ShowBrandsListView();
        void ShowEditBrand(VehicleBrand brand);
        void EditVehicleBrand(IEditVehicleBrandView inForm,VehicleBrand brand);
        List<VehicleBrand> GetBrandsList();

        void AddEmployee(IAddEmployeeView inForm);
        void DeleteEmployee(List<Employee> employeesToDelete);
        void ShowAddEmployee();
        void ShowEmployeeListView();
        void ShowEditEmployee(Employee employee);
        void EditEmployee(IEditEmployeeView inForm, Employee employee);
        List<Employee> GetEmployeesList();

        void AddVehicle(IAddVehicleView inForm);
        void DeleteVehicle(List<Vehicle> vehiclesToDelete);
        void ShowAddVehicle();
        void ShowVehicleListView();
        void ShowEditVehicle(Vehicle vehicle);
        void EditVehicle(IEditVehicleView inForm, Vehicle vehicle);
        List<Vehicle> GetVehiclesList();

        void AddClient(IAddClientView inForm);
        void DeleteClient(List<Client> clientsToDelete);
        void ShowAddClient();
        void ShowClientListView();
        void ShowEditClient(Client client);
        void EditClient(IEditClientView inForm, Client client);
        List<Client> GetClientsList();

        void AddReservation(IAddReservationView inForm);
        void DeleteReservation(List<Reservation> reservationsToDelete);
        void ShowAddReservation();
        void ShowReservationListView();
        void ShowEditReservation(Reservation reservation);
        void EditReservation(IEditReservationView inForm, Reservation reservation);
        List<Reservation> GetReservationsList();
        List<Vehicle> GetVehiclesMeetingCriteria(IVehicleFilterView vehicleFilterForm);


        void AddRent(IAddRentView inForm);
        void DeleteRent(List<Rent> rentsToDelete);
        void ShowAddRent();
        void ShowRentListView();
        void ShowEditRent(Rent rent);
        void EditRent(IEditRentView inForm, Rent rent);
        List<Rent> GetRentsList();

        void LogIn(IMainView mainForm);
        void LogOut(IMainView mainForm);

        double GetReservationDuration(DateTime start, DateTime end);
    }
}
