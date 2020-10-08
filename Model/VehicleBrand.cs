using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VehicleBrand
    {
        public int Id
        {
            get; set;
        }

        private string _brandName;
        public string BrandName
        {
            get
            {
                return _brandName;
            }
            set {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Brand name can not be empty!");
                }
                _brandName = value;
            }
        }

        public VehicleBrand() { }

        public VehicleBrand(int id, string brandName)
        {
            Id = id;
            BrandName = brandName;
        }

        public VehicleBrand(VehicleBrand b) : this(b.Id, b.BrandName)
        {
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is VehicleBrand)
            {
                if ((obj as VehicleBrand).Id == Id)
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
