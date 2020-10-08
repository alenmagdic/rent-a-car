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
    public partial class ShowEmployeeListForm : Form,IShowEmployeeListView
    {
        private List<Employee> _employeesList = null;
        private IMainFormController _mainFormController = null;

        public ShowEmployeeListForm()
        {
            InitializeComponent();
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

        public void ShowView(List<Employee> employeesList, IMainFormController mainFormController)
        {
            _employeesList = employeesList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }

        private void UpdateList()
        {
            _employeesLV.Items.Clear();
            _employeesList = _mainFormController.GetEmployeesList();
            foreach (var emp in _employeesList)
            {
                _employeesLV.Items.Add(new ListViewItem(new string[] { emp.FirstName,emp.LastName,emp.OIB,emp.Username,emp.EmployeeType}));
            }
        }

        private void EditSelectedEmployee(object sender, EventArgs e)
        {
            foreach (int index in _employeesLV.SelectedIndices)
            {
                Employee employee = _employeesList.ElementAt(index);
                _mainFormController.ShowEditEmployee(employee);
                return;
            }
        }

        private void DeleteSelectedEmployees(object sender, EventArgs e)
        {
            List<Employee> employeesToDelete = new List<Employee>();
            foreach (int index in _employeesLV.SelectedIndices)
            {
                employeesToDelete.Add(_employeesList.ElementAt(index));
            }
            _mainFormController.DeleteEmployee(employeesToDelete);
        }
    }
}
