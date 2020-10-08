using BaseLib;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class EditEmployeeForm : EmployeeRootForm,IEditEmployeeView
    {
        private IMainFormController _mainFormController;
        private Employee _employee;
        public string Username => _usernameTB.Text;
        public string OIB => _oibTB.Text;
        public string FirstName => _firstNameTB.Text;
        public string LastName => _lastNameTB.Text;
        public string Password => _passwordTB.Text;
        public string RepeatPassword => _repeatPassTB.Text;
        public string EmployeeType => _employeeTypeCB.Text;

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        public void ShowView(Employee employee, IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            _firstNameTB.Text = employee.FirstName;
            _lastNameTB.Text = employee.LastName;
            _oibTB.Text = employee.OIB;
            _usernameTB.Text = employee.Username;
            _employeeTypeCB.Text = employee.EmployeeType;

            _employee = employee;
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.EditEmployee(this, _employee);
        }
    }
}
