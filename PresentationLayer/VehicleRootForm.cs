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
    public partial class VehicleRootForm : Form
    {
        protected List<VehicleBrand> _vehicleBrands;
        protected IMainFormController _mainFormController;

        public VehicleRootForm()
        {
            InitializeComponent();
        }
        
        public VehicleRootForm(List<VehicleBrand> vehicleBrands,IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            InitializeComponent();
            UpdateLists(vehicleBrands);
            FillCheckBoxes(); 
        }

        private void FillCheckBoxes()
        {
            foreach (var cat in VehicleCategories.GetValues())
            {
                _categoryCB.Items.Add(cat);
            }
            _categoryCB.Text = VehicleCategories.SEDAN;

            foreach (var engType in EngineTypes.GetValues())
            {
                _engineTypesCB.Items.Add(engType);
            }
            _engineTypesCB.Text = EngineTypes.PETROL;

            foreach (var transType in TransmissionTypes.GetValues())
            {
                _transTypeCB.Items.Add(transType);
            }
            _transTypeCB.Text = TransmissionTypes.MANUAL;
        }

        protected void UpdateLists(List<VehicleBrand> vehicleBrands)
        {
            VehicleBrand currentSelection = null;
            VehicleBrand newlyAddedBrand = null;
            if (_vehicleBrands != null && currentSelection == null && _vehicleBrands.Count < vehicleBrands.Count) {
                newlyAddedBrand = vehicleBrands.Where(b => !_vehicleBrands.Contains(b)).FirstOrDefault();
            }

            if(_vehicleBrands!=null && _vehicleBrands.Count>0 && _brandCB.SelectedIndex!=-1)
            {
                currentSelection = _vehicleBrands.ElementAt(_brandCB.SelectedIndex);
            }

            _vehicleBrands = vehicleBrands;
            _brandCB.Items.Clear();
            foreach (var br in vehicleBrands)
            {
                _brandCB.Items.Add(br.BrandName);
            }
            if (currentSelection==null && newlyAddedBrand!=null)
            {
                _brandCB.SelectedIndex = _vehicleBrands.IndexOf(newlyAddedBrand);
            } else if(currentSelection!=null)
            {
                int index = _vehicleBrands.IndexOf(currentSelection);
                _brandCB.SelectedIndex = index;
            }

        }


        protected virtual void OnApply(object sender, EventArgs e) {
            try
            {
                CheckComboBoxHasValue(_brandCB, "Invalid vehicle brand!");
                CheckComboBoxHasValue(_categoryCB, "Invalid vehicle category!");
                CheckComboBoxHasValue(_engineTypesCB, "Invalid engine type!");
                CheckComboBoxHasValue(_transTypeCB, "Invalid transmission type!");
            }
            catch (Exception)
            {
                return;
            }
            Apply();
        }

        private void CheckComboBoxHasValue(ComboBox comboBox,string errorMessage)
        {
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

        private void AddBrand(object sender, EventArgs e)
        {
            _mainFormController.ShowAddVehicleBrand();
        }

        private void EditBrand(object sender, EventArgs e)
        {
            if(_brandCB.Text.Length==0)
            {
                return;
            }
            _mainFormController.ShowEditBrand(_vehicleBrands.ElementAt(_brandCB.SelectedIndex));
        }
    }

    
}
