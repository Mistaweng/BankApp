namespace UBankApp
{
    internal class Program
    {
        public static List<CustomerDetails> allcustomers = new List<CustomerDetails>();

        public static List<AccountDetails> allaccounts = new List<AccountDetails>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to UBank App\n");
            Console.WriteLine("Select a transaction\n");
            Console.WriteLine("1. Register Account\n2. Login\n3. Exit");
            
            
            string TransType = Console.ReadLine();

            if (TransType == "1") 
            {
                RegisterMe register = new RegisterMe();
                register.RegisterUser();
            }
            else if (TransType == "2") 
            {
                var login = new Login();
                login.LoginMeIn();
            }
            else if (TransType == "3") 
            {
                Console.WriteLine("GoodBye");
                System.Environment.Exit(0); 
            }
            
        }
    }
}