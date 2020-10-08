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
    public class RentRepository:ModelSubject,IRentRepository
    {
        private static RentRepository _instance = null;
        private int _idCounter = 0;

        public static RentRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new RentRepository();
            }
            return _instance;
        }

        public Rent FindByReservation(Reservation reservation)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {

                IQuery query = nhibernateSession.CreateQuery(
                "from Rent as r where r.Reservation.Id=" + reservation.Id);
                List<Rent> foundRents = query.List<Rent>().ToList();
                return foundRents.FirstOrDefault();
            }
        }

        private RentRepository()
        {
        }


        public void AddRent(Rent rent)
        {
            ValidateModel(rent);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(rent);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        public void DeleteRent(Rent rent)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Delete(rent);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public List<Rent> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Rent as r");
                List<Rent> foundRents = query.List<Rent>().ToList();

                return foundRents;
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }

        public void SaveRent(Rent rent)
        {
            ValidateEditedModel(rent);
            Rent existingRent = FindById(rent.Id);
            existingRent.Reservation = rent.Reservation;
            existingRent.SetDates(rent.StartTime, rent.EndTime);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingRent);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        private void ValidateModel(Rent rent)
        {
            if (FindById(rent.Id) != null)
            {
                throw new Exception("There already is a rent with given id!");
            }

            ValidateEditedModel(rent);
        }

        private void ValidateEditedModel(Rent rent)
        {
            Rent rentByReservationId = FindByReservationId(rent.Reservation.Id);
            if (rentByReservationId != null && rentByReservationId.Id != rent.Id)
            {
                throw new Exception("There already is a rent for selected reservation!");
            }

        }

        private Rent FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Rent as r where r.Id=" + id);
                List<Rent> foundRents = query.List<Rent>().ToList();

                return foundRents.FirstOrDefault();
            }
        }

        private Rent FindByReservationId(int reservationId)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {

                IQuery query = nhibernateSession.CreateQuery(
                "from Rent as r where r.Reservation.Id=" + reservationId);
                List<Rent> foundRents = query.List<Rent>().ToList();
                return foundRents.FirstOrDefault();
            }
        }
    }
}
