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
    public partial class AddReservationForm : ReservationRootForm, IAddReservationView
    {
        public Client ReservationClient => _clients.ElementAt(_clientCB.SelectedIndex);
        public Vehicle ReservedVehicle => GetSelectedVehicle();
        public DateTime StartDate =>_startDatePicker.Value;
        public DateTime EndDate => _endDatePicker.Value;


        public AddReservationForm(List<Client> clients,List<VehicleBrand> vehicleBrands, IMainFormController mainFormController) : base(clients,vehicleBrands,mainFormController)
        {
            InitializeComponent();
        }

        
        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetClientsList(),_mainFormController.GetBrandsList());
        }

        public void ShowView()
        {
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.AddReservation(this);
        }
    }
}
