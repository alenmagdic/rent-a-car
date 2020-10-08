using BaseLib;
using Model;
using Model.Factories;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class ClientController
    {
        private IClientRepository _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void ShowAddNewClient(IAddClientView inForm, IMainFormController mainFormController)
        {
            inForm.ShowView(mainFormController);
        }

        public void AddNewClient(IAddClientView inForm)
        {
            try
            {
                int id = _clientRepository.GetNewID();
                string name = inForm.Name;
                string clientType = inForm.ClientType;
                string OIB = inForm.OIB;
                string email = inForm.Email;
                string phoneNumber = inForm.PhoneNumber;
                Client client = ClientFactory.CreateClient(id, name,
                  clientType, OIB, email,phoneNumber);

                _clientRepository.AddClient(client);

                MessageBox.Show("Client with OIB " + inForm.OIB + " added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowClientListView(IShowClientListView form, IMainFormController mainFormController)
        {
            form.ShowView(_clientRepository.GetAll(), mainFormController);
            _clientRepository.Attach(form);
        }

        public void DeleteClient(List<Client> clientsToDelete)
        {
            foreach (var client in clientsToDelete)
            {
                string confirmText = "Are you sure you want to delete client with OIB" + client.OIB + "?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    
                    try
                    {
                        _clientRepository.DeleteClient(client);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditClient(Client client, IMainFormController mainFormController, IEditClientView inForm)
        {
            inForm.ShowView(client, mainFormController);
        }

        internal void EditNewClient(IEditClientView inForm, Client client)
        {
            try
            {
                client.Name = inForm.Name;
                client.ClientType = inForm.ClientType;
                client.OIB = inForm.OIB;
                client.Email = inForm.Email;
                client.PhoneNumber = inForm.PhoneNumber;
                _clientRepository.SaveClient(client);

                MessageBox.Show("Client with OIB " + inForm.OIB + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}
