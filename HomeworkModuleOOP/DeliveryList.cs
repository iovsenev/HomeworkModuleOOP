using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeworkModuleOOP
{
    public class DeliveryList<TDelivery> : Lists<TDelivery> where TDelivery : Delivery
    {

        public List<TDelivery> DeliveryByCity(string city)
        {
            Dictionary<string, List<TDelivery>> deliveryByCity = new Dictionary<string, List<TDelivery>>();
            foreach (var item in _list)
            {
                if (!deliveryByCity.ContainsKey(item.City))
                    deliveryByCity.Add(item.City, new List<TDelivery>());
                deliveryByCity[item.City].Add(item);
            }
            return deliveryByCity[city];
        }
    }
}
