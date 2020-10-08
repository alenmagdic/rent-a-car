using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Subject;

namespace BaseLib
{
    public interface IShowEmployeeListView : IModelObserver
    {
        void ShowView(List<Employee> employeesList, IMainFormController mainFormController);
    }
}
