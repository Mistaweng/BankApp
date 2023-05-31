using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UBankApp
{
    public class RegisterMe 
    {
        public static string FullName = " ";
        public static string EmailAddress = " ";
        public static string PassWord = " ";
        public void RegisterUser() 
        {
            Console.WriteLine("Please enter your Fullname: ");
            string fullName = Console.ReadLine();
            FullName = fullName;

            Console.WriteLine("Please enter your email address: ");
            string email = Console.ReadLine();
            EmailAddress = email;


            Console.WriteLine("Please enter your password: ");
            string password = Console.ReadLine();
            PassWord = password;

            CustomerDetails RegInput = new CustomerDetails(fullName, email, password);
            Program.allcustomers.Add(RegInput);

            CreateAccount();
        }

        public void CreateAccount()
        {
            Console.WriteLine("What type of account do you want to create");
            Console.WriteLine("1. Current\n2. Savings");
            string AcctType = Console.ReadLine();

            if (AcctType == "1")
            {
                string AccoutType = "Current";

                Console.WriteLine("Your Current account has been created succesfully");

                //Random random = new Random();
                //var i = random.Next(1000000000, 2099999999);
                //string CurrentAcctNo = i.ToString();
                //Console.WriteLine($"Your Current Account number is: {CurrentAcctNo}");

                //AccountDetails CurrentAcct = new AccountDetails(FullName, AccoutType, CurrentAcctNo, AcctBalance);
                //Program.allaccounts.Add(CurrentAcct);


                Login login = new Login();
                login.LoginMeIn();
            }
            else if (AcctType == "2")
            {
                string AccountType = "Savings";

                Console.WriteLine("Your Savings accounts has been created successfully");

                //Random random = new Random();
                //var i = random.Next(1000000000, 2099999999);
                //string SavingsAcctNo = i.ToString();
                //Console.WriteLine($"Your Savings Account number is: {SavingsAcctNo}");

                //AccountDetails SavingsAcct = new AccountDetails(FullName, AccountType, AcctType, AccountBalance);
                //Program.allaccounts.Add(SavingsAcct);


                Login login = new Login();
                login.LoginMeIn();
            }
            else
            {
                Console.WriteLine("Invalid Input!! Please select the right input: 1 or 2");
                CreateAccount();
            }
        }
    }
}
