using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseLib;
using Controllers;
using DAL;
using Model;
using Model.Repositories;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using PresentationLayer;


namespace AppStarter
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            NHibernateService.GenerateShema();
            //GenerateShema();

            IWindowFormsFactory formFactory = new WindowFormsFactory();
            IClientRepository clientRepository = ClientRepository.getInstance();
            IEmployeeRepository employeeRepository = EmployeeRepository.getInstance();
            IRentRepository rentRepository = RentRepository.getInstance();
            IReservationRepository reservationRepository = ReservationRepository.getInstance();
            IVehicleBrandRepository vehicleBrandRepository = VehicleBrandRepository.getInstance();
            IVehicleRepository vehicleRepository = VehicleRepository.getInstance();


            AddDefaultEmployee(employeeRepository);

            MainFormController mainController = new MainFormController(formFactory,clientRepository,
                employeeRepository,rentRepository,reservationRepository,vehicleBrandRepository,vehicleRepository);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm(mainController));


        }

        private static void AddDefaultEmployee(IEmployeeRepository employeeRepository)
        {
            string username = "manager";
            string password = "123";
            employeeRepository.AddEmployee(new Model.Employee(employeeRepository.GetNewID(), username, EmployeeTypes.MANAGER, "Pero", "Perić", "09876543210", password));
            MessageBox.Show("For testing purposes use the following login data: \nUsername: "+username+"\nPassword: "+password, "Test login data");
        }

        public static void GenerateShema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetCallingAssembly());
            //cfg.AddAssembly(typeof(NHibernateService).Assembly);

            new SchemaExport(cfg).Execute(true, true, false);
        }

        public static ISession OpenSession()
        {
            Configuration c = new Configuration();
            c.Configure();

            c.AddAssembly(Assembly.GetCallingAssembly());
            //c.AddAssembly(typeof(NHibernateService).Assembly);
            ISessionFactory f = c.BuildSessionFactory();
            return f.OpenSession();
        }
    }
}

