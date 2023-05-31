using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace UBankApp
{
    public class DashBoard : Login
    {
        public void  MyDashboard() 
        {
            Console.WriteLine("Welcome to your DashBoard\n");
            Console.WriteLine("Please select an option");
            Console.Write("1. Setup Account\n2. Check Balance\n3. Deposit\n4. Withdraw\n5. Account Details\n6. Account Statement\n7. Transfer\n8. Logout\n");
            Console.WriteLine("");

            string Option = Console.ReadLine();

            Console.WriteLine(Option);

            if (Option == "1") 
            {
                SetUpAccount();
                
                //Console.WriteLine("Make a deposit:");
                //decimal deposit = decimal.Parse(Console.ReadLine());
                MyDashboard();
            }
            else if (Option == "2") 
            {
                
                CheckBalance();
                //string AcctNumber = Console.ReadLine();   
                //Console.WriteLine($"Your account balance is: ");
                MyDashboard();
            }
            else if(Option == "3") 
            {
                Deposit();

                //Console.WriteLine("Enter the amount to deposit");
                MyDashboard();
            }
            else if (Option == "4") 
            {
                Withdraw();
                //Console.WriteLine("To make a withdrawal, enter the amonut");
                MyDashboard();

            }
            else if (Option == "5") 
            {
                DisplayTable.DisplayAllTables();

                MyDashboard();
            }
            else if (Option == "6") 
            {
                MyDashboard();
                Console.WriteLine("Below is your account details");
            }
            else if (Option == "7") 
            {
                Transfer();
                //Console.WriteLine("Enter the amonut you want to transfer");
                MyDashboard();
            }
            else if (Option == "8") 
            {
                DisplayTable display = new DisplayTable();
                //display.DisplayAllTables();
                Console.WriteLine("Thank you for banking with us!!");
            }

             void SetUpAccount() 
            {
                string Acct = "";
                Console.WriteLine("Enter an account type: \n1. Current\n2.Savings");
                string AcctType = Console.ReadLine();
                

                if(AcctType == "1") 
                {
                    Acct = "current";

                    Random random = new Random();
                    var i = random.Next(1000000000, 2099999999);
                    string accountnumber = i.ToString();
                    Console.WriteLine($"Your Current Account number is: {accountnumber}");
                    //Console.WriteLine(accountnumber);

                    decimal accountbalance = 0;
                    Console.WriteLine($"Your current account balance is: {accountbalance}");

                    Console.WriteLine("Make an initial deposit:");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                    accountbalance += deposit;
                    Console.WriteLine($"Your initial deposit is: {deposit}");

                    AccountDetails all = new AccountDetails(FullName,accountnumber,Acct,accountbalance); 
                    Program.allaccounts.Add(all);

                }
                else if(AcctType == "2") 
                {
                    Acct = "savings";

                    Random random = new Random();
                    var i = random.Next(1000000000, 2099999999);
                    string accountnumber = i.ToString();
                    Console.WriteLine($"Your Current Account number is: {accountnumber}");
                    //Console.WriteLine(accountnumber);

                    decimal accountbalance = 0;
                    Console.WriteLine($"Your account balance is: {accountbalance}");

                    Console.WriteLine("Make a initial deposit:");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                }
                else
                {
                    SetUpAccount();
                }
            }
        }


        void CheckBalance()
        {
            string AcctNumber = "";

            Console.WriteLine($"Please Enter your Account Number");
            AcctNumber = Console.ReadLine();

            foreach (AccountDetails account in Program.allaccounts)
            {
                if  (account.Accountnumber == AcctNumber )
                {
                    Console.WriteLine($"Your balance for account number {AcctNumber} is {account.Accountbalance}");
                }
                else
                {
                    CheckBalance();
                }
            }
        }


        static void Deposit()
        {
            string AcctNumber = "";

            Console.WriteLine("Please Enter Your Account Number");
            AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount to deposit");
            decimal deposit = Decimal.Parse(Console.ReadLine());

            foreach (AccountDetails account in Program.allaccounts)
            {
                if (AcctNumber == account.Accountnumber)
                {
                    deposit += account.Accountbalance;
                    Console.WriteLine($"Your account balance for {AcctNumber} is {deposit}");
                }
                else
                {
                    Deposit();
                }
            }
        }


        static void Withdraw() 
        {
            string AcctNumber = "";
            Console.WriteLine("Please Enter your account number");
            AcctNumber = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Withdraw");
            decimal withdraw = Decimal.Parse(Console.ReadLine());

            foreach(AccountDetails account in Program.allaccounts) 
            {
                if(account.Accountnumber == AcctNumber) 
                {
                    account.Accountbalance -= withdraw;
                    Console.WriteLine($"Your account balance for {AcctNumber} is {withdraw}");
                }
                else
                {
                    Withdraw();
                }
            }
        }



        void Transfer() 
        {
            string AcctNumber = "";
            string sourceAccount = "";
            string transferAccount = "";
            decimal amountTransfer = 0;

            Console.WriteLine("Please Enter the source account number");
            sourceAccount = Console.ReadLine();

            Console.WriteLine("Enter the amount you want to Transfer");
            amountTransfer = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter beneficiary account number");
            transferAccount = Console.ReadLine();

            if (sourceAccount != null && transferAccount != null)
            {
                foreach (AccountDetails account in Program.allaccounts)
                {
                    if (account.Accountnumber == AcctNumber && amountTransfer == account.Accountbalance)
                    {
                        account.Accountbalance += amountTransfer;
                        Console.WriteLine("Transfer Successfull");
                        Console.WriteLine($"Your current account balance for {amountTransfer} is: {amountTransfer}");
                    }
                    //else if (account.Accountnumber == transferAccount)
                    //{
                    //    account.Accountbalance += amountTransfer;
                    //    Console.WriteLine("Transfer Successfull");
                    //    Console.WriteLine($"Your current account balance for {amountTransfer} is: {amountTransfer}");                       
                    //}
                    else
                    {
                        Transfer();
                    }


                    //if(account.Accountnumber == transferAccount) 
                    // {
                    //     if(account.Accountbalance <= 1000 && account.Accounttype == "Savings") 
                    //     {

                    //     }
                    //     else if(account.Accountbalance > amountTransfer && account.Accounttype = "Current") 
                    //     {
                    //         account.Accountnumber -= amountTransfer;
                    //     }
                    // } 

                    //if (account.Accountnumber = amountTransfer) 
                    //{
                    //    account.Accountbalance += amountTransfer;
                    //}
                    //else 
                    //{
                    //    Transfer();
                    //}
                    
                }

                void Logout()
                {
                    System.Environment.Exit(0);
                    Console.WriteLine("Thank you for Banking with us!!!");
                }
            }   
        }
    }
}
