using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkModuleOOP
{
    public class Cart<TProduct> : Lists<TProduct> where TProduct : Product
    {
        public double SummPrice()
        {
            var sum = 0.0;
            foreach (var item in _list)
            {
                sum += item.Price;
            }
            return sum;
        }

    }
}
