using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBankApp
{
    public class CustomerDetails
    {
        public string FullName { get; set; }
        public string Email { get; set;}
        public  string Password { get; set; }

        public CustomerDetails(string fullname, string email, string password) 
        {
            FullName = fullname;
            Email = email;
            Password = password;
        }
    }

}
