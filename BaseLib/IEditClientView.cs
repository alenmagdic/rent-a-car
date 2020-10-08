using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib
{
    public interface IEditClientView
    {
        void ShowView(Client client, IMainFormController mainFormController);
        string Name { get; }
        string ClientType { get; }
        string OIB { get; }
        string Email { get; }
        string PhoneNumber { get; }
    }
}
