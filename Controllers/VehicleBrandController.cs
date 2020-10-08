using BaseLib;
using Model;
using Model.Repositories;
using Model.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class VehicleBrandController
    {
        private IVehicleBrandRepository _brandRepository;
        public VehicleBrandController(IVehicleBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public void ShowAddNewBrand(IAddVehicleBrandView inForm,IMainFormController mainFormController)
        {
            inForm.ShowView(mainFormController);
        }

        public void AddNewBrand(IAddVehicleBrandView inForm)
        {
            try
            {
                int id = _brandRepository.GetNewID();
                string name = inForm.BrandName;
                VehicleBrand brand = VehicleBrandFactory.CreateVehicleBrand(id, name);

                _brandRepository.AddVehicleBrand(brand);

                MessageBox.Show("Brand with name " + inForm.BrandName + " added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowBrandsListView(IShowVehicleBrandsListView form, IMainFormController mainFormController)
        {
            form.ShowView(_brandRepository.GetAll(),mainFormController);
            _brandRepository.Attach(form);
        }

        public void DeleteBrands(List<VehicleBrand> brandsToDelete)
        {
            foreach(var brand in brandsToDelete)
            {
                string confirmText = "Are you sure you want to delete brand " + brand.BrandName+"?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    try
                    {
                        _brandRepository.DeleteBrand(brand);
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditBrand(VehicleBrand brand,IMainFormController mainFormController,IEditVehicleBrandView inForm)
        {
            inForm.ShowView(brand,mainFormController);
        }

        internal void EditNewBrand(IEditVehicleBrandView inForm,VehicleBrand brand)
        {
            try
            {
                brand.BrandName = inForm.BrandName;
                _brandRepository.SaveBrand(brand);

                MessageBox.Show("Brand with name " + inForm.BrandName + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}
