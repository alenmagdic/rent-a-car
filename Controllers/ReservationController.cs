using BaseLib;
using Model;
using Model.Factories;
using Model.Repositories;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controllers
{
    public class ReservationController
    {
        private IReservationRepository _reservationRepository;
        public ReservationController(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void ShowAddNewReservation(IAddReservationView inForm, IMainFormController mainFormController, IClientRepository clientRepository)
        {
            inForm.ShowView();
            clientRepository.Attach(inForm);
        }

        public void AddNewReservation(IAddReservationView inForm,Employee currentEmployee, IRentRepository rentRepository)
        {
            
            try
            {
                int id = _reservationRepository.GetNewID();
                Client client = inForm.ReservationClient;
                Vehicle vehicle = inForm.ReservedVehicle;
                DateTime startDate = inForm.StartDate;
                DateTime endDate = inForm.EndDate;
                Employee employee = currentEmployee;

                Reservation reservation = ReservationFactory.CreateReservation(id,client,vehicle,startDate,endDate,employee);

                var filterService = VehicleFilterService.GetInstance();
                bool isAvailable = filterService.IsVehicleAvailableAtTime(vehicle, startDate, endDate, _reservationRepository, rentRepository);
                if(!isAvailable)
                {
                    MessageBox.Show("Reservation could not be added because the selected vehicle is not available during selected time interval!", "Fail");
                    return;
                }

                _reservationRepository.AddReservation(reservation);

                MessageBox.Show("Reservation for client " + inForm.ReservationClient.Name + " added successfully! Reservation id: "+reservation.Id, "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public void ShowReservationListView(IShowReservationListView form, IMainFormController mainFormController)
        {
            form.ShowView(_reservationRepository.GetAll(), mainFormController);
            _reservationRepository.Attach(form);
        }

        public void DeleteReservation(List<Reservation> reservationsToDelete)
        {
            foreach (var res in reservationsToDelete)
            {
                string confirmText = "Are you sure you want to delete reservation for client " + res.ReservationClient.Name + "?";
                var confirmation = MessageBox.Show(confirmText, "Confirmation", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    
                    try
                    {
                        _reservationRepository.DeleteReservation(res);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Fail");
                    }
                }
            }
        }

        public void ShowEditReservation(Reservation reservation, IMainFormController mainFormController, IEditReservationView inForm, IClientRepository clientRepository)
        {
            inForm.ShowView(reservation);
            clientRepository.Attach(inForm);
        }

        
        internal void EditNewReservation(IEditReservationView inForm, Reservation reservation)
        {
            try
            {
                reservation.ReservationClient = inForm.ReservationClient;
                reservation.ReservedVehicle = inForm.ReservedVehicle;
                reservation.SetDates(inForm.StartDate, inForm.EndDate);
                _reservationRepository.SaveReservation(reservation);
                MessageBox.Show("Reservation for client " + inForm.ReservationClient.Name + " saved successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail");
            }
        }

        public double GetReservationDuration(DateTime startDate, DateTime endTime)
        {
            return Reservation.CalculateReservationDurationInDays(startDate, endTime);
        }
    }
}
