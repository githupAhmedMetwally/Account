using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class TrustAccount:Account
    {
        public double intRate { get; set; }
        public TrustAccount(string name="unNamed",double balance=0.0,double intRate=0.0) : base(name, balance)
        {
            this.intRate = intRate;
        }

        public override bool Deposit(double amount)
        {
            if (amount >= 5000.0)
            {
                return base.Deposit(amount + 50.0); 
            }
            else
                return base.Deposit(amount); 
        }

        public override bool Withdraw(double amount)
        {
            double limit = 0.2;
            int  maxWithdrow = 3;
            int withdrawCount = 0;
            if (withdrawCount >= maxWithdrow)
            {
                Console.WriteLine("You have exceeded the maximum number of withdrawals (3) during the current year.");
                return false;
            }
            if (amount >= Balance*limit)
            {
                Console.WriteLine("You cannot withdraw more than 20% of your account balance..");
                return false;
            }
            bool success = base.Withdraw(amount);
            if (success)
            {
                withdrawCount++;
            }

            return success;
        }
        //public override string ToString()
        //{
        //    return base.ToString()+"intRate is:  " + intRate;
        //}
    }
}
