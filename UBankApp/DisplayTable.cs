using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace UBankApp
{
    public class DisplayTable : DashBoard
    {
        public static void DisplayAllTables() 
        {
            string allprints = "";

            foreach (AccountDetails acc in Program.allaccounts) 
            {
                allprints += $"|     {acc.FullName,-15}|   {acc.Accountnumber ,-15}|     {acc.Accounttype,-15}|      {acc.Accountbalance,-16}|\n";
            }
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine("|     FULLNAME       |  ACCOUNT NUMBER  |   ACCOUNT TYPE     |   ACCOUNT BALANCE    |");
            Console.WriteLine("|--------------------|------------------|--------------------|----------------------|");
            Console.WriteLine(allprints);
            Console.WriteLine("------------------------------------------------------------------------------------");
        }
    }
}
