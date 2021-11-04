using BankTeller.BankTeller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller

{
    public class Investment
    {
        public int Total { get; set; }
        public double CompoundInterest { get; set; }
        public int MonthlyCompound { get; set; }
        double[] SavingDuration = {6, 9, 12, 24, 60 };
        public double Savings { get; set; }
        public double Current { get; set; }
        public double Cooperate { get; set; }
        public double DurationToYear { get; set; }
        public double Amount { get; set; }

        public Investment()
        {
            Savings = 30;
            Current = 40;
            Cooperate = 60;
            MonthlyCompound = 12;
        }    

        public double RateConversion(string AccountType)
        {
            if (AccountType == "Savings")
            {
                return Savings / 100;
            }
            else if (AccountType == "Current")
            {
                return Current / 100;
            }
            else if (AccountType == "Cooperate")
            {
                return Cooperate / 100;
            }

            else
            {
                Console.WriteLine("Please enter a valid account type.");
                Environment.Exit(0);
                return 0;
            }
        }

        public void CompoundInterestCalculation()
        {
            Investment NewInvestment = new Investment();
            Customer InterestedCustomer = new Customer();
            Console.WriteLine("How much do you want to invest?");
            Total = int.Parse(Console.ReadLine());
            foreach (var duration in SavingDuration)
            {
                DurationToYear = duration / 12;
                Amount = Total * Math.Pow((1 + NewInvestment.RateConversion(InterestedCustomer.AccountType) / MonthlyCompound),MonthlyCompound * DurationToYear);

                Console.WriteLine("*************************");

                Console.WriteLine($"In {duration} months, your investment will amount to  ${Amount}");
            }

        }

        //int IValueAddedTax.VatRate(decimal vatRate)
        //{
          // decimal vatRate = 0.075;
           
        //}
    }
}