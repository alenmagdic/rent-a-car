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
    public partial class ShowReservationListForm : Form,IShowReservationListView
    {
        private List<Reservation> _reservationsList = null;
        private IMainFormController _mainFormController = null;

        public ShowReservationListForm()
        {
            InitializeComponent();
        }

        public void OnModelChanged()
        {
            UpdateList();
        }

        public void ShowView(List<Reservation> reservationsList, IMainFormController mainFormController)
        {
            _reservationsList = reservationsList;
            _mainFormController = mainFormController;
            UpdateList();
            Show();
        }

        private void UpdateList()
        {
            _reservationsLV.Items.Clear();
            _reservationsList = _mainFormController.GetReservationsList();
            foreach (var res in _reservationsList)
            {
                _reservationsLV.Items.Add(new ListViewItem(new string[] { res.Id.ToString(),res.ReservationClient.Name,res.ReservationClient.OIB,
                    res.StartDate.ToString(),res.EndDate.ToString(),res.ReservedVehicle.Brand.BrandName,res.ReservedVehicle.ModelName,
                    res.ReservedVehicle.LicensePlate,res.ReservedVehicle.VehicleId,res.CalculateReservationDurationInDays().ToString() }));
            }
        }

        private void EditSelectedReservation(object sender, EventArgs e)
        {
            foreach (int index in _reservationsLV.SelectedIndices)
            {
                Reservation res = _reservationsList.ElementAt(index);
                _mainFormController.ShowEditReservation(res);
                return;
            }
        }

        private void DeleteSelectedReservations(object sender, EventArgs e)
        {
            List<Reservation> reservationsToDelete = new List<Reservation>();
            foreach (int index in _reservationsLV.SelectedIndices)
            {
                reservationsToDelete.Add(_reservationsList.ElementAt(index));
            }
            _mainFormController.DeleteReservation(reservationsToDelete);
        }
    }
}
