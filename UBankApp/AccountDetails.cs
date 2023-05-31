using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UBankApp
{
    public class AccountDetails
    {
        public string FullName { get; set; }
        public string Accountnumber { get; set; }
        public string Accounttype { get; set; }
        public decimal Accountbalance { get; set; }

        public AccountDetails(string fullname, string accountnumber, string accounttype, decimal accountbalance ) 
        { 
            FullName = fullname;
            Accountnumber = accountnumber;
            Accounttype = accounttype;
            Accountbalance = accountbalance;
        }
    }
}
