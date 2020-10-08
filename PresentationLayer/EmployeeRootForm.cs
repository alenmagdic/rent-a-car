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
    public partial class EmployeeRootForm : Form
    {
        public EmployeeRootForm()
        {
            InitializeComponent();

            foreach (var employeeType in EmployeeTypes.GetValues())
            {
                _employeeTypeCB.Items.Add(employeeType);
            }
            _employeeTypeCB.Text = EmployeeTypes.STANDARD_EMPLOYEE;
        }

        protected virtual void OnApply(object sender, EventArgs e)
        {
            try
            {
                CheckComboBoxHasValue(_employeeTypeCB, "Invalid employee type!");
            }
            catch (Exception) {
                return;
            }
            Apply();
        }

        private void CheckComboBoxHasValue(ComboBox comboBox, string errorMessage)
        {
            if (comboBox.SelectedIndex == -1)
            {
                MessageBox.Show(errorMessage, "Fail");
                throw new Exception("Combo box doesn't have selected value!");
            }
        }

        protected virtual void Apply() { }

        protected void OnCancel(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
