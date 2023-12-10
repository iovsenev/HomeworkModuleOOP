using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class Sweaters : Product
    {
        public Sweaters(string name, double price, string description)
        {
            _name = name;
            _price = price;
            _description = description;
        }
    }
}
