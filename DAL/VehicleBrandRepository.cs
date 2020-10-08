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
    public class VehicleBrandRepository : ModelSubject, IVehicleBrandRepository
    {
        private static VehicleBrandRepository _instance = null;
        private int _idCounter = 0;

        private VehicleBrandRepository()
        {
        }

        private void ValidateModel(VehicleBrand brand)
        {
            ValidateEditedModel(brand);
            if (FindById(brand.Id) != null)
            {
                throw new Exception("There already is a brand with given id!");
            }
        }

        private void ValidateEditedModel(VehicleBrand brand)
        {
            VehicleBrand brandByName = FindByName(brand.BrandName);
            if (brandByName != null && brandByName.Id!=brand.Id)
            {
                throw new Exception("There already is a brand with given name!");
            }
        }

        public int GetNewID()
        {
            _idCounter++;
            return _idCounter;
        }

        public static VehicleBrandRepository getInstance()
        {
            if(_instance==null)
            {
                _instance = new VehicleBrandRepository();
            }
            return _instance;
        }

        public void AddVehicleBrand(VehicleBrand brand)
        {
            ValidateModel(brand);

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(brand);
                    transaction.Commit();
                }

            }

            NotifyObservers();
        }

        
        public VehicleBrand FindByName(string name)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from VehicleBrand as b where b.BrandName='" + name+"'");
                List<VehicleBrand> foundBrands = query.List<VehicleBrand>().ToList();

                return foundBrands.FirstOrDefault();
            }
        }

        public VehicleBrand FindById(int id)
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from VehicleBrand as b where b.Id=" + id);
                List<VehicleBrand> foundBrands = query.List<VehicleBrand>().ToList();

                return foundBrands.FirstOrDefault();
            }
        }

        public List<VehicleBrand> GetAll()
        {
            using (ISession nhibernateSession = NHibernateService.OpenSession())
            {
                IQuery query = nhibernateSession.CreateQuery(
                "from VehicleBrand as b");
                List<VehicleBrand> foundBrands = query.List<VehicleBrand>().ToList();

                return foundBrands;
            }
        }

        public void DeleteBrand(VehicleBrand brand)
        {
            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    int vehiclesForBrand = session.CreateQuery("from Vehicle as v where v.Brand.Id="+brand.Id).List<Vehicle>().Count;
                    if(vehiclesForBrand>0)
                    {
                        throw new Exception("Could not delete brand because there are vehicles belonging to this brand. Delete that vehicles in order to be able to delete this brand.");
                        
                    }

                    session.Delete(brand);
                    transaction.Commit();
                }

            }
            NotifyObservers();
        }

        public void SaveBrand(VehicleBrand brand)
        {
            ValidateEditedModel(brand);
            VehicleBrand existingBrand = FindById(brand.Id);
            existingBrand.BrandName = brand.BrandName;

            using (ISession session = NHibernateService.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Update(existingBrand);
                    transaction.Commit();
                }
            }

            NotifyObservers();
        }
    }
}
