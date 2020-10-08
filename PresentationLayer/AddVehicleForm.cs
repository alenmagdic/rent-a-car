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
    public partial class AddVehicleForm : VehicleRootForm, IAddVehicleView
    {
        public VehicleBrand Brand => _vehicleBrands.ElementAt(_brandCB.SelectedIndex);
        public string ModelName => _modelNameTB.Text;
        public string Category => _categoryCB.Text;
        public int TrunkCapacity => (int)_trunkCapacityNB.Value;
        public int NumberOfSeats => (int)_numOfSeatsNB.Value;
        public string EngineType => _engineTypesCB.Text;
        public int Power => (int)_powerNB.Value;
        public string TransmissionType => _transTypeCB.Text;
        public int Length => (int)_lengthNB.Value;
        public new int Height => (int)_heightNB.Value;
        public new int Width => (int)_widthNB.Value;
        public string LicensePlate => _licensePlateTB.Text;
        public string VehicleId => _vehicleIdTB.Text;


        public AddVehicleForm(List<VehicleBrand> vehicleBrands, IMainFormController mainFormController) : base(vehicleBrands,mainFormController)
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.AddVehicle(this);
        }

        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetBrandsList());
        }
    }
}
