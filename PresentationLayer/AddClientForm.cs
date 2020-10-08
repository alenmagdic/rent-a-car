using BaseLib;
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
    public partial class AddClientForm : ClientRootForm, IAddClientView
    {
        private IMainFormController _mainFormController;
        public string ClientType => _clientTypeCB.Text;
        public new string Name => _nameTB.Text;
        public string OIB => _oibTB.Text;
        public string Email => _emailTB.Text;
        public string PhoneNumber => _phoneNumberTB.Text;


        public AddClientForm()
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
            _mainFormController.AddClient(this);
        }
    }
}
