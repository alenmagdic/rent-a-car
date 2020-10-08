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
    public partial class EditVehicleBrandForm : VehicleBrandRootForm,IEditVehicleBrandView
    {
        private IMainFormController _mainFormController;
        private VehicleBrand _brand;

        public EditVehicleBrandForm()
        {
            InitializeComponent();
        }

        public string BrandName => _brandNameTB.Text;

        public void ShowView(VehicleBrand brand,IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            _brandNameTB.Text = brand.BrandName;
            _brand = brand;
            Show();
        }

        protected override void OnApply(object sender, EventArgs e)
        {
            _mainFormController.EditVehicleBrand(this,_brand);
        }

    }
}
