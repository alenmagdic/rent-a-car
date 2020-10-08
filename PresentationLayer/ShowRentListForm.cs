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
    public partial class ShowRentListForm : Form, IShowRentListView
    {
        private List<Rent> _rentsList = null;
        private IMainFormController _mainFormController = null;

        public ShowRentListForm()
        {
            InitializeComponent();
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

        private void UpdateList()
        {
            _rentsLV.Items.Clear();
            _rentsList = _mainFormController.GetRentsList();
            foreach (var rent in _rentsList)
            {
                var res = rent.Reservation;
                var vehicle = res.ReservedVehicle;
                _rentsLV.Items.Add(new ListViewItem(new string[] { res.Id.ToString(),res.ReservationClient.Name,res.ReservationClient.OIB,
                    rent.StartTime.ToString(),rent.EndTime.ToString(),res.ReservedVehicle.Brand.BrandName,vehicle.ModelName,
                    vehicle.LicensePlate,vehicle.VehicleId }));
            }
        }

        private void EditSelectedRent(object sender, EventArgs e)
        {
            foreach (int index in _rentsLV.SelectedIndices)
            {
                Rent rent = _rentsList.ElementAt(index);
                _mainFormController.ShowEditRent(rent);
                return;
            }
        }

        private void DeleteSelectedRents(object sender, EventArgs e)
        {
            List<Rent> rentsToDelete = new List<Rent>();
            foreach (int index in _rentsLV.SelectedIndices)
            {
                rentsToDelete.Add(_rentsList.ElementAt(index));
            }
            _mainFormController.DeleteRent(rentsToDelete);
        }

        public void ShowView(List<Rent> rentsList, IMainFormController mainFormController)
        {
            _rentsList = rentsList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }
    }
}
