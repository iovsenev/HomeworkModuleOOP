using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class ShopDelivery : Delivery
    {
        private string _shopName;
        public string ShopName { get { return _shopName; } }

        public ShopDelivery(string city, string street,
            int houseNumber, string shopName)
        {
            _city = city;
            _street = street;
            _houseNumber = houseNumber;
            _shopName = shopName;
        }
    }
}
