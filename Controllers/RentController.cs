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
    public class RentController
    {
        private IRentRepository _rentRepository;
        public RentController(IRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }

        public void ShowAddNewRent(IAddRentView inForm, IMainFormController mainFormController, IReservationRepository reservationRepository)
        {
            inForm.ShowView();
            reservationRepository.Attach(inForm);
        }

        public void AddNewRent(IAddRentView inForm)
        {
            try
            {
                int id = _rentRepository.GetNewID();
                Reservation res = inForm.Reservation;
                DateTime startDate = inForm.StartDate;
                DateTime? endDate = inForm.EndDate;
                
                Rent rent = RentFactory.CreateRent(id,res,startDate,endDate);

                _rentRepository.AddRent(rent);

                MessageBox.Show("Rent for reservation with ID " + inForm.Reservation.Id + " added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowRentListView(IShowRentListView form, IMainFormController mainFormController)
        {
            form.ShowView(_rentRepository.GetAll(), mainFormController);
            _rentRepository.Attach(form);
        }

        public void DeleteRent(List<Rent> rentsToDelete)
        {
            foreach (var rent in rentsToDelete)
            {
                string confirmText = "Are you sure you want to delete rent for reservation with ID" + rent.Reservation.Id + "?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    
                    try
                    {
                        _rentRepository.DeleteRent(rent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditRent(Rent rent, IMainFormController mainFormController, IEditRentView inForm, IReservationRepository reservationRepository)
        {
            inForm.ShowView(rent);
            reservationRepository.Attach(inForm);
        }

        internal void EditNewRent(IEditRentView inForm, Rent rent)
        {
            try
            {
                rent.Reservation = inForm.Reservation;
                rent.SetDates(inForm.StartDate, inForm.EndDate);

                _rentRepository.SaveRent(rent);
                MessageBox.Show("Rent for reservation with id " + inForm.Reservation.Id + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }
    }
}
