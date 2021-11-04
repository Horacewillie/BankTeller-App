using System;

namespace BankTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            char run;
            do
            {
                Customer InterestedCustomer = new Customer();
                Investment InvestmentPlan = new Investment();

                InterestedCustomer.GetCustomerDetails();
                InvestmentPlan.CompoundInterestCalculation();

                Console.WriteLine("\n*************************, \n*************************, \n*************************");

                Console.WriteLine("\nDo you want to continue this program? (y/n)");
                run = Convert.ToChar(Console.ReadLine());
            }

            while (run == 'y');
            Console.ReadKey();
        }
    }
}
