using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ClientTypes
    {
        public static readonly string PERSON = "Person";
        public static readonly string COMPANY = "Company";

        public static string[] GetValues()
        {
            return new string[] { PERSON,COMPANY };
        }
}
}
