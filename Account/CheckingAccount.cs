using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class CheckingAccount :Account
    {
        private double fee=1.50;
        public CheckingAccount( string name="UnNamed" ,double balance=0.0) : base(name,balance) 
        { 

        }
         
        public override bool Withdraw(double amount)
        {  
            return base.Withdraw(amount+fee);
        }
        //public override string ToString()
        //{
        //    return base.ToString() + "fee is : " + fee;
        //}
    }
}
