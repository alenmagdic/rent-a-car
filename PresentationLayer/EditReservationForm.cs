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
    public partial class EditReservationForm : ReservationRootForm, IEditReservationView
    {
        private Reservation _reservation;
        public Client ReservationClient => _clients.ElementAt(_clientCB.SelectedIndex);
        public Vehicle ReservedVehicle => GetSelectedVehicle();
        public DateTime StartDate => _startDatePicker.Value;
        public DateTime EndDate => _endDatePicker.Value;

        public EditReservationForm(List<Client> clients, List<VehicleBrand> vehicleBrands, IMainFormController mainFormController) : base(clients, vehicleBrands, mainFormController)
        {
            InitializeComponent();
        }

        protected override void Apply()
        {
            _mainFormController.EditReservation(this, _reservation);
        }

        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetClientsList(),_mainFormController.GetBrandsList());
        }

        public void ShowView(Reservation reservation)
        {
            _clientCB.SelectedIndex = _clients.IndexOf(reservation.ReservationClient);
            _startDatePicker.Value = reservation.StartDate;
            _endDatePicker.Value = reservation.EndDate;

            _reservation = reservation;
            RefreshVehiclesList();
            SetVehicleSelected(reservation.ReservedVehicle);

            Show();
        }

        private void SetVehicleSelected(Vehicle reservedVehicle)
        {
            int vehicleIndex = _availableVehicles.IndexOf(reservedVehicle);
            
            _vehiclesLV.Items[vehicleIndex].Selected = true;
            _vehiclesLV.Items[vehicleIndex].Focused = true;
        }

        public override void RefreshVehiclesList()
        {
            base.RefreshVehiclesList();
            if(_reservation==null)
            {
                return;
            }
            var veh = _reservation.ReservedVehicle;
            _availableVehicles.Add(veh);
            _vehiclesLV.Items.Add(new ListViewItem(new string[] { veh.Brand.BrandName, veh.ModelName, veh.Category, veh.TrunkCapacityLiters.ToString(), veh.NumberOfSeats.ToString(), veh.EngineType, veh.EnginePower.ToString(), veh.TransmissionType, veh.Length.ToString(), veh.Height.ToString(), veh.Width.ToString(), veh.VehicleId, veh.LicensePlate }));
            
        }
    }
}
