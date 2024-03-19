using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SavingAccount :Account
    {
        public double intRate { get; set; }
        public  SavingAccount(string name="",double balance=0.0,double intRate=0.0) : base(name, balance)
        {
            this.intRate=intRate;
        }
        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount+intRate);
        }
        //public override string ToString()
        //{
        //    return base.ToString()+ "intRate is:  " + intRate;
        //}
    }
}
