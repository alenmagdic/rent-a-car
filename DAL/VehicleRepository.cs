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
    public class VehicleRepository:ModelSubject,IVehicleRepository
    {
        private static VehicleRepository _instance = null;
        private int _idCounter = 0;

        public static VehicleRepository getInstance()
        {
            if (_instance == null)
            {
                _instance = new VehicleRepository();
            }
            return _instance;
        }

        private VehicleRepository()
        {
        }

        
        public void AddVehicle(Vehicle vehicle)
        {
            ValidateModel(vehicle);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                   
                    session.Save(vehicle);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        public void DeleteVehicle(Vehicle vehicle)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    int reservationsForVehicle = session.CreateQuery("from Reservation as r where r.ReservedVehicle.Id=" + vehicle.Id).List<Reservation>().Count;
                    if (reservationsForVehicle > 0)
                    {
                        throw new Exception("Could not delete vehicle because there are reservations associated with this vehicle. Delete the associated reservations in order to be able to delete this vehicle.");

                    }

                    session.Delete(vehicle);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public List<Vehicle> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Vehicle as v");
                List<Vehicle> foundVehicles = query.List<Vehicle>().ToList();

                return foundVehicles;
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            ValidateEditedModel(vehicle);
            Vehicle existingVehicle = FindById(vehicle.Id);
            existingVehicle.Brand = vehicle.Brand;
            existingVehicle.ModelName = vehicle.ModelName;
            existingVehicle.Category = vehicle.Category;
            existingVehicle.TrunkCapacityLiters = vehicle.TrunkCapacityLiters;
            existingVehicle.NumberOfSeats = vehicle.NumberOfSeats;
            existingVehicle.EngineType = vehicle.EngineType;
            existingVehicle.EnginePower = vehicle.EnginePower;
            existingVehicle.TransmissionType = vehicle.TransmissionType;
            existingVehicle.Length = vehicle.Length;
            existingVehicle.Height = vehicle.Height;
            existingVehicle.Width = vehicle.Width;
            existingVehicle.LicensePlate = vehicle.LicensePlate;
            existingVehicle.VehicleId = vehicle.VehicleId;

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingVehicle);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }

        private void ValidateModel(Vehicle vehicle)
        {
            if (FindById(vehicle.Id) != null)
            {
                throw new Exception("There already is a vehicle with given id!");
            }

            ValidateEditedModel(vehicle);
        }

        private void ValidateEditedModel(Vehicle vehicle)
        {
            Vehicle vehicleByVehicleId = FindByVehicleId(vehicle.VehicleId);
            if (vehicleByVehicleId != null && vehicleByVehicleId.Id != vehicle.Id)
            {
                throw new Exception("There already is a vehicle with given vehicle ID!");
            }

        }

        private Vehicle FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Vehicle as v where v.Id=" + id);
                List<Vehicle> foundVehicles = query.List<Vehicle>().ToList();

                return foundVehicles.FirstOrDefault();
            }
        }

        private Vehicle FindByVehicleId(string vehicleId)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from Vehicle as v where v.VehicleId='" + vehicleId+"'");
                List<Vehicle> foundVehicles = query.List<Vehicle>().ToList();

                return foundVehicles.FirstOrDefault();
            }
        }

    }
}
