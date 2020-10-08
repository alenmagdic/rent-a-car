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
    public partial class ShowVehicleBrandsListForm : Form,IShowVehicleBrandsListView
    {
        private List<VehicleBrand> _brandsList = null;
        private IMainFormController _mainFormController = null;

        public ShowVehicleBrandsListForm()
        {
            InitializeComponent();
        }

        public void ShowView(List<VehicleBrand> brandsList, IMainFormController mainFormController)
        {
            _brandsList = brandsList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }

        private void UpdateList()
        {
            _brandsLV.Items.Clear();
            _brandsList = _mainFormController.GetBrandsList();
            foreach(var brand in _brandsList)
            {
                _brandsLV.Items.Add(new ListViewItem(new string[] { brand.BrandName }));
            }
        }

        private void EditSelectedBrand(object sender, EventArgs e)
        {
            foreach (int index in _brandsLV.SelectedIndices)
            {
                VehicleBrand brand = _brandsList.ElementAt(index);
                _mainFormController.ShowEditBrand(brand);
                return;
            }
        }

        private void DeleteSelectedBrand(object sender, EventArgs e)
        {
            List<VehicleBrand> brandsToDelete = new List<VehicleBrand>();           
            foreach (int index in _brandsLV.SelectedIndices)
            {
               brandsToDelete.Add(_brandsList.ElementAt(index));
            }
            _mainFormController.DeleteBrands(brandsToDelete);
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

    }
}
