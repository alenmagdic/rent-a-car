using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IEmployeeRepository : IModelSubject
    {
        int GetNewID();
        void AddEmployee(Employee employee);
        List<Employee> GetAll();
        void DeleteEmployee(Employee employee);
        void SaveEmployee(Employee employee);
        Employee FindByUsername(string username);
    }
}
