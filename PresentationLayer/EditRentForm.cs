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
    public partial class EditRentForm : RentRootForm, IEditRentView
    {
        private Rent _rent;
        public Reservation Reservation => _reservations.ElementAt(_reservationCB.SelectedIndex);
        public DateTime StartDate => _startDatePicker.Value;
        public DateTime? EndDate => _endDateUnknownCheckBox.Checked ? null : (DateTime?)_endDatePicker.Value;

        public EditRentForm(List<Reservation> reservations, IMainFormController mainFormController) : base(reservations, mainFormController)
        {
            InitializeComponent();
        }

        public void ShowView(Rent rent)
        {
            _reservationCB.SelectedIndex = _reservations.IndexOf(rent.Reservation);
            _startDatePicker.Value = rent.StartTime;
            if (rent.EndTime == null)
            {
                _endDateUnknownCheckBox.Checked = true;
            }
            else
            {
                _endDatePicker.Value = (DateTime)rent.EndTime;
            }

            _rent = rent;
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.EditRent(this, _rent);
        }

        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetReservationsList());
        }

    }
}
