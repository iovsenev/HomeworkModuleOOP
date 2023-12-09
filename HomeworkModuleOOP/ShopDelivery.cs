using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    internal class ShopDelivery:Delivery
    {
        private string _shopName;
        public string ShopName { get { return _shopName; } }

        public ShopDelivery( string country, string city, string street,
            int houseNumber, string shopName)
        {
            _country = country;
            _city = city;
            _street = street;
            _houseNumber = houseNumber;
            _shopName = shopName;
        }
    }
}
