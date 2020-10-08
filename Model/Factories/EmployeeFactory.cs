using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class EmployeeFactory
    {
        public static Employee CreateEmployee(int id, string username,string employeeType, string firstName,string lastName,string OIB, string password)
        {
            return new Employee(id,username, employeeType, firstName, lastName,OIB, password);
        }
    }
}
