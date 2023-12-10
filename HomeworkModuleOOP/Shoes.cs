using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class Shoes : Product
    {
        
        public Shoes(string name) : this(name, 0, "нет описания") { }
        public Shoes(string name, double price, string description)
        {
            _name = name;
            _price = price;
            _description = description;
        }
    }
}
