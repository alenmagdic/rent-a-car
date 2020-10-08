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
    public partial class ShowVehicleListForm : Form, IShowVehicleListView
    {
        private List<Vehicle> _vehiclesList = null;
        private IMainFormController _mainFormController = null;


        public ShowVehicleListForm()
        {
            InitializeComponent();
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

        private void UpdateList()
        {
            _vehiclesLV.Items.Clear();
            _vehiclesList = _mainFormController.GetVehiclesList();
            foreach (var veh in _vehiclesList)
            {
                _vehiclesLV.Items.Add(new ListViewItem(new string[] { veh.Brand.BrandName,veh.ModelName,veh.Category,veh.TrunkCapacityLiters.ToString(),veh.NumberOfSeats.ToString(),veh.EngineType,veh.EnginePower.ToString(),veh.TransmissionType,veh.Length.ToString(),veh.Height.ToString(),veh.Width.ToString(),veh.VehicleId,veh.LicensePlate}));
            }
        }

        public void ShowView(List<Vehicle> vehiclesList, IMainFormController mainFormController)
        {
            _vehiclesList = vehiclesList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }

        private void EditSelectedVehicle(object sender, EventArgs e)
        {
            foreach (int index in _vehiclesLV.SelectedIndices)
            {
                Vehicle vehicle = _vehiclesList.ElementAt(index);
                _mainFormController.ShowEditVehicle(vehicle);
                return;
            }
        }

        private void DeleteSelectedVehicles(object sender, EventArgs e)
        {
            List<Vehicle> vehiclesToDelete = new List<Vehicle>();
            foreach (int index in _vehiclesLV.SelectedIndices)
            {
                vehiclesToDelete.Add(_vehiclesList.ElementAt(index));
            }
            _mainFormController.DeleteVehicle(vehiclesToDelete);
        }
    }
}
