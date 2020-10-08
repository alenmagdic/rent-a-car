using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Client
    {
        private readonly int OIB_LENGTH = 11;

        public Client() { }

        public Client(Client c) : this(c.Id,c.Name,c.ClientType,c.OIB,c.Email,c.PhoneNumber)
        {
        }

        public Client(int id, string name, string clientType, string oIB, string email, string phoneNumber)
        {
            Id = id;
            Name = name;
            ClientType = clientType;
            OIB = oIB;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public int Id
        {
            get;set;
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Name can not be empty!");
                }
                _name = value;
            }
        }

        private string _oib;
        public string OIB
        {
            get
            {
                return _oib;
            }
            set
            {
                value = value.Trim();
                if (value.Length != OIB_LENGTH)
                {
                    throw new Exception("OIB must be exactly " + OIB_LENGTH + " characters long!");
                }
                if (!value.All(c => c >= '0' && c <= '9'))
                {
                    throw new Exception("Invalid OIB!");
                }
                _oib = value;
            }
        }

        private string _clientType;
        public string ClientType
        {
            get
            {
                return _clientType;
            }
            set
            {
                if (ClientTypes.GetValues().Contains(value))
                {
                    _clientType = value;
                    return;
                }
                throw new Exception("Trying to set invalid client type: " + value);
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Email can not be empty!");
                }
                if(!value.Contains("@") || value.StartsWith("@") || value.EndsWith("@") || value.LastIndexOf("@")!=value.IndexOf("@"))
                {
                    throw new Exception("Invalid email!");
                }
                _email = value;
            }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                value = value.Trim();
                if (value.Length < 1)
                {
                    throw new Exception("Phone number can not be empty!");
                }
                if (!value.All(c => c >= '0' && c <= '9'))
                {
                    throw new Exception("Invalid phone number! Please enter only digits, without any other characters!");
                }
                _phoneNumber = value;
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Client)
            {
                if ((obj as Client).Id == Id)
                {
                    return true;
                }
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
