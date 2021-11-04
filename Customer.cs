using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller

{
    class Customer
    {
        public string Name;
        public string AccountType = "Savings";


        public string SpecificAccountType
        {
            get { return "Savings"; } 
            set { AccountType = value; }
        }

        public void GetCustomerDetails()
        {
            Investment newInvestment = new Investment();
            Console.WriteLine("Welcome to our Bank Teller App!");

            Console.WriteLine("*************************");

            Console.WriteLine("Please Enter your name:");

            Console.WriteLine("*************************");

            Name = Console.ReadLine();
            Console.WriteLine($"Hi {Name}, Good day!");

            Console.WriteLine("*************************");

            Console.WriteLine("Please do well to provide the account type you operate!");

            Console.WriteLine("*************************");
            AccountType = Console.ReadLine();

            Console.WriteLine("*************************");

            Console.WriteLine($"For a {AccountType} Account, We offer a rate of {newInvestment.RateConversion(AccountType)}%");
        }

    }
}
