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
    public partial class RentRootForm : Form
    {
        protected List<Reservation> _reservations;
        protected IMainFormController _mainFormController;

        public RentRootForm()
        {
            InitializeComponent();
        }

        public RentRootForm(List<Reservation> reservations, IMainFormController mainFormController)
        {
            _mainFormController = mainFormController;
            InitializeComponent();
            UpdateLists(reservations);
        }

        protected void UpdateLists(List<Reservation> reservations)
        {
            Reservation currentSelection = null;
            Reservation newlyAddedRes = null;
            if (_reservations != null && currentSelection == null && _reservations.Count < reservations.Count)
            {
                newlyAddedRes = reservations.Where(r => !_reservations.Contains(r)).FirstOrDefault();
            }

            if (_reservations != null && _reservations.Count > 0 && _reservationCB.SelectedIndex != -1)
            {
                currentSelection = _reservations.ElementAt(_reservationCB.SelectedIndex);
            }

            _reservations = reservations;
            _reservationCB.Items.Clear();
            foreach (var res in reservations)
            {
                _reservationCB.Items.Add("Id:"+res.Id+", client name:"+res.ReservationClient.Name+", vehicle license plate: "+res.ReservedVehicle.LicensePlate);
            }
            if (currentSelection == null && newlyAddedRes != null)
            {
                _reservationCB.SelectedIndex = _reservations.IndexOf(newlyAddedRes);
            }
            else if (currentSelection != null)
            {
                int index = _reservations.IndexOf(currentSelection);
                _reservationCB.SelectedIndex = index;
            }

        }

        protected virtual void OnApply(object sender, EventArgs e)
        {
            try
            {
                CheckComboBoxHasValue(_reservationCB, "Invalid reservation!");
            }
            catch (Exception)
            {
                return;
            }
            Apply();
        }

        private void CheckComboBoxHasValue(ComboBox comboBox, string errorMessage)
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

        private void AddReservation(object sender, EventArgs e)
        {
            _mainFormController.ShowAddReservation();
        }

        private void EditReservation(object sender, EventArgs e)
        {
            if (_reservationCB.Text.Length == 0)
            {
                return;
            }
            _mainFormController.ShowEditReservation(_reservations.ElementAt(_reservationCB.SelectedIndex));
        }
    }
}
