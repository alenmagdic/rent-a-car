using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Model.Repositories;
using Model.Subject;
using NHibernate;

namespace DAL
{
    public class ClientRepository: ModelSubject,IClientRepository
    {
        private static ClientRepository _instance = null;
        private int _idCounter = 0;

        private ClientRepository()
        {
        }

        public static ClientRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new ClientRepository();
            }
            return _instance;
        }

        public void AddClient(Client client)
        {
            ValidateModel(client);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(client);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        public void DeleteClient(Client client)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    int reservationsForClient = session.CreateQuery("from Reservation as r where r.ReservationClient.Id=" + client.Id).List<Reservation>().Count;
                    if (reservationsForClient > 0)
                    {
                        throw new Exception("Could not delete client because there is are reservations associated with this client. Delete the associated reservations in order to be able to delete this client.");

                    }

                    session.Delete(client);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public List<Client> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Client as cl");
                List<Client> foundClients = query.List<Client>().ToList();

                return foundClients;
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }

        public void SaveClient(Client client)
        {
            ValidateEditedModel(client);
            Client existingClient = FindById(client.Id);
            existingClient.Name = client.Name;
            existingClient.ClientType = client.ClientType;
            existingClient.Email = client.Email;
            existingClient.PhoneNumber = client.PhoneNumber;
            existingClient.OIB = client.OIB;

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingClient);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        private void ValidateModel(Client client)
        {
            if (FindById(client.Id) != null)
            {
                throw new Exception("There already is a client with given id!");
            }

            ValidateEditedModel(client);
        }

        private void ValidateEditedModel(Client client)
        {
            Client clientByOIB = FindByOIB(client.OIB);
            if (clientByOIB != null && clientByOIB.Id != client.Id)
            {
                throw new Exception("There already is a client with given OIB!");
            }
        }

        private Client FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Client as c where c.Id=" + id);
                List<Client> foundClients = query.List<Client>().ToList();

                return foundClients.FirstOrDefault();
            }
        }

        private Client FindByOIB(string oib)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Client as c where c.OIB='" + oib + "'");
                List<Client> foundClients = query.List<Client>().ToList();

                return foundClients.FirstOrDefault();
            }
        }

    }
}
