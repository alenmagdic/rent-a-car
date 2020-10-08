using BaseLib;
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
    public partial class AddVehicleBrandForm : VehicleBrandRootForm,IAddVehicleBrandView
    {
        public string BrandName => _brandNameTB.Text;
        private IMainFormController _mainFormController;

        public AddVehicleBrandForm()
        {
            InitializeComponent();
        }

        public void ShowView(IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            Show();
        }

        protected override void OnApply(object sender, EventArgs e)
        {
            _mainFormController.AddVehicleBrand(this);
        }

         }
}
