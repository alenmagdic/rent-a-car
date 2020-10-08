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
    public partial class EditVehicleForm : VehicleRootForm,IEditVehicleView
    {
        private Vehicle _vehicle;
        public VehicleBrand Brand => _vehicleBrands.ElementAt(_brandCB.SelectedIndex);//_vehicleBrands.Where(br=>_brandCB.Text.Equals(br.BrandName)).FirstOrDefault();
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

        public EditVehicleForm(List<VehicleBrand> vehicleBrands, IMainFormController mainFormController) : base(vehicleBrands,mainFormController)
        {
            InitializeComponent();
        }

        public void ShowView(Vehicle vehicle)
        {
            _brandCB.SelectedIndex = _vehicleBrands.IndexOf(vehicle.Brand);
            _modelNameTB.Text = vehicle.ModelName;
            _categoryCB.Text = vehicle.Category;
            _trunkCapacityNB.Value = vehicle.TrunkCapacityLiters;
            _numOfSeatsNB.Value = vehicle.NumberOfSeats;
            _engineTypesCB.Text = vehicle.EngineType;
            _powerNB.Value = vehicle.EnginePower;
            _transTypeCB.Text = vehicle.TransmissionType;
            _lengthNB.Value = vehicle.Length;
            _heightNB.Value = vehicle.Height;
            _widthNB.Value = vehicle.Width;
            _vehicleIdTB.Text = vehicle.VehicleId;
            _licensePlateTB.Text = vehicle.LicensePlate;

            _vehicle = vehicle;
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.EditVehicle(this, _vehicle);
        }

        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetBrandsList());
        }
    }
}
