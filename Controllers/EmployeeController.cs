using BaseLib;
using Model;
using Model.Repositories;
using Model.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class EmployeeController
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void ShowAddNewEmployee(IAddEmployeeView inForm, IMainFormController mainFormController)
        {
            inForm.ShowView(mainFormController);
        }

        public void AddNewEmployee(IAddEmployeeView inForm)
        {
            if (!inForm.Password.Equals(inForm.RepeatPassword))
            {
                MessageBox.Show("Passwords do not match!","Fail");
                return;
            }
            try
            {
                int id = _employeeRepository.GetNewID();
                string username = inForm.Username;
                string employeeType = inForm.EmployeeType;
                string firstName = inForm.FirstName;
                string lastName = inForm.LastName;
                string OIB = inForm.OIB;
                string password = inForm.Password;
                Employee employee = EmployeeFactory.CreateEmployee(id,username,
                  employeeType,firstName,lastName,OIB,password);

                _employeeRepository.AddEmployee(employee);

                MessageBox.Show("Employee with OIB " + inForm.OIB + " added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowEmployeeListView(IShowEmployeeListView form, IMainFormController mainFormController)
        {
            form.ShowView(_employeeRepository.GetAll(), mainFormController);
            _employeeRepository.Attach(form);
        }

        public void DeleteEmployee(List<Employee> employeesToDelete)
        {
            foreach (var employee in employeesToDelete)
            {
                string confirmText = "Are you sure you want to delete employee with OIB" + employee.OIB + "?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    
                    try
                    {
                        _employeeRepository.DeleteEmployee(employee);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditEmployee(Employee employee, IMainFormController mainFormController, IEditEmployeeView inForm)
        {
            inForm.ShowView(employee, mainFormController);
        }

        internal void EditNewEmployee(IEditEmployeeView inForm, Employee employee)
        {
            if(!inForm.Password.Equals(inForm.RepeatPassword))
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }
            try
            {
                employee.Username = inForm.Username;
                employee.EmployeeType = inForm.EmployeeType;
                employee.FirstName = inForm.FirstName;
                employee.LastName = inForm.LastName;
                employee.OIB = inForm.OIB;
                employee.Password = inForm.Password;
                _employeeRepository.SaveEmployee(employee);

                MessageBox.Show("Employee with OIB " + inForm.OIB + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}

