using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkModuleOOP
{
    public class UserData
    {
        private string _firstName;
        public string FirstName 
        { 
            get =>  _firstName;
            set => _firstName = value;
        }
        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (value.Contains("@"))
                {
                    _email = value;
                }
                else throw new ArgumentException();
            }
        }
        private string _phoneNumber;
        public string PhooneNumber
        {
            get => _phoneNumber;
            set
            {
                if (value.Length == 11)
                {
                    _phoneNumber = value;
                }
                else throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            return $"Имя: {_firstName}\nФамилия: {_lastName}\n" +
                $"Телефон: {_phoneNumber}\nemail: {_email}"; 
        }
    }
}
