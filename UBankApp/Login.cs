using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBankApp
{
    public class Login: RegisterMe
    {
        public void LoginMeIn() 
        {
            Console.WriteLine("Please enter your email address");
            string Email = Console.ReadLine();

            Console.WriteLine("Please enter your password");
            string Password = Console.ReadLine();
          

            if (Email == EmailAddress && Password == PassWord) 
            {
                Console.WriteLine("You are Logged in Successfully");
                DashBoard dashBoard = new DashBoard();
                dashBoard.MyDashboard();
            }
            else
            {
                Console.WriteLine("Invalid Login Details");
                LoginMeIn();
            }


        }
    }
}
