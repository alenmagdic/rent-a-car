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
    public partial class ReservationRootForm : Form,IVehicleFilterView
    {
        protected List<Client> _clients;
        protected List<Vehicle> _availableVehicles;
        protected List<VehicleBrand> _vehicleBrands;
        protected IMainFormController _mainFormController;

        public DateTime ReservationStartDate => _startDatePicker.Value;
        public DateTime ReservationEndDate => _endDatePicker.Value;
        public VehicleBrand Brand => _brandCB.Text.Trim().Length==0?null:_vehicleBrands.ElementAt(_brandCB.SelectedIndex);
        public string Category => _categoryCB.Text.Trim().Length == 0 ? null : _categoryCB.Text;
        public string EngineType => _engineTypesCB.Text.Trim().Length == 0 ? null : _engineTypesCB.Text;
        public string TransmissionType => _transTypeCB.Text.Trim().Length == 0 ? null : _transTypeCB.Text;
        public int? MinPower =>  (_minPowerNB as UpDownBase).Text.Length==0 ? null : (int?)_minPowerNB.Value;
        public int? MaxPower => (_maxPowerNB as UpDownBase).Text.Length == 0 ? null : (int?)_maxPowerNB.Value;
        public int? MinTrunkCapacity => (_minTrunkCapacityNB as UpDownBase).Text.Length == 0 ? null : (int?)_minTrunkCapacityNB.Value;
        public int? MaxTrunkCapacity => (_maxTrunkCapacityNB as UpDownBase).Text.Length == 0 ? null : (int?)_maxTrunkCapacityNB.Value;
        public int? MinNumOfSeats => (_minNumOfSeatsNB as UpDownBase).Text.Length == 0 ? null : (int?)_minNumOfSeatsNB.Value;
        public int? MaxNumOfSeats => (_maxNumOfSeatsNB as UpDownBase).Text.Length == 0 ? null : (int?)_maxNumOfSeatsNB.Value;
        public int? MinLength => (_minLengthNB as UpDownBase).Text.Length == 0 ? null : (int?)_minLengthNB.Value;
        public int? MaxLength => (_maxLengthNB as UpDownBase).Text.Length == 0 ? null : (int?)_maxLengthNB.Value;

        public ReservationRootForm()
        {
            InitializeComponent();
        }

        public ReservationRootForm(List<Client> clients, List<VehicleBrand> vehicleBrands, IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            InitializeComponent();
            ResetFilterCriteria();
            UpdateLists(clients, vehicleBrands);
            FillCheckBoxes();
            RefreshVehiclesList();
        }

        private void ResetFilterCriteria()
        {
            _brandCB.Text = "";
            _categoryCB.Text = "";
            _engineTypesCB.Text = "";
            _transTypeCB.Text = "";
            (_minPowerNB as UpDownBase).Text = "";
            (_maxPowerNB as UpDownBase).Text = "";
            (_minTrunkCapacityNB as UpDownBase).Text = "";
            (_maxTrunkCapacityNB as UpDownBase).Text = "";
            (_minNumOfSeatsNB as UpDownBase).Text = "";
            (_maxNumOfSeatsNB as UpDownBase).Text = "";
            (_minLengthNB as UpDownBase).Text = "";
            (_maxLengthNB as UpDownBase).Text = "";
        }

        protected Vehicle GetSelectedVehicle()
        {
            foreach (int index in _vehiclesLV.SelectedIndices)
            {
                Vehicle vehicle = _availableVehicles.ElementAt(index);
                _mainFormController.ShowEditVehicle(vehicle);
                return vehicle;
            }
            return null;
        }

        public virtual void RefreshVehiclesList()
        {
            _vehiclesLV.Items.Clear();
            _availableVehicles = _mainFormController.GetVehiclesMeetingCriteria(this);
            foreach (var veh in _availableVehicles)
            {
                _vehiclesLV.Items.Add(new ListViewItem(new string[] { veh.Brand.BrandName, veh.ModelName, veh.Category, veh.TrunkCapacityLiters.ToString(), veh.NumberOfSeats.ToString(), veh.EngineType, veh.EnginePower.ToString(), veh.TransmissionType, veh.Length.ToString(), veh.Height.ToString(), veh.Width.ToString(), veh.VehicleId, veh.LicensePlate }));
            }
        }

        private void FillCheckBoxes()
        {
            foreach (var cat in VehicleCategories.GetValues())
            {
                _categoryCB.Items.Add(cat);
            }

            foreach (var engType in EngineTypes.GetValues())
            {
                _engineTypesCB.Items.Add(engType);
            }

            foreach (var transType in TransmissionTypes.GetValues())
            {
                _transTypeCB.Items.Add(transType);
            }
        }

        protected void UpdateLists(List<Client> clients, List<VehicleBrand> vehicleBrands)
        {
            Client currentClient = null;
            Client newlyAddedClient = null;
            if (_clients != null && currentClient == null && _clients.Count < clients.Count)
            {
                newlyAddedClient = clients.Where(c => !_clients.Contains(c)).FirstOrDefault();
            }

            if (_clients != null && _clients.Count > 0 && _clientCB.SelectedIndex != -1)
            {
                currentClient = _clients.ElementAt(_clientCB.SelectedIndex);
            }

            _clients = clients;
            _clientCB.Items.Clear();
            foreach (var cl in clients)
            {
                _clientCB.Items.Add(cl.Name+",OIB:"+cl.OIB+",email:"+cl.Email+",phone number:"+cl.PhoneNumber);
            }
            if (currentClient == null && newlyAddedClient != null)
            {
                _clientCB.SelectedIndex = _clients.IndexOf(newlyAddedClient);
            }
            else if (currentClient != null)
            {
                int index = _clients.IndexOf(currentClient);
                _clientCB.SelectedIndex = index;
            }

            VehicleBrand currentBrand = null;
            
            if (_vehicleBrands != null && _vehicleBrands.Count > 0 && _brandCB.SelectedIndex != -1)
            {
                currentBrand = _vehicleBrands.ElementAt(_brandCB.SelectedIndex);
            }

            _vehicleBrands = vehicleBrands;
            _brandCB.Items.Clear();
            foreach (var br in vehicleBrands)
            {
                _brandCB.Items.Add(br.BrandName);
            }
            if (currentBrand != null)
            {
                int index = _vehicleBrands.IndexOf(currentBrand);
                _brandCB.SelectedIndex = index;
            }
        }


        protected virtual void OnApply(object sender, EventArgs e)
        {
            try
            {
                CheckComboBoxHasValue(_clientCB, "Invalid client selection!",false);
            }
            catch (Exception)
            {
                return;
            }
            Apply();
        }

        private void CheckComboBoxHasValue(ComboBox comboBox, string errorMessage, bool permitEmptyInput)
        {
            if(permitEmptyInput && comboBox.Text.Trim().Length == 0)
            {
                return;
            }
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

        private void AddClient(object sender, EventArgs e)
        {
            _mainFormController.ShowAddClient();
        }

        private void EditClient(object sender, EventArgs e)
        {
            if (_clientCB.Text.Length == 0)
            {
                return;
            }
            _mainFormController.ShowEditClient(_clients.ElementAt(_clientCB.SelectedIndex));
        }
       
        private void ResetFilter(object sender, EventArgs e)
        {
            ResetFilterCriteria();
        }

        private void ReloadVehiclesList(object sender, EventArgs e)
        {
            try
            {
                CheckComboBoxHasValue(_brandCB, "Invalid vehicle brand!", true);
                CheckComboBoxHasValue(_categoryCB, "Invalid vehicle category!", true);
                CheckComboBoxHasValue(_engineTypesCB, "Invalid engine type!", true);
                CheckComboBoxHasValue(_transTypeCB, "Invalid transmission type!", true);
            }
            catch (Exception)
            {
                return;
            }
            RefreshVehiclesList();
        }

        private void UpdateDuration(object sender, EventArgs e)
        {
            double duration = _mainFormController.GetReservationDuration(_startDatePicker.Value, _endDatePicker.Value);
            _reservationDurationValueLabel.Text = Math.Round(duration, 2) + " days";
        }
    }
}
