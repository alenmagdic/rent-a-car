using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IAddEmployeeView
    {
        void ShowView(IMainFormController mainFormController);
        string Username { get; }
        string EmployeeType { get; }
        string OIB { get; }
        string FirstName { get; }
        string LastName { get; }
        string Password { get; }
        string RepeatPassword { get; }
    }
}
