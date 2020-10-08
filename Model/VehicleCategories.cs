using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VehicleCategories
    {
        public static readonly string SEDAN = "Sedan";
        public static readonly string HATCHBACK = "Hatchback";
        public static readonly string ESTATE = "Estate";
        public static readonly string COUPE = "Coupe";
        public static readonly string SUV = "Suv";
        public static readonly string CONVERTIBLE = "Convertible";
        public static readonly string MONOVOLUME = "Monovolume";
        public static readonly string PASSANGER_VAN = "Passanger van";
        public static readonly string GOODS_VAN = "Goods van";

        public static string[] GetValues()
        {
            return new string[] { SEDAN,HATCHBACK,ESTATE,COUPE,SUV,CONVERTIBLE,MONOVOLUME,PASSANGER_VAN,GOODS_VAN};
        }
    }
}
