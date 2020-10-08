using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Factories
{
    public class ClientFactory
    {
        public static Client CreateClient(int id, string name, string clientType, string OIB, string email, string phoneNumber)
        {
            return new Client(id, name, clientType, OIB, email, phoneNumber);
        }
    }
}
