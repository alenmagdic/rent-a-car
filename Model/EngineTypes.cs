using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EngineTypes
    {
        public static readonly string PETROL = "Petrol";
        public static readonly string DIESEL = "Diesel";
        public static readonly string HYBRID = "Hybrid";
        public static readonly string ELECTRIC = "Electric";

    public static string[] GetValues()
    {
        return new string[] { PETROL,DIESEL,HYBRID,ELECTRIC };
    }
}
}
