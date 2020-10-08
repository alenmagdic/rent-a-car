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
    public partial class EditClientForm : ClientRootForm, IEditClientView
    {
        private IMainFormController _mainFormController;
        private Client _client;
        public string ClientType => _clientTypeCB.Text;
        public new string Name => _nameTB.Text;
        public string OIB => _oibTB.Text;
        public string Email => _emailTB.Text;
        public string PhoneNumber => _phoneNumberTB.Text;

        public EditClientForm()
        {
            InitializeComponent();
        }

        public void ShowView(Client client, IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            _nameTB.Text = client.Name;
            _oibTB.Text = client.OIB;
            _clientTypeCB.Text = client.ClientType;
            _emailTB.Text = client.Email;
            _phoneNumberTB.Text = client.PhoneNumber;

            _client = client;
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.EditClient(this, _client);
        }
    }
}
