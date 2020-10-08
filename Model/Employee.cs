using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        private readonly int OIB_LENGTH = 11;

        public Employee() { }

        public Employee(int id, string username, string employeeType, string firstName, string lastName, string oib, string password)
        {
            Id = id;
            Username = username;
            EmployeeType = employeeType;
            FirstName = firstName;
            LastName = lastName;
            OIB = oib;
            Password = password;
        }

        public Employee(Employee e) : this(e.Id,e.Username,e.EmployeeType,e.FirstName,e.LastName,e.OIB,e.Password)
        {
        }

        public int Id
        {
            get;set;
        }

        private string _username;
        public string Username
        {
            get
            {
                return _username;
            } set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Username can not be empty!");
                }
                _username = value;
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Password can not be empty!");
                }
                _password = value;
            }
        }

        private string _employeeType;
        public string EmployeeType
        {
            get {
                return _employeeType;
            }
            set
            {
                if(EmployeeTypes.GetValues().Contains(value))
                {
                    _employeeType = value;
                    return;
                }
                throw new Exception("Trying to set invalid employee type: "+value);
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
                    throw new Exception("OIB must be exactly "+OIB_LENGTH+" characters long!");
                }
                if(!value.All(c => c >= '0' && c <= '9'))
                {
                    throw new Exception("Invalid OIB!");
                }
                _oib = value;
            }
        }

        private string _firstName;
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("First name can not be empty!");
                }
                _firstName = value;
            }
        }

        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Last name can not be empty!");
                }
                _lastName = value;
            }
        }

        public override bool Equals(object obj)
        {
            if(obj==null)
            {
                return false;
            }
            if(obj is Employee)
            {
                if((obj as Employee).Id==Id)
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
