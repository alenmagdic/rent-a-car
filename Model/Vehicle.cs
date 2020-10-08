using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Vehicle
    {

        public Vehicle() { }
        public Vehicle(Vehicle v) : this(v.Id,v.Brand,v.ModelName,v.Category,v.TrunkCapacityLiters,v.NumberOfSeats,v.EngineType,v.EnginePower,v.TransmissionType,v.Length,v.Height,v.Width,v.LicensePlate,v.VehicleId)
        {
        }

        public Vehicle(int id, VehicleBrand brand, string modelName, string category, int trunkCapacity, int numberOfSeats, string engineType, int power, string transmissionType, int length, int height, int width, string licensePlate,string vehicleId)
        {
            Id = id;
            Brand = brand;
            ModelName = modelName;
            Category = category;
            TrunkCapacityLiters = trunkCapacity;
            NumberOfSeats = numberOfSeats;
            EngineType = engineType;
            EnginePower = power;
            TransmissionType = transmissionType;
            Length = length;
            Height = height;
            Width = width;
            VehicleId = vehicleId;
            LicensePlate = licensePlate;
        }

        public int Id
        {
            get; set;
        }

        private VehicleBrand _brand;
        public VehicleBrand Brand
        {
            get
            {
                return _brand;
            }
            set
            {
                if(value==null)
                {
                    throw new Exception("Brand is a required field!");
                }
                _brand = value;
            }
        }

        private string _modelName;
        public string ModelName
        {
            get {
                return _modelName;
            } set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Model name can not be empty!");
                }
                _modelName = value;
            }
        }

        private string _category;
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (VehicleCategories.GetValues().Contains(value))
                {
                    _category = value;
                    return;
                }
                throw new Exception("Trying to set invalid vehicle category: " + value);

            }
        }

        private int _trunkCapacityLiters;
        public int TrunkCapacityLiters
        {
            get {
                return _trunkCapacityLiters;
                    } set
            {
                if(value<0)
                {
                    throw new Exception("Trunk capacity can not be a negative value!");
                }
                _trunkCapacityLiters = value;
            }
        }

        private int _numberOfSeats;
        public int NumberOfSeats
        {
            get
            {
                return _numberOfSeats;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Number of seats can not be a negative value!");
                }
                _numberOfSeats = value;
            }
        }

        private string _engineType;
        public string EngineType
        {
            get
            {
                return _engineType;
            }
            set
            {
                if (EngineTypes.GetValues().Contains(value))
                {
                    _engineType = value;
                    return;
                }
                throw new Exception("Trying to set invalid engine type: " + value);

            }
        }
        private int _enginePower;
        public int EnginePower
        {
            get
            {
                return _enginePower;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Engine power can not be a negative value!");
                }
                _enginePower = value;
            }
        }
        private string _transmissionType;
        public string TransmissionType
        {
            get
            {
                return _transmissionType;
            }
            set
            {
                if (TransmissionTypes.GetValues().Contains(value))
                {
                    _transmissionType = value;
                    return;
                }
                throw new Exception("Trying to set invalid transmission type: " + value);

            }
        }
        private int _length;
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Length can not be a negative value!");
                }
                _length = value;
            }
        }
        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Height can not be a negative value!");
                }
                _height = value;
            }
        }
        private int _width;
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Width can not be a negative value!");
                }
                _width = value;
            }
        }
        private string _vehicleId;
        public string VehicleId
        {
            get
            {
                return _vehicleId;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Vehicle ID can not be empty!");
                }
                _vehicleId = value;
            }
        }
        private string _licensePlate;
        public string LicensePlate
        {
            get
            {
                return _licensePlate;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("License plate can not be empty!");
                }
                _licensePlate = value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj is Vehicle)
            {
                if ((obj as Vehicle).Id == Id)
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
