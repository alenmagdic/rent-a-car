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
    public partial class ClientRootForm : Form
    {
        public ClientRootForm()
        {
            InitializeComponent();
            foreach (var clientType in ClientTypes.GetValues())
            {
                _clientTypeCB.Items.Add(clientType);
            }
            _clientTypeCB.Text = ClientTypes.PERSON;
        }

        protected virtual void OnApply(object sender, EventArgs e)
        {
            try
            {
                CheckComboBoxHasValue(_clientTypeCB, "Invalid client type!");
            }
            catch (Exception)
            {
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
