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
    public partial class AddRentForm : RentRootForm, IAddRentView
    {
        public Reservation Reservation => _reservations.ElementAt(_reservationCB.SelectedIndex);
        public DateTime StartDate => _startDatePicker.Value;
        public DateTime? EndDate => _endDateUnknownCheckBox.Checked?null:(DateTime?)_endDatePicker.Value;

        public AddRentForm(List<Reservation> reservations, IMainFormController mainFormController) : base(reservations, mainFormController)
        {
            InitializeComponent();
        }


        public void ShowView()
        {
            Show();
        }

        protected override void Apply()
        {
            _mainFormController.AddRent(this);
        }

        public void OnModelChanged()
        {
            UpdateLists(_mainFormController.GetReservationsList());
        }
    }
}
