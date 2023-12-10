using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public abstract class Product
    {
        protected string _name;
        protected double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Значение должно быть больше 0.");
                }
            }
        }
        protected string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length < 150)
                {
                    _description = value;
                }
                else
                {
                    throw new ArgumentException("Cлишком длинное описание");
                }

            }
        }

        public override string ToString()
        {
            return $"Товар: {_name} цена: {_price}";
        }
    }
}
