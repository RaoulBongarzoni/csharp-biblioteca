using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class User
    {
        private string _surname;
        private string _name;
        private string _email;
        private string _password;
        private int _phoneNumber;



        public User(string surname, string name, string email, string password, int phonenumber)
        {
            this.Surname = surname;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.PhoneNumber = phonenumber;

        }

        public string Surname {
            get { return _surname; }
            set { _surname = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            
            set { _password = value; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }



        

        //metodo per prendere in prestito un libro
        






        
        
    }




    
}
