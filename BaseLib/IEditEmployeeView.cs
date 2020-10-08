using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BaseLib
{
    public interface IEditEmployeeView
    {
        void ShowView(Employee employee, IMainFormController mainFormController);
        string Username { get; }
        string EmployeeType { get; }
        string OIB { get; }
        string FirstName { get; }
        string LastName { get; }
        string Password { get; }
        string RepeatPassword { get; }
    }
}
