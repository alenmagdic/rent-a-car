using BaseLib;
using Model;
using Model.Factories;
using Model.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class VehicleController
    {
        private IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public void ShowAddNewVehicle(IAddVehicleView inForm, IMainFormController mainFormController,IVehicleBrandRepository brandRepository)
        {
            inForm.ShowView();
            brandRepository.Attach(inForm);
        }

        public void AddNewVehicle(IAddVehicleView inForm)
        {
            try
            {
                int id = _vehicleRepository.GetNewID();
                VehicleBrand brand = inForm.Brand;
                string modelName = inForm.ModelName;
                string category = inForm.Category;
                int trunkCapacity = inForm.TrunkCapacity;
                int numberOfSeats = inForm.NumberOfSeats;
                string engineType = inForm.EngineType;
                int power = inForm.Power;
                string transmissionType = inForm.TransmissionType;
                int length = inForm.Length;
                int height = inForm.Height;
                int width = inForm.Width;
                string licensePlate = inForm.LicensePlate;
                string vehicleId = inForm.VehicleId;
                Vehicle vehicle = VehicleFactory.CreateVehicle(id,brand,modelName,category,trunkCapacity,
                    numberOfSeats,engineType,power,transmissionType,
                    length,height,width,licensePlate,vehicleId);

                _vehicleRepository.AddVehicle(vehicle);

                MessageBox.Show("Vehicle with ID " + inForm.VehicleId + " added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowVehicleListView(IShowVehicleListView form, IMainFormController mainFormController)
        {
            form.ShowView(_vehicleRepository.GetAll(), mainFormController);
            _vehicleRepository.Attach(form);
        }

        public void DeleteVehicle(List<Vehicle> vehiclesToDelete)
        {
            foreach (var vehicle in vehiclesToDelete)
            {
                string confirmText = "Are you sure you want to delete vehicle with ID" + vehicle.VehicleId + "?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    
                    try
                    {
                        _vehicleRepository.DeleteVehicle(vehicle);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditVehicle(Vehicle vehicle, IMainFormController mainFormController, IEditVehicleView inForm,IVehicleBrandRepository brandRepository)
        {
            inForm.ShowView(vehicle);
            brandRepository.Attach(inForm);
        }

        internal void EditNewVehicle(IEditVehicleView inForm, Vehicle vehicle)
        {
            try
            {
                vehicle.Brand = inForm.Brand;
                vehicle.ModelName = inForm.ModelName;
                vehicle.Category = inForm.Category;
                vehicle.TrunkCapacityLiters = inForm.TrunkCapacity;
                vehicle.NumberOfSeats = inForm.NumberOfSeats;
                vehicle.EngineType = inForm.EngineType;
                vehicle.EnginePower = inForm.Power;
                vehicle.TransmissionType = inForm.TransmissionType;
                vehicle.Length = inForm.Length;
                vehicle.Height = inForm.Height;
                vehicle.Width = inForm.Width;
                vehicle.LicensePlate = inForm.LicensePlate;
                vehicle.VehicleId = inForm.VehicleId;
                _vehicleRepository.SaveVehicle(vehicle);
                MessageBox.Show("Vehicle with ID " + inForm.VehicleId + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}
