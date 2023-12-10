using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class Order<TDelivery> where TDelivery : Delivery
    {
        private TDelivery _delivery;
        private Cart<Product> _cart;
        private UserData _userData;

        public Order(Cart<Product> cart, UserData userData, TDelivery delivery)
        {
            _cart = cart;
            _userData = userData;
            _delivery = delivery;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(_userData.ToString());
            sb.Append("\nВы заказали товары:\n" + _cart.ToString());
            sb.Append("\nНа сумму: " + _cart.SummPrice());
            sb.Append("\nПо адресу:\n" + _delivery.ToString());
            return sb.ToString();
        }
    }
}
