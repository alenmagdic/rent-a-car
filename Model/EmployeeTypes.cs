using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeTypes
    {
        public static readonly string STANDARD_EMPLOYEE = "Standard employee";
        public static readonly string MANAGER = "Manager";

        public static string[] GetValues()
        {
            return new string[] { STANDARD_EMPLOYEE,MANAGER };
        }

    }
}
