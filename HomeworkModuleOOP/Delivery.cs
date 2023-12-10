using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public abstract class Delivery
    {
        protected string _city;
        protected string _street;
        protected int _houseNumber;
        
        public string City
        {
            get { return _city; }
            set
            {
                if (value != "") _city = value;
                else throw new ArgumentException("invalid enter");
            }

        }

        public string Street
        {
            get { return _street; }
            set
            {
                if (value != "") _street = value;
                else throw new ArgumentException("invalid enter");
            }

        }

        public int HouseNumber
        {
            get { return _houseNumber; }
            set
            {
                if (value > 0) _houseNumber = value;
                else throw new ArgumentException("invalid enter");
            }
        }

        public override string ToString()
        {
            return $"{_city}, {_street}, {_houseNumber}";
        }
    }
}
