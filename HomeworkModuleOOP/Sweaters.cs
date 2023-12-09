using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class Sweaters : Product
    {
        public Sweaters(string name, int id, string description)
        {
            _name = name;
            _id = id;
            _description = description;
        }
    }
}
