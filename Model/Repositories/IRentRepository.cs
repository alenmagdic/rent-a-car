using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IRentRepository : IModelSubject
    {
        Rent FindByReservation(Reservation r);
        int GetNewID();
        void AddRent(Rent rent);
        List<Rent> GetAll();
        void DeleteRent(Rent rent);
        void SaveRent(Rent rent);
    }
}
