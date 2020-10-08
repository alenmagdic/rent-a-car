using BaseLib;
using Model;
using Model.Repositories;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class MainFormController:IMainFormController
    {
        public Employee CurrentEmployee { get; set; }
        private IWindowFormsFactory _formFactory;
        private IClientRepository _clientRepository;
        private IEmployeeRepository _employeeRepository;
        private IRentRepository _rentRepository;
        private IReservationRepository _reservationRepository;
        private IVehicleBrandRepository _vehicleBrandRepository;
        private IVehicleRepository _vehicleRepository;

        public MainFormController(IWindowFormsFactory formFactory,IClientRepository clientRepository,
            IEmployeeRepository employeeRepository,IRentRepository rentRepository,IReservationRepository reservationRepository,
            IVehicleBrandRepository vehicleBrandRepository,IVehicleRepository vehicleRepository)
        {
            _formFactory = formFactory;
            _clientRepository = clientRepository;
            _employeeRepository = employeeRepository;
            _rentRepository = rentRepository;
            _reservationRepository = reservationRepository;
            _vehicleBrandRepository = vehicleBrandRepository;
            _vehicleRepository = vehicleRepository;

            CurrentEmployee = new Employee(555, "pero", "Manager", "pero", "peric", "12345678901", "123");
        }

        public void ShowAddVehicleBrand()
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            var addBrandForm = _formFactory.CreateAddVehicleBrandView();
            brandController.ShowAddNewBrand(addBrandForm,this);
        }

        public void AddVehicleBrand(IAddVehicleBrandView inForm)
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            brandController.AddNewBrand(inForm);
        }

        public void ShowBrandsListView()
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            var showBrandsForm = _formFactory.CreateShowVehicleBrandsListView();
            brandController.ShowBrandsListView(showBrandsForm,this);
        }

        public void DeleteBrands(List<VehicleBrand> brandsToDelete)
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            brandController.DeleteBrands(brandsToDelete);
        }

        public void ShowEditBrand(VehicleBrand brand)
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            var editBrandForm = _formFactory.CreateEditVehicleBrandView();
            brandController.ShowEditBrand(brand,this,editBrandForm);
        }

        public void EditVehicleBrand(IEditVehicleBrandView inForm,VehicleBrand brand)
        {
            var brandController = new VehicleBrandController(_vehicleBrandRepository);
            brandController.EditNewBrand(inForm,brand);
        }

        public void AddEmployee(IAddEmployeeView inForm)
        {
            var employeeController = new EmployeeController(_employeeRepository);
            employeeController.AddNewEmployee(inForm);
        }

        public void DeleteEmployee(List<Employee> employeesToDelete)
        {
            var employeeController = new EmployeeController(_employeeRepository);
            employeeController.DeleteEmployee(employeesToDelete);
        }

        public void ShowAddEmployee()
        {
            var employeeController = new EmployeeController(_employeeRepository);
            var addEmployeeForm = _formFactory.CreateAddEmployeeView();
            employeeController.ShowAddNewEmployee(addEmployeeForm, this);
        }

        public void ShowEmployeeListView()
        {
            var employeeController = new EmployeeController(_employeeRepository);
            var showEmployeesForm = _formFactory.CreateShowEmployeeListView();
            employeeController.ShowEmployeeListView(showEmployeesForm, this);
        }

        public void ShowEditEmployee(Employee employee)
        {
            var employeeController = new EmployeeController(_employeeRepository);
            var editEmployeeForm = _formFactory.CreateEditEmployeeView();
            employeeController.ShowEditEmployee(employee, this, editEmployeeForm);
        }

        public void EditEmployee(IEditEmployeeView inForm, Employee employee)
        {
            var employeeController = new EmployeeController(_employeeRepository);
            employeeController.EditNewEmployee(inForm, employee);
        }

        public List<VehicleBrand> GetBrandsList()
        {
            return _vehicleBrandRepository.GetAll();
        }

        public List<Employee> GetEmployeesList()
        {
            return _employeeRepository.GetAll();
        }

        public void AddVehicle(IAddVehicleView inForm)
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            vehicleController.AddNewVehicle(inForm);
        }

        public void DeleteVehicle(List<Vehicle> vehiclesToDelete)
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            vehicleController.DeleteVehicle(vehiclesToDelete);
        }

        public void ShowAddVehicle()
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            var addVehicleForm = _formFactory.CreateAddVehicleView(_vehicleBrandRepository.GetAll(),this);
            vehicleController.ShowAddNewVehicle(addVehicleForm, this,_vehicleBrandRepository);
        }

        public void ShowVehicleListView()
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            var showVehicleForm = _formFactory.CreateShowVehicleListView();
            vehicleController.ShowVehicleListView(showVehicleForm, this);
        }

        public void ShowEditVehicle(Vehicle vehicle)
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            var editVehicleForm = _formFactory.CreateEditVehicleView(_vehicleBrandRepository.GetAll(),this);
            vehicleController.ShowEditVehicle(vehicle, this, editVehicleForm, _vehicleBrandRepository);
        }

        public void EditVehicle(IEditVehicleView inForm, Vehicle vehicle)
        {
            var vehicleController = new VehicleController(_vehicleRepository);
            vehicleController.EditNewVehicle(inForm, vehicle);
        }

        public List<Vehicle> GetVehiclesList()
        {
            return _vehicleRepository.GetAll();
        }



        public void AddClient(IAddClientView inForm)
        {
            var clientController = new ClientController(_clientRepository);
            clientController.AddNewClient(inForm);
        }

        public void DeleteClient(List<Client> clientsToDelete)
        {
            var clientController = new ClientController(_clientRepository);
            clientController.DeleteClient(clientsToDelete);
        }

        public void ShowAddClient()
        {
            var clientController = new ClientController(_clientRepository);
            var addClientForm = _formFactory.CreateAddClientView();
            clientController.ShowAddNewClient(addClientForm, this);
        }

        public void ShowClientListView()
        {
            var clientController = new ClientController(_clientRepository);
            var showClientsForm = _formFactory.CreateShowClientListView();
            clientController.ShowClientListView(showClientsForm, this);
        }

        public void ShowEditClient(Client client)
        {
            var clientController = new ClientController(_clientRepository);
            var editClientForm = _formFactory.CreateEditClientView();
            clientController.ShowEditClient(client, this, editClientForm);
        }

        public void EditClient(IEditClientView inForm, Client client)
        {
            var clientController = new ClientController(_clientRepository);
            clientController.EditNewClient(inForm, client);
        }

        public List<Client> GetClientsList()
        {
            return _clientRepository.GetAll();
        }

        public void AddReservation(IAddReservationView inForm)
        {
            var reservationController = new ReservationController(_reservationRepository);
            reservationController.AddNewReservation(inForm,CurrentEmployee,_rentRepository);
        }

        public void DeleteReservation(List<Reservation> reservationsToDelete)
        {
            var reservationController = new ReservationController(_reservationRepository);
            reservationController.DeleteReservation(reservationsToDelete);
        }

        public void ShowAddReservation()
        {
            var reservationController = new ReservationController(_reservationRepository);
            var addReservationForm = _formFactory.CreateAddReservationView(_vehicleBrandRepository.GetAll(),_clientRepository.GetAll(), this);
            reservationController.ShowAddNewReservation(addReservationForm, this, _clientRepository);
        }

        public void ShowReservationListView()
        {
            var reservationController = new ReservationController(_reservationRepository);
            var showReservationForm = _formFactory.CreateShowReservationListView();
            reservationController.ShowReservationListView(showReservationForm, this);
        }

        public void ShowEditReservation(Reservation reservation)
        {
            var reservationController = new ReservationController(_reservationRepository);
            var editReservationForm = _formFactory.CreateEditReservationView(_vehicleBrandRepository.GetAll(),_clientRepository.GetAll(), this);
            reservationController.ShowEditReservation(reservation, this, editReservationForm, _clientRepository);
        }

        public void EditReservation(IEditReservationView inForm, Reservation reservation)
        {
            var reservationController = new ReservationController(_reservationRepository);
            reservationController.EditNewReservation(inForm, reservation);
        }

        public List<Reservation> GetReservationsList()
        {
            return _reservationRepository.GetAll();
        }

        public List<Vehicle> GetVehiclesMeetingCriteria(IVehicleFilterView form)
        {
            var filterService = VehicleFilterService.GetInstance();
            var filterCriteria = new VehicleFilterService.FilterCriteria
            {
                AvailableFromDate = form.ReservationStartDate,
                AvailableToDate = form.ReservationEndDate,
                Brand = form.Brand,
                Category = form.Category,
                EngineType = form.EngineType,
                TransmissionType = form.TransmissionType,
                MinPower = form.MinPower,
                MaxPower = form.MaxPower,
                MinTrunkCapacity = form.MinTrunkCapacity,
                MaxTrunkCapacity = form.MaxTrunkCapacity,
                MinNumOfSeats = form.MinNumOfSeats,
                MaxNumOfSeats = form.MaxNumOfSeats,
                MinLength = form.MinLength,
                MaxLength = form.MaxLength
            };
        
            return filterService.GetAvailableVehiclesForCriteria(filterCriteria,_vehicleRepository,_reservationRepository,_rentRepository);
        }

        public void AddRent(IAddRentView inForm)
        {
            var rentController = new RentController(_rentRepository);
            rentController.AddNewRent(inForm);
        }

        public void DeleteRent(List<Rent> rentsToDelete)
        {
            var rentController = new RentController(_rentRepository);
            rentController.DeleteRent(rentsToDelete);
        }

        public void ShowAddRent()
        {
            var rentController = new RentController(_rentRepository);
            var addRentForm = _formFactory.CreateAddRentView(_reservationRepository.GetAll(), this);
            rentController.ShowAddNewRent(addRentForm, this, _reservationRepository);
        }

        public void ShowRentListView()
        {
            var rentController = new RentController(_rentRepository);
            var showRentForm = _formFactory.CreateShowRentListView();
            rentController.ShowRentListView(showRentForm, this);
        }

        public void ShowEditRent(Rent rent)
        {
            var rentController = new RentController(_rentRepository);
            var editRentForm = _formFactory.CreateEditRentView(_reservationRepository.GetAll(), this);
            rentController.ShowEditRent(rent, this, editRentForm, _reservationRepository);
        }

        public void EditRent(IEditRentView inForm, Rent rent)
        {
            var rentController = new RentController(_rentRepository);
            rentController.EditNewRent(inForm, rent);
        }

        public List<Rent> GetRentsList()
        {
            return _rentRepository.GetAll();
        }

        public void LogIn(IMainView mainForm)
        {
            Employee employee = _employeeRepository.FindByUsername(mainForm.Username);
            if(employee==null || !mainForm.Password.Equals(employee.Password))
            {
                MessageBox.Show("Invalid username or password.","Fail");
                return;
            }
            CurrentEmployee = employee;
            mainForm.UpdateView();
        }

        public void LogOut(IMainView mainForm)
        {
            CurrentEmployee = null;
            mainForm.UpdateView();
        }

        public double GetReservationDuration(DateTime start, DateTime end)
        {
            var reservationController = new ReservationController(_reservationRepository);
            return reservationController.GetReservationDuration(start, end);
        }
    }
}
