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
    public partial class ShowClientListForm : Form, IShowClientListView
    {
        private List<Client> _clientsList = null;
        private IMainFormController _mainFormController = null;

        public ShowClientListForm()
        {
            InitializeComponent();
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

        public void ShowView(List<Client> clientsList, IMainFormController mainFormController)
        {
            _clientsList = clientsList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }

        private void UpdateList()
        {
            _clientsLV.Items.Clear();
            _clientsList = _mainFormController.GetClientsList();
            foreach (var cl in _clientsList)
            {
                _clientsLV.Items.Add(new ListViewItem(new string[] { cl.Name,cl.Email,cl.OIB,cl.PhoneNumber,cl.ClientType }));
            }
        }

        private void EditSelectedClient(object sender, EventArgs e)
        {
            foreach (int index in _clientsLV.SelectedIndices)
            {
                Client client = _clientsList.ElementAt(index);
                _mainFormController.ShowEditClient(client);
                return;
            }
        }

        private void DeleteSelectedClients(object sender, EventArgs e)
        {
            List<Client> clientsToDelete = new List<Client>();
            foreach (int index in _clientsLV.SelectedIndices)
            {
                clientsToDelete.Add(_clientsList.ElementAt(index));
            }
            _mainFormController.DeleteClient(clientsToDelete);
        }
    }
}
