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
    public partial class AddEmployeeForm : EmployeeRootForm, IAddEmployeeView
    {
        private IMainFormController _mainFormController;
        public string Username => _usernameTB.Text;
        public string OIB => _oibTB.Text;
        public string FirstName => _firstNameTB.Text;
        public string LastName => _lastNameTB.Text;
        public string Password => _passwordTB.Text;
        public string RepeatPassword => _repeatPassTB.Text;
        public string EmployeeType => _employeeTypeCB.Text;

        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        
        public void ShowView(IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.AddEmployee(this);
        }
    }
}
