using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsLib
{
    public class LoanAccount: AccountBase
    {
        private bool depositeFlag = false;

        public LoanAccount(string name, double balance) : 
            base(name, balance, AccountType.LOAN)
        {
            Console.WriteLine("Account created ");
        }

        public override double depositeAmount(double amount)
        {
            if (isActive && !depositeFlag)
            {
                this.Balance += amount;
            }
            else
            {
                Console.WriteLine("Operation not supported");
            }
            return this.Balance;
        }

        public override double withDrawAmount(double amount)
        {
            if (isActive && this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Operation not supported");
            }
            return this.Balance;
        }
    }
}
