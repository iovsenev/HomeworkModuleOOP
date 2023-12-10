using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class PointDelivery : Delivery
    {
        private string _namePoint;
        public string NamePoint {  get { return _namePoint; } }

        public PointDelivery(string city, string street,
            int houseNumber, string namePoint)
        {
            _city = city;
            _street = street;
            _houseNumber = houseNumber;
            _namePoint = namePoint;
        }
    }
}
