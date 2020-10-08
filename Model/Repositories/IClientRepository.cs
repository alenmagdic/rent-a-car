using Model.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Repositories
{
    public interface IClientRepository : IModelSubject
    {
        int GetNewID();
        void AddClient(Client client);
        List<Client> GetAll();
        void DeleteClient(Client client);
        void SaveClient(Client client);
    }
}
