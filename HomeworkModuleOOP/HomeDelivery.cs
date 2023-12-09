using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    internal class HomeDelivery : Delivery
    {
        private int _flat;
        public int Flat { get { return _flat; } }

        public HomeDelivery(string country, string city, string street,
            int houseNumber, int flat)
        {
            _country = country;
            _city = city;
            _street = street;
            _houseNumber = houseNumber;
            _flat = flat;
        }
    }
}
