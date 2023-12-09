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
        protected int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                {
                    _id = value;
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
            return $"Товар: {_name} c номером: {_id}";
        }
    }
}
