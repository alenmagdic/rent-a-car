using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;
using Model.Subject;
using NHibernate;

namespace DAL
{
    public class EmployeeRepository: ModelSubject,IEmployeeRepository
    {
        private static EmployeeRepository _instance = null;
        private int _idCounter = 0;

        private EmployeeRepository()
        {
        }

        public static EmployeeRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new EmployeeRepository();
            }
            return _instance;
        }

        public void AddEmployee(Employee employee)
        {
            ValidateModel(employee);


            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(employee);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        public void DeleteEmployee(Employee employee)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    int reservationsByEmployee = session.CreateQuery("from Reservation as r where r.Employee.Id=" + employee.Id).List<Reservation>().Count;
                    if (reservationsByEmployee > 0)
                    {
                        throw new Exception("Could not delete employee because there are reservations associated with this employee. Delete the associated reservations in order to be able to delete this employee.");

                    }

                    session.Delete(employee);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public List<Employee> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Employee as emp");
                List<Employee> foundEmployees = query.List<Employee>().ToList();

                return foundEmployees;
            } 
        }
        
        public void SaveEmployee(Employee employee)
        {
            ValidateEditedModel(employee);
            Employee existingEmployee = FindById(employee.Id);
            existingEmployee.Username = employee.Username;
            existingEmployee.EmployeeType = employee.EmployeeType;
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.OIB = employee.OIB;
            existingEmployee.Password = employee.Password;

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingEmployee);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        private void ValidateModel(Employee employee)
        {
            if (FindById(employee.Id) != null)
            {
                throw new Exception("There already is an employee with given id!");
            }

            ValidateEditedModel(employee);
        }

        private void ValidateEditedModel(Employee employee)
        {
            Employee employeeByUsername = FindByUsername(employee.Username);
            if (employeeByUsername != null && employeeByUsername.Id!=employee.Id)
            {
                throw new Exception("There already is an employee with given username!");
            }

            Employee employeeByOIB = FindByOIB(employee.OIB);
            if (employeeByOIB != null && employeeByOIB.Id!=employee.Id)
            {
                throw new Exception("There already is an employee with given OIB!");
            }
        }

        private Employee FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Employee as emp where emp.Id="+id);
                List<Employee> foundEmployees = query.List<Employee>().ToList();

                return foundEmployees.FirstOrDefault();
            }
        }

        private Employee FindByOIB(string oib)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Employee as emp where emp.OIB='" + oib+"'");
                List<Employee> foundEmployees = query.List<Employee>().ToList();

                return foundEmployees.FirstOrDefault();
            }
        }

        public Employee FindByUsername(string username)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                
                IQuery query = nhibernateSession.CreateQuery(
                "from Employee as emp where emp.Username='" + username+"'");
                List<Employee> foundEmployees = query.List<Employee>().ToList();

                return foundEmployees.FirstOrDefault();
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }
    }
}
