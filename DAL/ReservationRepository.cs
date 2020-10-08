using Model;
using Model.Repositories;
using Model.Subject;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReservationRepository:ModelSubject,IReservationRepository
    {
        private static ReservationRepository _instance = null;
        private int _idCounter = 0;

        public static ReservationRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new ReservationRepository();
            }
            return _instance;
        }

        private ReservationRepository()
        {
        }




        public void AddReservation(Reservation reservation)
        {
            ValidateModel(reservation);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(reservation);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        public void DeleteReservation(Reservation reservation)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    int rentsForReservation = session.CreateQuery("from Rent as r where r.Reservation.Id=" + reservation.Id).List<Rent>().Count;
                    if (rentsForReservation > 0)
                    {
                        throw new Exception("Could not delete reservation because there is a rent associated with this reservation. Delete the associated rent in order to be able to delete this reservation.");

                    }

                    session.Delete(reservation);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public List<Reservation> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Reservation as r");
                List<Reservation> foundReservations = query.List<Reservation>().ToList();

                return foundReservations;
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }

        public void SaveReservation(Reservation reservation)
        {
            ValidateEditedModel(reservation);
            Reservation existingReservation = FindById(reservation.Id);
            existingReservation.ReservationClient = reservation.ReservationClient;
            existingReservation.Employee = reservation.Employee;
            existingReservation.ReservedVehicle = reservation.ReservedVehicle;
            existingReservation.SetDates(reservation.StartDate, reservation.EndDate);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingReservation);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        private void ValidateModel(Reservation reservation)
        {
            if (FindById(reservation.Id) != null)
            {
                throw new Exception("There already is a reservation with given id!");
            }

            ValidateEditedModel(reservation);
        }

        private void ValidateEditedModel(Reservation reservation)
        {
        }

        private Reservation FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Reservation as r where r.Id=" + id);
                List<Reservation> foundReservations = query.List<Reservation>().ToList();

                return foundReservations.FirstOrDefault();
            }
        }

        public List<Reservation> GetForVehicle(Vehicle vehicle)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                
                IQuery query = nhibernateSession.CreateQuery(
                "from Reservation as r where r.ReservedVehicle.Id=" + vehicle.Id);
                List<Reservation> foundReservations = query.List<Reservation>().ToList();

                return foundReservations;
            }

           
        }
    }
}
