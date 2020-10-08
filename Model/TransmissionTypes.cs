using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
public class TransmissionTypes
    {
        public static readonly string MANUAL = "Manual";
        public static readonly string AUTOMATIC = "Automatic";

        public static string[] GetValues()
        {
            return new string[] { MANUAL,AUTOMATIC };
        }
}
}
